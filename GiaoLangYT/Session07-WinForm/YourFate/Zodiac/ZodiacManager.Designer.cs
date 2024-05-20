namespace Zodiac
{
    partial class ZodiacManager
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
            btnShowImage1 = new Button();
            lblWelcome = new Label();
            picImage = new PictureBox();
            pnImage = new Panel();
            btnCheckZodiac = new Button();
            btnExit = new Button();
            lblBirthDay = new Label();
            lblBirthMonth = new Label();
            lblZodiacSign = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnImage.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowImage1
            // 
            btnShowImage1.BackColor = Color.Red;
            btnShowImage1.ForeColor = Color.Yellow;
            btnShowImage1.Location = new Point(39, 267);
            btnShowImage1.Name = "btnShowImage1";
            btnShowImage1.Size = new Size(95, 39);
            btnShowImage1.TabIndex = 2;
            btnShowImage1.Text = "Show Image";
            btnShowImage1.UseVisualStyleBackColor = false;
            btnShowImage1.Click += btnShowImage1_ClicK;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Yellow;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(580, 86);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Zodiac Calculator!";
            lblWelcome.Click += label1_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.Lime;
            picImage.Location = new Point(17, 9);
            picImage.Name = "picImage";
            picImage.Size = new Size(439, 495);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 2;
            picImage.TabStop = false;
            // 
            // pnImage
            // 
            pnImage.AutoScroll = true;
            pnImage.BackColor = Color.FromArgb(192, 0, 192);
            pnImage.Controls.Add(picImage);
            pnImage.Location = new Point(647, 100);
            pnImage.Name = "pnImage";
            pnImage.Size = new Size(471, 519);
            pnImage.TabIndex = 3;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.BackColor = Color.Red;
            btnCheckZodiac.ForeColor = Color.Yellow;
            btnCheckZodiac.Location = new Point(140, 267);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(95, 39);
            btnCheckZodiac.TabIndex = 3;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = false;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(253, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(95, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblBirthDay
            // 
            lblBirthDay.AutoSize = true;
            lblBirthDay.BackColor = Color.Red;
            lblBirthDay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthDay.ForeColor = Color.Yellow;
            lblBirthDay.Location = new Point(23, 118);
            lblBirthDay.Name = "lblBirthDay";
            lblBirthDay.Size = new Size(178, 32);
            lblBirthDay.TabIndex = 6;
            lblBirthDay.Text = "Your birth day";
            // 
            // lblBirthMonth
            // 
            lblBirthMonth.AutoSize = true;
            lblBirthMonth.BackColor = Color.Red;
            lblBirthMonth.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBirthMonth.ForeColor = Color.Yellow;
            lblBirthMonth.Location = new Point(23, 189);
            lblBirthMonth.Name = "lblBirthMonth";
            lblBirthMonth.Size = new Size(212, 32);
            lblBirthMonth.TabIndex = 7;
            lblBirthMonth.Text = "Your birth month";
            lblBirthMonth.Click += label2_Click;
            // 
            // lblZodiacSign
            // 
            lblZodiacSign.AutoSize = true;
            lblZodiacSign.BackColor = Color.Red;
            lblZodiacSign.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblZodiacSign.ForeColor = Color.Yellow;
            lblZodiacSign.Location = new Point(23, 360);
            lblZodiacSign.Name = "lblZodiacSign";
            lblZodiacSign.Size = new Size(245, 32);
            lblZodiacSign.TabIndex = 8;
            lblZodiacSign.Text = "Your Zodiac sign is: ";
            lblZodiacSign.Click += label3_Click;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDay.Location = new Point(220, 115);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(143, 39);
            txtDay.TabIndex = 0;
            txtDay.Text = "1";
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonth.Location = new Point(267, 182);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(143, 39);
            txtMonth.TabIndex = 1;
            txtMonth.Text = "1";
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1130, 649);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblZodiacSign);
            Controls.Add(lblBirthMonth);
            Controls.Add(lblBirthDay);
            Controls.Add(btnExit);
            Controls.Add(btnCheckZodiac);
            Controls.Add(pnImage);
            Controls.Add(lblWelcome);
            Controls.Add(btnShowImage1);
            MaximizeBox = false;
            Name = "ZodiacManager";
            Text = "Form1";
            Load += ZodiacManager_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowImage1;
        private Label lblWelcome;
        private PictureBox picImage;
        private Panel pnImage;
        private Button btnCheckZodiac;
        private Button btnExit;
        private Label lblBirthDay;
        private Label lblBirthMonth;
        private Label lblZodiacSign;
        private TextBox txtDay;
        private TextBox txtMonth;
    }
}
