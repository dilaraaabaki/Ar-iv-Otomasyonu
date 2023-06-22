namespace ArsivOtomasyonu
{
    partial class Evrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evrak));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            evrakAdiTxt = new TextBox();
            evrakTuruTxt = new TextBox();
            evrakYiliTxt = new TextBox();
            label4 = new Label();
            evrakIDTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 166);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Evrak Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(122, 209);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Evrak Türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(122, 252);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Evrak Yılı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(314, 23);
            label5.Name = "label5";
            label5.Size = new Size(193, 23);
            label5.TabIndex = 4;
            label5.Text = "EVRAK İŞLEMLERİ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(482, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 284);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(193, 308);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(498, 374);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(623, 374);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Sil ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // evrakAdiTxt
            // 
            evrakAdiTxt.Location = new Point(237, 159);
            evrakAdiTxt.Name = "evrakAdiTxt";
            evrakAdiTxt.Size = new Size(125, 27);
            evrakAdiTxt.TabIndex = 13;
            // 
            // evrakTuruTxt
            // 
            evrakTuruTxt.Location = new Point(237, 209);
            evrakTuruTxt.Name = "evrakTuruTxt";
            evrakTuruTxt.Size = new Size(125, 27);
            evrakTuruTxt.TabIndex = 14;
            // 
            // evrakYiliTxt
            // 
            evrakYiliTxt.Location = new Point(237, 249);
            evrakYiliTxt.Name = "evrakYiliTxt";
            evrakYiliTxt.Size = new Size(125, 27);
            evrakYiliTxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(122, 121);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 16;
            label4.Text = "Evrak ID";
            // 
            // evrakIDTxt
            // 
            evrakIDTxt.Location = new Point(237, 121);
            evrakIDTxt.Name = "evrakIDTxt";
            evrakIDTxt.Size = new Size(125, 27);
            evrakIDTxt.TabIndex = 17;
            // 
            // Evrak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(evrakIDTxt);
            Controls.Add(label4);
            Controls.Add(evrakYiliTxt);
            Controls.Add(evrakTuruTxt);
            Controls.Add(evrakAdiTxt);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Evrak";
            Text = "Evrak";
            Load += Evrak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox evrakAdiTxt;
        private TextBox evrakTuruTxt;
        private TextBox evrakYiliTxt;
        private Label label4;
        private TextBox evrakIDTxt;
    }
}