using System.Threading;

namespace pong
{
    public partial class Form1 : Form
    {
        int p1direction = 0;
        int p2direction = 0;
        int ballx = 15;
        int bally = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                player1.Top  -= 25;
            }
            else if (e.KeyChar == 's')
            {
                player1.Top  += 25;
            }
            else if (e.KeyChar == 'o')
            {
                player2.Top -= 25;
            }
            else if (e.KeyChar == 'l')
            {
                player2.Top += 25;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1direction = -1;
            }
            else if (e.KeyCode == Keys.S)
            {
                p1direction = 1;
            }
            else if (e.KeyCode == Keys.O)
            {
                p2direction = -1;
            }
            else if (e.KeyCode == Keys.L)
            {
                p2direction = 1;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                p1direction = 0;
            }
            else if (e.KeyCode == Keys.O || e.KeyCode == Keys.L)
            {
                p2direction = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttont_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttons_Click(object sender, EventArgs e)
        {
            ball.Visible = true;
            buttonp.Visible = false;
            buttons.Visible = false;
            player11.Visible = true;
            player22.Visible = true;
            outofbounds1.Visible = true;
            outofbounds2.Visible = true;
            goal.Visible = true;
            goal2.Visible = true;
            score1.Visible = true;
            score2.Visible = true;
            outofbounds11.Visible = false;
            outofbounds22.Visible = false;
        }

        private void buttonp_Click(object sender, EventArgs e)
        {
            player1.Visible = true;
            player2.Visible = true;
            ball.Visible = true;
            buttonp.Visible = false;
            buttons.Visible = false;
            outofbounds1.Visible = false;
            outofbounds2.Visible = false;
            goal.Visible = false;
            goal2.Visible = false;
            score1.Visible = true;
            score2.Visible = true;
            outofbounds11.Visible = true;
            outofbounds22.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (player1.Top + p1direction >= 0 && player1.Top + player1.Height + p1direction <= ClientSize.Height)
            {
                player1.Top += p1direction ;
            }
            if (player2.Top + p2direction >= 0 && player2.Top + player2.Height + p2direction <= ClientSize.Height)
            {
                player2.Top += p2direction;
            }
            if (player11.Top + p1direction >= 0 && player11.Top + player11.Height + p1direction <= ClientSize.Height)
            {
                player11.Top += p1direction;
            }
            if (player22.Top + p2direction >= 0 && player22.Top + player22.Height + p2direction <= ClientSize.Height)
            {
                player22.Top += p2direction;
            }
            if (outofbounds1.Top + p1direction >= 0 && outofbounds1.Top + outofbounds1.Height + p1direction <= ClientSize.Height)
            {
                outofbounds1.Top += p1direction;
            }
            if (outofbounds2.Top + p2direction >= 0 && outofbounds2.Top + outofbounds2.Height + p2direction <= ClientSize.Height)
            {
                outofbounds2.Top += p2direction;
            }
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player11.Bounds) || ball.Bounds.IntersectsWith(player22.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballx = -ballx;
            }
            if (ball.Top <= 0 || ball.Bottom >= ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Left <= 0 || ball.Right >= ClientSize.Width)
            {
                ball.Left = ClientSize.Width / 2 - ball.Width / 2;
                ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            }
            ball.Left += ballx;
            ball.Top += bally;
            if (ball.Bounds.IntersectsWith(goal.Bounds))
            {
                score1.Text = (int.Parse(score1.Text) + 5).ToString();
                ball.Left = ClientSize.Width / 2 - ball.Width / 2;
                ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            }
            if (ball.Bounds.IntersectsWith(goal2.Bounds))
            {
                score2.Text = (int.Parse(score2.Text) + 5).ToString();
                ball.Left = ClientSize.Width / 2 - ball.Width / 2;
                ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            }
            if (ball.Bounds.IntersectsWith(outofbounds11.Bounds))
            {   score1.Text = (int.Parse(score1.Text) + 1).ToString();
                ball.Left = ClientSize.Width / 2 - ball.Width / 2;
                ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            }
            if (ball.Bounds.IntersectsWith(outofbounds22.Bounds))
            {
                score2.Text = (int.Parse(score2.Text) + 1).ToString();
                ball.Left = ClientSize.Width / 2 - ball.Width / 2;
                ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            player1.Top = ClientSize.Height / 2 - player1.Height / 2;
            player2.Top = ClientSize.Height / 2 - player2.Height / 2;
            player11.Top = ClientSize.Height / 2 - player11.Height / 2;
            player22.Top = ClientSize.Height / 2 - player22.Height / 2;
            outofbounds1.Top = ClientSize.Height / 2 - outofbounds1.Height / 2;
            outofbounds2.Top = ClientSize.Height / 2 - outofbounds2.Height / 2;
            ball.Left = ClientSize.Width / 2 - ball.Width / 2;
            ball.Top = ClientSize.Height / 2 - ball.Height / 2;
            ballx = 15;
            bally = 15;
            score1.Text = "0";
            score2.Text = "0";
            p1direction = 0;
            p2direction = 0;
        }
    }
}
