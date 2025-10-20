using System.Drawing; // Ensure this is at the top
using System.Windows.Forms; // Ensure this is at the top
using Timer = System.Windows.Forms.Timer; // Explicitly specify Timer

namespace combat
{
    public partial class Form1 : Form
    {
        private Point player1Position = new Point(50, 50);
        private Point player2Position = new Point(200, 50);
        private readonly Size playerSize = new Size(40, 40);

        private int player1Score = 0;
        private int player2Score = 0;

        private readonly Size bulletSize = new Size(10, 10);
        private readonly int bulletSpeed = 10;
        private readonly Timer bulletTimer = new Timer();

        private bool p1BulletActive = false;
        private bool p2BulletActive = false;

        public Form1()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.KeyPreview = true;
                this.DoubleBuffered = true;
                this.KeyDown += Form1_KeyDown;

                p1bullet.Visible = false;
                p2bullet.Visible = false;

                bulletTimer.Interval = 20;
                bulletTimer.Tick += BulletTimer_Tick;
                bulletTimer.Start();
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            const int moveAmount = 5;

            Point prevPlayer1 = player1Position;
            Point prevPlayer2 = player2Position;

            bool moved = false;

            switch (e.KeyCode)
            {
                case Keys.W:
                    player1Position.Y -= moveAmount;
                    moved = true;
                    break;
                case Keys.S:
                    player1Position.Y += moveAmount;
                    moved = true;
                    break;
                case Keys.A:
                    player1Position.X -= moveAmount;
                    moved = true;
                    break;
                case Keys.D:
                    player1Position.X += moveAmount;
                    moved = true;
                    break;
                case Keys.Up:
                    player2Position.Y -= moveAmount;
                    moved = true;
                    break;
                case Keys.Down:
                    player2Position.Y += moveAmount;
                    moved = true;
                    break;
                case Keys.Left:
                    player2Position.X -= moveAmount;
                    moved = true;
                    break;
                case Keys.Right:
                    player2Position.X += moveAmount;
                    moved = true;
                    break;
                case Keys.Space:
                case Keys.Q: // Player 1 shoots with Q or Space
                    if (!p1BulletActive)
                    {
                        // Set bullet position relative to player1's current position
                        p1bullet.Left = player1Position.X + playerSize.Width;
                        p1bullet.Top = player1Position.Y + playerSize.Height / 2 - bulletSize.Height / 2;
                        p1bullet.Size = bulletSize;
                        p1bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                        p1bullet.Visible = true;
                        p1BulletActive = true;
                    }
                    break;
                case Keys.Enter:
                case Keys.OemQuestion: // Player 2 shoots with / or Enter
                    if (!p2BulletActive)
                    {
                        // Set bullet position relative to player2's current position
                        p2bullet.Left = player2Position.X - bulletSize.Width;
                        p2bullet.Top = player2Position.Y + playerSize.Height / 2 - bulletSize.Height / 2;
                        p2bullet.Size = bulletSize;
                        p2bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                        p2bullet.Visible = true;
                        p2BulletActive = true;
                    }
                    break;
            }

            player1Position.X = Math.Clamp(player1Position.X, 0, this.ClientSize.Width - playerSize.Width);
            player1Position.Y = Math.Clamp(player1Position.Y, 0, this.ClientSize.Height - playerSize.Height);
            player2Position.X = Math.Clamp(player2Position.X, 0, this.ClientSize.Width - playerSize.Width);
            player2Position.Y = Math.Clamp(player2Position.Y, 0, this.ClientSize.Height - playerSize.Height);

            if (PlayersCollide())
            {
                player1Position = prevPlayer1;
                player2Position = prevPlayer2;
            }

            if (moved)
                Invalidate();

            // Only update bullet positions if not active
            if (!p1BulletActive)
            {
                p1bullet.Left = player1Position.X + playerSize.Width;
                p1bullet.Top = player1Position.Y + playerSize.Height / 2 - bulletSize.Height / 2;
            }
            if (!p2BulletActive)
            {
                p2bullet.Left = player2Position.X - bulletSize.Width;
                p2bullet.Top = player2Position.Y + playerSize.Height / 2 - bulletSize.Height / 2;
            }
        }

        private void FireP1Bullet()
        {
            if (!p1BulletActive)
            {
                p1bullet.Location = new Point(player1Position.X + playerSize.Width, player1Position.Y + playerSize.Height / 2 - bulletSize.Height / 2);
                p1bullet.Size = bulletSize;
                p1bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                p1bullet.Visible = true;
                p1BulletActive = true;
            }
        }

        private void FireP2Bullet()
        {
            if (!p2BulletActive)
            {
                p2bullet.Location = new Point(player2Position.X - bulletSize.Width, player2Position.Y + playerSize.Height / 2 - bulletSize.Height / 2);
                p2bullet.Size = bulletSize;
                p2bullet.SizeMode = PictureBoxSizeMode.StretchImage;
                p2bullet.Visible = true;
                p2BulletActive = true;
            }
        }

        private void BulletTimer_Tick(object? sender, EventArgs e)
        {
            bool needInvalidate = false;

            // Move p1bullet only if active
            if (p1BulletActive)
            {
                p1bullet.Left += bulletSpeed;
                Rectangle bulletRect = new Rectangle(p1bullet.Location, bulletSize);
                Rectangle player2Rect = new Rectangle(player2Position, playerSize);
                if (bulletRect.IntersectsWith(player2Rect))
                {
                    player1Score++;
                    ResetBullet(1);
                    ResetPlayers();
                    needInvalidate = true;
                }
                else if (p1bullet.Left > this.ClientSize.Width)
                {
                    ResetBullet(1);
                }
            }

            // Move p2bullet only if active
            if (p2BulletActive)
            {
                p2bullet.Left -= bulletSpeed;
                Rectangle bulletRect = new Rectangle(p2bullet.Location, bulletSize);
                Rectangle player1Rect = new Rectangle(player1Position, playerSize);
                if (bulletRect.IntersectsWith(player1Rect))
                {
                    player2Score++;
                    ResetBullet(2);
                    ResetPlayers();
                    needInvalidate = true;
                }
                else if (p2bullet.Right < 0)
                {
                    ResetBullet(2);
                }
            }

            this.Text = $"Player 1: {player1Score} | Player 2: {player2Score}";

            if (needInvalidate)
                Invalidate();
        }

        private void ResetBullet(int player)
        {
            if (player == 1)
            {
                p1bullet.Visible = false;
                p1BulletActive = false;
                UpdateP1BulletPosition();
            }
            else if (player == 2)
            {
                p2bullet.Visible = false;
                p2BulletActive = false;
                UpdateP2BulletPosition();
            }
        }

        private void ResetPlayers()
        {
            player1Position = new Point(50, 50);    
            player2Position = new Point(200, 50);
        }

        private void UpdateP1BulletPosition()
        {
            // Also update the Y position to follow player1
            p1bullet.Location = new Point(player1Position.X + playerSize.Width, player1Position.Y + playerSize.Height / 2 - bulletSize.Height / 2);
        }

        private void UpdateP2BulletPosition()
        {
            // Also update the Y position to follow player2
            p2bullet.Location = new Point(player2Position.X - bulletSize.Width, player2Position.Y + playerSize.Height / 2 - bulletSize.Height / 2);
        }

        private bool PlayersCollide()
        {
            Rectangle rect1 = new Rectangle(player1Position, playerSize);
            Rectangle rect2 = new Rectangle(player2Position, playerSize);
            return rect1.IntersectsWith(rect2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(player1Position, playerSize));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(player2Position, playerSize));
        }
    }
}
