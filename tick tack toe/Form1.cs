namespace tick_tack_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            {
                Application.Restart();
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X")
                b.Text = "O";
            else
                b.Text = "X";
            if (CheckWin())
            { 
                Application.Restart();
            }
        }
    private bool CheckWin()
        {
            // Rows
            if (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text) return true;
            if (b4.Text != "" && b4.Text == b5.Text && b5.Text == b6.Text) return true;
            if (b7.Text != "" && b7.Text == b8.Text && b8.Text == b9.Text) return true;

            // Columns
            if (b1.Text != "" && b1.Text == b4.Text && b4.Text == b7.Text) return true;
            if (b2.Text != "" && b2.Text == b5.Text && b5.Text == b8.Text) return true;
            if (b3.Text != "" && b3.Text == b6.Text && b6.Text == b9.Text) return true;

            // Diagonals
            if (b1.Text != "" && b1.Text == b5.Text && b5.Text == b9.Text) return true;
            if (b3.Text != "" && b3.Text == b5.Text && b5.Text == b7.Text) return true;

            return false;
        }
    }
}
