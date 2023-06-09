using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace IdkWhat
{
    public partial class GameForm : Form
    {
        private Users user;
        private int coordX = 700;
        private int coordY = 700;
        private Panel player = new Panel();
        private List<Panel> bullets = new List<Panel>();
        private List<Panel> rowOfPanels = new List<Panel>();
        private List<Panel> enemyBullets = new List<Panel>();
        private bool isMovingUp;
        private bool isMovingDown;
        private bool isMovingLeft;
        private bool isMovingRight;
        private bool isShooting;
        private bool isEnemyShooting;
        private bool isAlive;
        private Timer collisionTimer;
        private Timer enemyShootTimer;

        private Thread movementThread;
        private Thread bulletThread;
        private Thread enemyBulletThread;
        private CancellationTokenSource cancellationTokenSource;

        public GameForm(Users user)
        {
            this.user = user;
            InitializeComponent();
            paintPlayer();
            KeyDown += playerKeyDown;
            KeyUp += playerKeyUp;
            GenerateRowOfPanels();

            isAlive = true;

            collisionTimer = new Timer();
            collisionTimer.Interval = 10; // 100 milliseconds
            collisionTimer.Tick += CollisionTimer_Tick;
            collisionTimer.Start();

            enemyShootTimer = new Timer();
            enemyShootTimer.Interval = 3000; // 3 seconds
            enemyShootTimer.Tick += EnemyShootTimer_Tick;
            enemyShootTimer.Start();

            cancellationTokenSource = new CancellationTokenSource();
        }

        private void CollisionTimer_Tick(object sender, EventArgs e)
        {
            CheckBulletPanelCollision();
            CheckEnemyBulletPlayerCollision();
        }

        private void EnemyShootTimer_Tick(object sender, EventArgs e)
        {
            if (isAlive)
            {
                ShootEnemy();
            }
        }

        public void paintPlayer()
        {
            player.Location = new Point(coordX, coordY);
            player.BackColor = Color.Red;
            player.Size = new Size(20, 20);
            this.Controls.Add(player);
        }

        private void playerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && !isMovingDown && !isMovingRight && !isMovingLeft)
            {
                isMovingUp = true;
                StartMovementThread();
            }
            else if (e.KeyCode == Keys.S && !isMovingUp && !isMovingRight && !isMovingLeft)
            {
                isMovingDown = true;
                StartMovementThread();
            }
            else if (e.KeyCode == Keys.A && !isMovingDown && !isMovingRight && !isMovingUp)
            {
                isMovingLeft = true;
                StartMovementThread();
            }
            else if (e.KeyCode == Keys.D && !isMovingDown && !isMovingUp && !isMovingLeft)
            {
                isMovingRight = true;
                StartMovementThread();
            }
            else if (e.KeyCode == Keys.Space)
            {
                Shoot();
            }
        }


        private void playerKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                isMovingUp = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                isMovingDown = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                isMovingRight = false;
            }

            if (!isMovingUp && !isMovingDown && !isMovingLeft && !isMovingRight)
            {
            }
        }

        private void StartMovementThread()
        {
            movementThread = new Thread(() =>
           {
               while (isMovingUp || isMovingDown || isMovingLeft || isMovingRight)
               {
                   if (isMovingUp)
                   {
                       MovePlayerUp();
                   }
                   if (isMovingDown)
                   {
                       MovePlayerDown();
                   }
                   if (isMovingLeft)
                   {
                       MovePlayerLeft();
                   }
                   if (isMovingRight)
                   {
                       MovePlayerRight();
                   }

                   Thread.Sleep(10);
               }
           });
            movementThread.Start();
        }

        private void StopMovementThread()
        {
            movementThread?.Abort(); // Abort the movement thread if it's not null
        }

        private void MovePlayerUp()
        {
            player.Invoke((MethodInvoker)(() =>
            {
                if (player.Location.Y < ClientSize.Height)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y - 5);
                }
            }));
        }

        private void MovePlayerDown()
        {
            player.Invoke((MethodInvoker)(() =>
            {
                if (player.Location.Y < ClientSize.Height - player.Height)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y + 5);
                }
            }));
        }

        private void MovePlayerLeft()
        {
            player.Invoke((MethodInvoker)(() =>
            {
                if (player.Location.X > 0)
                {
                    player.Location = new Point(player.Location.X - 5, player.Location.Y);
                }
            }));
        }

        private void MovePlayerRight()
        {
            player.Invoke((MethodInvoker)(() =>
            {
                if (player.Location.X < ClientSize.Width - player.Width)
                {
                    player.Location = new Point(player.Location.X + 5, player.Location.Y);
                }
            }));
        }

        private void Shoot()
        {
            if (isShooting)
            {
                return; // Return if already shooting
            }

            isShooting = true; // Set shooting state to true

            Panel bullet = new Panel();
            bullet.BackColor = Color.Black;
            bullet.Size = new Size(5, 5);
            bullet.Location = new Point(player.Location.X + player.Width / 2, player.Location.Y);
            Controls.Add(bullet);
            bullets.Add(bullet);

            bulletThread = new Thread(() =>
           {
               while (bullet.Location.Y > 0)
               {
                   bullet.Invoke((MethodInvoker)(() =>
                   {
                       bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 5);

                       if (bullet.Location.Y <= 0)
                       {
                           bullets.Remove(bullet);
                           Controls.Remove(bullet);
                       }
                   }));

                   Thread.Sleep(5);
               }

               isShooting = false; // Reset shooting state to false after bullet is done
           });
            bulletThread.Start();
        }

        private void GenerateRowOfPanels()
        {
            int panelWidth = 50; // Width of each panel
            int panelHeight = 20; // Height of each panel
            int panelSpacing = 5; // Spacing between each panel

            int numPanels = ClientSize.Width / (panelWidth + panelSpacing); // Calculate the number of panels that can fit in the frame
            int initialX = (ClientSize.Width - (numPanels * (panelWidth + panelSpacing))) / 2; // Calculate the initial X position to center the row

            for (int i = 0; i < numPanels; i++)
            {
                Panel panel = new Panel();
                panel.BackColor = Color.Blue;
                panel.Size = new Size(panelWidth, panelHeight);
                panel.Location = new Point(initialX + i * (panelWidth + panelSpacing));

                if (IsHandleCreated)
                {
                    // Use Invoke to add the panel to the Controls collection on the UI thread
                    Invoke((MethodInvoker)(() =>
                    {
                        Controls.Add(panel);
                    }));
                }
                else
                {
                    // If the handle is not yet created, add the panel directly
                    Controls.Add(panel);
                }

                rowOfPanels.Add(panel);
            }
        }


        private void ShootEnemy()
        {
            foreach (Panel enemy in rowOfPanels)
            {
                if (!IsEnemyShooting(enemy))
                {
                    CreateEnemyBullet(enemy, cancellationTokenSource.Token);
                }
            }
        }

        private bool IsEnemyShooting(Panel enemy)
        {
            foreach (Panel bullet in enemyBullets)
            {
                if (bullet.Tag == enemy)
                {
                    return true;
                }
            }
            return false;
        }

        private volatile bool stopEnemyBulletThread = false;

        private void CreateEnemyBullet(Panel enemy, CancellationToken cancellationToken)
        {
            if (!isAlive || IsDisposed)
            {
                return;
            }

            Panel enemyBullet = new Panel();
            enemyBullet.BackColor = Color.Black;
            enemyBullet.Size = new Size(5, 5);
            enemyBullet.Location = new Point(enemy.Location.X + enemy.Width / 2, enemy.Location.Y + enemy.Height);
            enemyBullet.Tag = enemy; // Tag the bullet with the corresponding enemy panel

            if (IsHandleCreated)
            {
                Invoke((MethodInvoker)(() => Controls.Add(enemyBullet)));
            }
            else
            {
                Controls.Add(enemyBullet);
            }

            enemyBullets.Add(enemyBullet);

            enemyBulletThread = new Thread(() =>
            {
                while (enemyBullet.Location.Y < ClientSize.Height && !cancellationToken.IsCancellationRequested)
                {
                    if (IsDisposed)
                    {
                        return;
                    }

                    if (Controls.Contains(enemyBullet)) // Check if the control is still in the Controls collection
                    {
                        enemyBullet.Invoke((MethodInvoker)(() =>
                        {
                            enemyBullet.Location = new Point(enemyBullet.Location.X, enemyBullet.Location.Y + 10);

                            if (enemyBullet.Location.Y >= ClientSize.Height)
                            {
                                enemyBullets.Remove(enemyBullet);
                                Controls.Remove(enemyBullet);
                            }
                        }));
                    }
                    else
                    {
                        return;
                    }

                    Thread.Sleep(5); // Decreased sleep time to increase bullet speed
                }

                enemyBullet.Tag = null; // Reset the bullet's tag to indicate it's no longer associated with any enemy panel
            });

            enemyBulletThread.Start();
        }



        // Method to stop the enemy bullet thread+
        private void StopEnemyBulletThread()
        {
            stopEnemyBulletThread = true;
        }



        private void CheckBulletPanelCollision()
        {
            Thread collisionThread = new Thread(() =>
            {
                List<Panel> panelsToRemove = new List<Panel>();
                List<Panel> bulletsToRemove = new List<Panel>();

                foreach (Panel bullet in bullets)
                {
                    bool bulletCollided = false;

                    foreach (Panel panel in rowOfPanels)
                    {
                        if (bullet.Bounds.IntersectsWith(panel.Bounds))
                        {
                            panelsToRemove.Add(panel);
                            bulletsToRemove.Add(bullet);
                            bulletCollided = true;
                            break; // Break the inner loop after detecting the collision
                        }
                    }

                    if (bulletCollided)
                    {
                        break; // Break the outer loop if a collision occurred
                    }
                }

                foreach (Panel enemy in panelsToRemove)
                {
                    enemy.Invoke((MethodInvoker)(() =>
                    {
                        rowOfPanels.Remove(enemy);
                        Controls.Remove(enemy);
                    }));
                }

                foreach (Panel bullet in bulletsToRemove)
                {
                    bullet.Invoke((MethodInvoker)(() =>
                    {
                        bullets.Remove(bullet);
                        Controls.Remove(bullet);
                    }));
                }

                bullets.RemoveAll(bullet => bullet.Bounds.Y <= 0);

                // Check if rowOfPanels is empty
                if (rowOfPanels.Count == 0)
                {
                    GenerateRowOfPanels();
                }
            });

            collisionThread.Start();
        }
        private void CheckEnemyBulletPlayerCollision()
        {
            List<Panel> bulletsToRemove = new List<Panel>();

            foreach (Panel bullet in enemyBullets)
            {
                if (bullet.Bounds.IntersectsWith(player.Bounds))
                {
                    bulletsToRemove.Add(bullet);
                    isAlive = false;

                    if (this.IsHandleCreated)
                    {
                        ShowFinishForm();
                    }
                    else
                    {
                        this.HandleCreated += (sender, e) =>
                        {
                            ShowFinishForm();
                        };
                    }
                }
            }
        }

        private void ShowFinishForm()
        {
            cancellationTokenSource.Cancel();
            FinishForm finishForm = new FinishForm();
            finishForm.Show();
            this.Invoke((MethodInvoker)(() => this.Close()));
        }

    }
}




