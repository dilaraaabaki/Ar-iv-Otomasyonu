namespace ArsivOtomasyonu
{
    partial class Departman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departman));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            departmanAdiTxt = new TextBox();
            departmanIDTxt = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(195, 87);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Departman Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(69, 146);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Departman Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(69, 207);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Departman ID";
            // 
            // departmanAdiTxt
            // 
            departmanAdiTxt.Location = new Point(195, 143);
            departmanAdiTxt.Name = "departmanAdiTxt";
            departmanAdiTxt.Size = new Size(125, 27);
            departmanAdiTxt.TabIndex = 3;
            departmanAdiTxt.TextChanged += departmanAdiTxt_TextChanged;
            // 
            // departmanIDTxt
            // 
            departmanIDTxt.Location = new Point(195, 204);
            departmanIDTxt.Name = "departmanIDTxt";
            departmanIDTxt.Size = new Size(125, 27);
            departmanIDTxt.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(207, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(423, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 284);
            listBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(440, 354);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(574, 354);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Departman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(departmanIDTxt);
            Controls.Add(departmanAdiTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Departman";
            Text = "DepartmanEklefrm";
            Load += DepartmanEklefrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox departmanAdiTxt;
        private TextBox departmanIDTxt;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
    }
}