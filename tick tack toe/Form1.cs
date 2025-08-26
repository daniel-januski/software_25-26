namespace tick_tack_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "X") ;
            (b.Text == "O") ;
            else
                b.Text = "X";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
