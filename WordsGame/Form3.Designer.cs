namespace WordsGame
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(43, 315);
            label1.Name = "label1";
            label1.Size = new Size(107, 214);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(237, 100);
            label2.Name = "label2";
            label2.Size = new Size(107, 214);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(476, 34);
            label3.Name = "label3";
            label3.Size = new Size(107, 214);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(702, 100);
            label4.Name = "label4";
            label4.Size = new Size(107, 214);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(888, 300);
            label5.Name = "label5";
            label5.Size = new Size(107, 214);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Image = Properties.Resources.exit_ico__1_;
            label6.Location = new Point(12, 23);
            label6.Name = "label6";
            label6.Size = new Size(62, 48);
            label6.TabIndex = 5;
            label6.Click += label6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SLIDE2LVL;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 538);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Levels";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}