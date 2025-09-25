namespace pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player1 = new PictureBox();
            player2 = new PictureBox();
            ball = new PictureBox();
            buttonp = new Button();
            buttons = new Button();
            player11 = new PictureBox();
            player22 = new PictureBox();
            outofbounds2 = new PictureBox();
            outofbounds1 = new PictureBox();
            goal = new PictureBox();
            goal2 = new PictureBox();
            score2 = new Label();
            score1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            reset = new Button();
            outofbounds11 = new PictureBox();
            outofbounds22 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goal2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds22).BeginInit();
            SuspendLayout();
            // 
            // player1
            // 
            player1.BackColor = SystemColors.ButtonHighlight;
            player1.Location = new Point(2, 105);
            player1.Name = "player1";
            player1.Size = new Size(19, 110);
            player1.TabIndex = 0;
            player1.TabStop = false;
            player1.Visible = false;
            // 
            // player2
            // 
            player2.BackColor = SystemColors.ButtonHighlight;
            player2.Location = new Point(893, 114);
            player2.Name = "player2";
            player2.Size = new Size(19, 110);
            player2.TabIndex = 1;
            player2.TabStop = false;
            player2.Visible = false;
            // 
            // ball
            // 
            ball.Image = (Image)resources.GetObject("ball.Image");
            ball.Location = new Point(422, 191);
            ball.Name = "ball";
            ball.Size = new Size(30, 33);
            ball.TabIndex = 2;
            ball.TabStop = false;
            ball.Visible = false;
            // 
            // buttonp
            // 
            buttonp.Location = new Point(98, 160);
            buttonp.Name = "buttonp";
            buttonp.Size = new Size(694, 29);
            buttonp.TabIndex = 3;
            buttonp.Text = "pong";
            buttonp.UseVisualStyleBackColor = true;
            buttonp.Click += buttonp_Click;
            // 
            // buttons
            // 
            buttons.Location = new Point(98, 91);
            buttons.Name = "buttons";
            buttons.Size = new Size(694, 29);
            buttons.TabIndex = 4;
            buttons.Text = "soccer";
            buttons.UseVisualStyleBackColor = true;
            buttons.Click += buttons_Click;
            // 
            // player11
            // 
            player11.BackColor = SystemColors.ButtonHighlight;
            player11.Location = new Point(179, 237);
            player11.Name = "player11";
            player11.Size = new Size(19, 50);
            player11.TabIndex = 5;
            player11.TabStop = false;
            player11.Visible = false;
            // 
            // player22
            // 
            player22.BackColor = SystemColors.ButtonHighlight;
            player22.Location = new Point(730, 237);
            player22.Name = "player22";
            player22.Size = new Size(19, 50);
            player22.TabIndex = 6;
            player22.TabStop = false;
            player22.Visible = false;
            // 
            // outofbounds2
            // 
            outofbounds2.BackColor = SystemColors.ButtonHighlight;
            outofbounds2.Image = Properties.Resources.Screenshot_2025_09_09_075414;
            outofbounds2.Location = new Point(-9, -5);
            outofbounds2.Name = "outofbounds2";
            outofbounds2.Size = new Size(30, 601);
            outofbounds2.TabIndex = 7;
            outofbounds2.TabStop = false;
            outofbounds2.Visible = false;
            outofbounds2.Click += pictureBox1_Click;
            // 
            // outofbounds1
            // 
            outofbounds1.BackColor = SystemColors.ButtonHighlight;
            outofbounds1.Image = (Image)resources.GetObject("outofbounds1.Image");
            outofbounds1.Location = new Point(893, -5);
            outofbounds1.Name = "outofbounds1";
            outofbounds1.Size = new Size(28, 601);
            outofbounds1.TabIndex = 8;
            outofbounds1.TabStop = false;
            outofbounds1.Visible = false;
            // 
            // goal
            // 
            goal.BackColor = SystemColors.ButtonHighlight;
            goal.Location = new Point(61, 217);
            goal.Name = "goal";
            goal.Size = new Size(28, 124);
            goal.TabIndex = 9;
            goal.TabStop = false;
            goal.Visible = false;
            // 
            // goal2
            // 
            goal2.BackColor = SystemColors.ButtonHighlight;
            goal2.Location = new Point(831, 217);
            goal2.Name = "goal2";
            goal2.Size = new Size(31, 124);
            goal2.TabIndex = 10;
            goal2.TabStop = false;
            goal2.Visible = false;
            // 
            // score2
            // 
            score2.AutoSize = true;
            score2.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            score2.ForeColor = SystemColors.ButtonHighlight;
            score2.Location = new Point(822, 9);
            score2.Name = "score2";
            score2.Size = new Size(45, 54);
            score2.TabIndex = 11;
            score2.Text = "0";
            score2.Visible = false;
            // 
            // score1
            // 
            score1.AutoSize = true;
            score1.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            score1.ForeColor = SystemColors.ButtonFace;
            score1.Location = new Point(48, 9);
            score1.Name = "score1";
            score1.Size = new Size(45, 54);
            score1.TabIndex = 12;
            score1.Text = "0";
            score1.Visible = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // reset
            // 
            reset.Location = new Point(409, -5);
            reset.Name = "reset";
            reset.Size = new Size(54, 37);
            reset.TabIndex = 13;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // outofbounds11
            // 
            outofbounds11.BackColor = SystemColors.ButtonHighlight;
            outofbounds11.Image = Properties.Resources.Screenshot_2025_09_09_075414;
            outofbounds11.Location = new Point(2, -5);
            outofbounds11.Name = "outofbounds11";
            outofbounds11.Size = new Size(10, 601);
            outofbounds11.TabIndex = 14;
            outofbounds11.TabStop = false;
            outofbounds11.Visible = false;
            // 
            // outofbounds22
            // 
            outofbounds22.BackColor = SystemColors.ButtonHighlight;
            outofbounds22.Image = (Image)resources.GetObject("outofbounds22.Image");
            outofbounds22.Location = new Point(902, -5);
            outofbounds22.Name = "outofbounds22";
            outofbounds22.Size = new Size(10, 601);
            outofbounds22.TabIndex = 15;
            outofbounds22.TabStop = false;
            outofbounds22.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(913, 595);
            Controls.Add(outofbounds22);
            Controls.Add(outofbounds11);
            Controls.Add(reset);
            Controls.Add(score1);
            Controls.Add(score2);
            Controls.Add(goal2);
            Controls.Add(goal);
            Controls.Add(outofbounds1);
            Controls.Add(outofbounds2);
            Controls.Add(player22);
            Controls.Add(player11);
            Controls.Add(buttons);
            Controls.Add(buttonp);
            Controls.Add(ball);
            Controls.Add(player2);
            Controls.Add(player1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)player11).EndInit();
            ((System.ComponentModel.ISupportInitialize)player22).EndInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds2).EndInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goal).EndInit();
            ((System.ComponentModel.ISupportInitialize)goal2).EndInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds11).EndInit();
            ((System.ComponentModel.ISupportInitialize)outofbounds22).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox player1;
        private PictureBox player2;
        private PictureBox ball;
        private Button buttonp;
        private Button buttons;
        private PictureBox player11;
        private PictureBox player22;
        private PictureBox outofbounds2;
        private PictureBox outofbounds1;
        private PictureBox goal;
        private PictureBox goal2;
        private Label score2;
        private Label score1;
        private System.Windows.Forms.Timer timer1;
        private Button reset;
        private PictureBox outofbounds11;
        private PictureBox outofbounds22;
    }
}
