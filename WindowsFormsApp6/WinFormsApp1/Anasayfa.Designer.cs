namespace WinFormsApp1
{
    partial class Anasayfa
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(121, 96);
            button1.Name = "button1";
            button1.Size = new Size(184, 48);
            button1.TabIndex = 0;
            button1.Text = "Ürün Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(121, 150);
            button2.Name = "button2";
            button2.Size = new Size(184, 48);
            button2.TabIndex = 1;
            button2.Text = "İçeçek Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(80, 43);
            label1.Name = "label1";
            label1.Size = new Size(297, 21);
            label1.TabIndex = 2;
            label1.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(121, 204);
            button3.Name = "button3";
            button3.Size = new Size(184, 48);
            button3.TabIndex = 3;
            button3.Text = "Sipariş Oluştur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(121, 258);
            button4.Name = "button4";
            button4.Size = new Size(184, 48);
            button4.TabIndex = 4;
            button4.Text = "Siparişleri Görüntüle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(445, 378);
            button5.Name = "button5";
            button5.Size = new Size(8, 8);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(-3, 330);
            button6.Name = "button6";
            button6.Size = new Size(75, 33);
            button6.TabIndex = 6;
            button6.Text = "Çıkış";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(443, 362);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Anasayfa";
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}