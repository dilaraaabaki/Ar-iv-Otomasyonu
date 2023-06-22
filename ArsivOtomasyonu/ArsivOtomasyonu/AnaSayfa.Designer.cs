namespace ArsivOtomasyonu
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 184);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 240);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(370, 292);
            button1.Name = "button1";
            button1.Size = new Size(105, 33);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(212, 45);
            label3.Name = "label3";
            label3.Size = new Size(407, 70);
            label3.TabIndex = 5;
            label3.Text = "         ULUDAĞ ÜNİVERSİTESİ\r\nBELGE ARŞİV YÖNETİM SİSTEMİ ";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AnaSayfa";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
    }
}