namespace WinFormsApp1
{
    partial class Siparis
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(206, 316);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 114);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 3;
            label1.Text = "Müşteri Adını Girin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 233);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Ürün Seçimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 324);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 5;
            label3.Text = "İçeçek Seçimi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 156);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefonu";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(458, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(458, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(307, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(166, 444);
            button1.Name = "button1";
            button1.Size = new Size(231, 33);
            button1.TabIndex = 10;
            button1.Text = "Siparişi Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 395);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "Tutar";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(206, 395);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(486, 444);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(486, 497);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(279, 23);
            textBox5.TabIndex = 14;
            // 
            // Siparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 604);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Siparis";
            Text = "Siparis";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}