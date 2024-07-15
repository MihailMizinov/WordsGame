namespace WordsGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 16.2F);
            button1.Location = new Point(665, 397);
            button1.Name = "button1";
            button1.Size = new Size(223, 57);
            button1.TabIndex = 0;
            button1.Text = "create accaunt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Palatino Linotype", 12F);
            textBox2.Location = new Point(658, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 12F);
            textBox1.Location = new Point(653, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 34);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 12F);
            textBox3.Location = new Point(653, 302);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 34);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(668, 364);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Palatino Linotype", 16.2F);
            button2.ForeColor = SystemColors.MenuText;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(107, 49);
            button2.TabIndex = 8;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.slide1reg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 538);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private Button button2;
    }
}