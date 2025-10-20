namespace area_calc
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
            labelperimiter = new Label();
            textBoxpermiter = new TextBox();
            textBox2 = new TextBox();
            arealabel = new Label();
            buttonback = new Button();
            buttonnext = new Button();
            pictureBox1 = new PictureBox();
            buttoncalc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelperimiter
            // 
            labelperimiter.AutoSize = true;
            labelperimiter.Location = new Point(374, 99);
            labelperimiter.Name = "labelperimiter";
            labelperimiter.Size = new Size(66, 20);
            labelperimiter.TabIndex = 0;
            labelperimiter.Text = "permiter";
            // 
            // textBoxpermiter
            // 
            textBoxpermiter.Location = new Point(347, 122);
            textBoxpermiter.Name = "textBoxpermiter";
            textBoxpermiter.Size = new Size(125, 27);
            textBoxpermiter.TabIndex = 1;
            textBoxpermiter.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 54);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // arealabel
            // 
            arealabel.AutoSize = true;
            arealabel.Location = new Point(387, 20);
            arealabel.Name = "arealabel";
            arealabel.Size = new Size(40, 20);
            arealabel.TabIndex = 2;
            arealabel.Text = "Area";
            // 
            // buttonback
            // 
            buttonback.Location = new Point(12, 312);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(94, 29);
            buttonback.TabIndex = 4;
            buttonback.Text = "back";
            buttonback.UseVisualStyleBackColor = true;
            // 
            // buttonnext
            // 
            buttonnext.Location = new Point(526, 312);
            buttonnext.Name = "buttonnext";
            buttonnext.Size = new Size(94, 29);
            buttonnext.TabIndex = 5;
            buttonnext.Text = "Next";
            buttonnext.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(91, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 227);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttoncalc
            // 
            buttoncalc.Location = new Point(356, 177);
            buttoncalc.Name = "buttoncalc";
            buttoncalc.Size = new Size(84, 62);
            buttoncalc.TabIndex = 7;
            buttoncalc.Text = "calculate";
            buttoncalc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 353);
            Controls.Add(buttoncalc);
            Controls.Add(pictureBox1);
            Controls.Add(buttonnext);
            Controls.Add(buttonback);
            Controls.Add(textBox2);
            Controls.Add(arealabel);
            Controls.Add(textBoxpermiter);
            Controls.Add(labelperimiter);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelperimiter;
        private TextBox textBoxpermiter;
        private TextBox textBox2;
        private Label arealabel;
        private Button buttonback;
        private Button buttonnext;
        private PictureBox pictureBox1;
        private Button buttoncalc;
    }
}
