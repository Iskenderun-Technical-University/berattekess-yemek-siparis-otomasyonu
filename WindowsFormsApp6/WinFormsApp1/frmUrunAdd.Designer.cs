namespace WinFormsApp1
{
    partial class frmUrunAdd
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(182, 345);
            button1.Name = "button1";
            button1.Size = new Size(168, 33);
            button1.TabIndex = 3;
            button1.Text = "Ürünü Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-3, 58);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 4;
            label1.Text = "Ürün Tipini Seçiniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-3, 111);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 5;
            label2.Text = "Ürün Adını Giriniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(-3, 164);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 6;
            label3.Text = "Ürün Fiyatını Giriniz :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(163, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(29, 262);
            button2.Name = "button2";
            button2.Size = new Size(113, 30);
            button2.TabIndex = 8;
            button2.Text = "Resim Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmUrunAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(462, 391);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmUrunAdd";
            Text = "Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
    }
}