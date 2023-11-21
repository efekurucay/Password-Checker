namespace sifrekontrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_ctrl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeneme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_rakam = new System.Windows.Forms.Label();
            this.lbl_kucukharf = new System.Windows.Forms.Label();
            this.lbl_buyukharf = new System.Windows.Forms.Label();
            this.lbl_ozelkarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(47, 55);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(107, 24);
            this.txt_sifre.TabIndex = 0;
            // 
            // btn_ctrl
            // 
            this.btn_ctrl.Location = new System.Drawing.Point(47, 235);
            this.btn_ctrl.Name = "btn_ctrl";
            this.btn_ctrl.Size = new System.Drawing.Size(119, 29);
            this.btn_ctrl.TabIndex = 1;
            this.btn_ctrl.Text = "KONTROL";
            this.btn_ctrl.UseVisualStyleBackColor = true;
            this.btn_ctrl.Click += new System.EventHandler(this.btn_ctrl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre Uzunluğu : ";
            // 
            // btndeneme
            // 
            this.btndeneme.AutoSize = true;
            this.btndeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeneme.Location = new System.Drawing.Point(140, 96);
            this.btndeneme.Name = "btndeneme";
            this.btndeneme.Size = new System.Drawing.Size(14, 13);
            this.btndeneme.TabIndex = 4;
            this.btndeneme.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rakam : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Küçük Harf : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Büyük Harf : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Özel Karakter : ";
            // 
            // lbl_rakam
            // 
            this.lbl_rakam.AutoSize = true;
            this.lbl_rakam.Location = new System.Drawing.Point(111, 123);
            this.lbl_rakam.Name = "lbl_rakam";
            this.lbl_rakam.Size = new System.Drawing.Size(13, 13);
            this.lbl_rakam.TabIndex = 10;
            this.lbl_rakam.Text = "0";
            // 
            // lbl_kucukharf
            // 
            this.lbl_kucukharf.AutoSize = true;
            this.lbl_kucukharf.Location = new System.Drawing.Point(120, 150);
            this.lbl_kucukharf.Name = "lbl_kucukharf";
            this.lbl_kucukharf.Size = new System.Drawing.Size(13, 13);
            this.lbl_kucukharf.TabIndex = 11;
            this.lbl_kucukharf.Text = "0";
            // 
            // lbl_buyukharf
            // 
            this.lbl_buyukharf.AutoSize = true;
            this.lbl_buyukharf.Location = new System.Drawing.Point(120, 177);
            this.lbl_buyukharf.Name = "lbl_buyukharf";
            this.lbl_buyukharf.Size = new System.Drawing.Size(13, 13);
            this.lbl_buyukharf.TabIndex = 12;
            this.lbl_buyukharf.Text = "0";
            // 
            // lbl_ozelkarakter
            // 
            this.lbl_ozelkarakter.AutoSize = true;
            this.lbl_ozelkarakter.Location = new System.Drawing.Point(130, 203);
            this.lbl_ozelkarakter.Name = "lbl_ozelkarakter";
            this.lbl_ozelkarakter.Size = new System.Drawing.Size(13, 13);
            this.lbl_ozelkarakter.TabIndex = 13;
            this.lbl_ozelkarakter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 410);
            this.Controls.Add(this.lbl_ozelkarakter);
            this.Controls.Add(this.lbl_buyukharf);
            this.Controls.Add(this.lbl_kucukharf);
            this.Controls.Add(this.lbl_rakam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndeneme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ctrl);
            this.Controls.Add(this.txt_sifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_ctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btndeneme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_rakam;
        private System.Windows.Forms.Label lbl_kucukharf;
        private System.Windows.Forms.Label lbl_buyukharf;
        private System.Windows.Forms.Label lbl_ozelkarakter;
    }
}

