namespace password_app
{
    partial class frmmain
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
            this.btnsifrele = new System.Windows.Forms.Button();
            this.txtgirdi = new System.Windows.Forms.TextBox();
            this.txtcıktı = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnbilgi = new System.Windows.Forms.Button();
            this.btnulas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsifrele
            // 
            this.btnsifrele.Location = new System.Drawing.Point(352, 233);
            this.btnsifrele.Name = "btnsifrele";
            this.btnsifrele.Size = new System.Drawing.Size(75, 40);
            this.btnsifrele.TabIndex = 0;
            this.btnsifrele.Text = "Şifrele";
            this.btnsifrele.UseVisualStyleBackColor = true;
            this.btnsifrele.Click += new System.EventHandler(this.btnçevir_Click);
            // 
            // txtgirdi
            // 
            this.txtgirdi.Location = new System.Drawing.Point(23, 44);
            this.txtgirdi.Multiline = true;
            this.txtgirdi.Name = "txtgirdi";
            this.txtgirdi.Size = new System.Drawing.Size(317, 141);
            this.txtgirdi.TabIndex = 1;
            this.txtgirdi.Text = "Şifrelenilecek metni buraya yazın eğer metin şifrelenmek için değil çözülmek için" +
    " yazıldıysa dönüştür butonuna basın ";
            // 
            // txtcıktı
            // 
            this.txtcıktı.Location = new System.Drawing.Point(427, 44);
            this.txtcıktı.Multiline = true;
            this.txtcıktı.Name = "txtcıktı";
            this.txtcıktı.Size = new System.Drawing.Size(317, 141);
            this.txtcıktı.TabIndex = 1;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(23, 238);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(79, 35);
            this.btntemizle.TabIndex = 2;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnbilgi
            // 
            this.btnbilgi.Location = new System.Drawing.Point(108, 238);
            this.btnbilgi.Name = "btnbilgi";
            this.btnbilgi.Size = new System.Drawing.Size(79, 35);
            this.btnbilgi.TabIndex = 2;
            this.btnbilgi.Text = "Bilgi";
            this.btnbilgi.UseVisualStyleBackColor = true;
            this.btnbilgi.Click += new System.EventHandler(this.btnbilgi_Click);
            // 
            // btnulas
            // 
            this.btnulas.Location = new System.Drawing.Point(193, 238);
            this.btnulas.Name = "btnulas";
            this.btnulas.Size = new System.Drawing.Size(101, 35);
            this.btnulas.TabIndex = 2;
            this.btnulas.Text = "Bana Ulaşın";
            this.btnulas.UseVisualStyleBackColor = true;
            this.btnulas.Click += new System.EventHandler(this.btnulas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dönüştür";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnulas);
            this.Controls.Add(this.btnbilgi);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txtcıktı);
            this.Controls.Add(this.txtgirdi);
            this.Controls.Add(this.btnsifrele);
            this.Name = "frmmain";
            this.Text = "PaswordApp";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsifrele;
        private System.Windows.Forms.TextBox txtgirdi;
        private System.Windows.Forms.TextBox txtcıktı;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnbilgi;
        private System.Windows.Forms.Button btnulas;
        private System.Windows.Forms.Button button1;
    }
}

