namespace WindowsFormsApp1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.BuutonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bir = new System.Windows.Forms.Button();
            this.iki = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.dort = new System.Windows.Forms.Button();
            this.bes = new System.Windows.Forms.Button();
            this.alti = new System.Windows.Forms.Button();
            this.yedi = new System.Windows.Forms.Button();
            this.sekiz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.sifir = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.BuutonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserInputText.Location = new System.Drawing.Point(24, 13);
            this.UserInputText.Multiline = true;
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(337, 57);
            this.UserInputText.TabIndex = 0;
            this.UserInputText.TextChanged += new System.EventHandler(this.UserInputText_TextChanged);
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Location = new System.Drawing.Point(24, 73);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(337, 23);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Hesaplamayi girip entere basın =";
            // 
            // BuutonsPanel
            // 
            this.BuutonsPanel.ColumnCount = 4;
            this.BuutonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BuutonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BuutonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BuutonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BuutonsPanel.Controls.Add(this.bir, 0, 1);
            this.BuutonsPanel.Controls.Add(this.iki, 1, 1);
            this.BuutonsPanel.Controls.Add(this.uc, 2, 1);
            this.BuutonsPanel.Controls.Add(this.dort, 0, 2);
            this.BuutonsPanel.Controls.Add(this.bes, 1, 2);
            this.BuutonsPanel.Controls.Add(this.alti, 2, 2);
            this.BuutonsPanel.Controls.Add(this.yedi, 0, 3);
            this.BuutonsPanel.Controls.Add(this.sekiz, 1, 3);
            this.BuutonsPanel.Controls.Add(this.button2, 2, 3);
            this.BuutonsPanel.Controls.Add(this.bolme, 3, 0);
            this.BuutonsPanel.Controls.Add(this.carp, 3, 1);
            this.BuutonsPanel.Controls.Add(this.toplama, 3, 2);
            this.BuutonsPanel.Controls.Add(this.cikar, 3, 3);
            this.BuutonsPanel.Controls.Add(this.sil, 2, 0);
            this.BuutonsPanel.Controls.Add(this.sifir, 1, 4);
            this.BuutonsPanel.Controls.Add(this.esittir, 3, 4);
            this.BuutonsPanel.Controls.Add(this.temizle, 1, 0);
            this.BuutonsPanel.Location = new System.Drawing.Point(24, 106);
            this.BuutonsPanel.Name = "BuutonsPanel";
            this.BuutonsPanel.RowCount = 5;
            this.BuutonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BuutonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BuutonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BuutonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BuutonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BuutonsPanel.Size = new System.Drawing.Size(337, 312);
            this.BuutonsPanel.TabIndex = 2;
            // 
            // bir
            // 
            this.bir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bir.Location = new System.Drawing.Point(3, 65);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(78, 56);
            this.bir.TabIndex = 1;
            this.bir.Text = "1";
            this.bir.UseVisualStyleBackColor = true;
            this.bir.Click += new System.EventHandler(this.bir_Click);
            // 
            // iki
            // 
            this.iki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iki.Location = new System.Drawing.Point(87, 65);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(78, 56);
            this.iki.TabIndex = 2;
            this.iki.Text = "2";
            this.iki.UseVisualStyleBackColor = true;
            this.iki.Click += new System.EventHandler(this.iki_Click);
            // 
            // uc
            // 
            this.uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uc.Location = new System.Drawing.Point(171, 65);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(78, 56);
            this.uc.TabIndex = 3;
            this.uc.Text = "3";
            this.uc.UseVisualStyleBackColor = true;
            this.uc.Click += new System.EventHandler(this.uc_Click);
            // 
            // dort
            // 
            this.dort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dort.Location = new System.Drawing.Point(3, 127);
            this.dort.Name = "dort";
            this.dort.Size = new System.Drawing.Size(78, 56);
            this.dort.TabIndex = 4;
            this.dort.Text = "4";
            this.dort.UseVisualStyleBackColor = true;
            this.dort.Click += new System.EventHandler(this.dort_Click);
            // 
            // bes
            // 
            this.bes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bes.Location = new System.Drawing.Point(87, 127);
            this.bes.Name = "bes";
            this.bes.Size = new System.Drawing.Size(78, 56);
            this.bes.TabIndex = 5;
            this.bes.Text = "5";
            this.bes.UseVisualStyleBackColor = true;
            this.bes.Click += new System.EventHandler(this.bes_Click);
            // 
            // alti
            // 
            this.alti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alti.Location = new System.Drawing.Point(171, 127);
            this.alti.Name = "alti";
            this.alti.Size = new System.Drawing.Size(78, 56);
            this.alti.TabIndex = 6;
            this.alti.Text = "6";
            this.alti.UseVisualStyleBackColor = true;
            this.alti.Click += new System.EventHandler(this.alti_Click);
            // 
            // yedi
            // 
            this.yedi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yedi.Location = new System.Drawing.Point(3, 189);
            this.yedi.Name = "yedi";
            this.yedi.Size = new System.Drawing.Size(78, 56);
            this.yedi.TabIndex = 7;
            this.yedi.Text = "7";
            this.yedi.UseVisualStyleBackColor = true;
            this.yedi.Click += new System.EventHandler(this.yedi_Click);
            // 
            // sekiz
            // 
            this.sekiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekiz.Location = new System.Drawing.Point(87, 189);
            this.sekiz.Name = "sekiz";
            this.sekiz.Size = new System.Drawing.Size(78, 56);
            this.sekiz.TabIndex = 8;
            this.sekiz.Text = "8";
            this.sekiz.UseVisualStyleBackColor = true;
            this.sekiz.Click += new System.EventHandler(this.sekiz_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(171, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bolme
            // 
            this.bolme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme.Location = new System.Drawing.Point(255, 3);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(79, 56);
            this.bolme.TabIndex = 10;
            this.bolme.Text = "BÖL";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // carp
            // 
            this.carp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carp.Location = new System.Drawing.Point(255, 65);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(79, 56);
            this.carp.TabIndex = 11;
            this.carp.Text = "ÇARP";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // toplama
            // 
            this.toplama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(255, 127);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(79, 56);
            this.toplama.TabIndex = 12;
            this.toplama.Text = "TOPLA";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // cikar
            // 
            this.cikar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikar.Location = new System.Drawing.Point(255, 189);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(79, 56);
            this.cikar.TabIndex = 13;
            this.cikar.Text = "ÇIKAR";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // sil
            // 
            this.sil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(171, 3);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(78, 56);
            this.sil.TabIndex = 14;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // sifir
            // 
            this.sifir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifir.Location = new System.Drawing.Point(87, 251);
            this.sifir.Name = "sifir";
            this.sifir.Size = new System.Drawing.Size(78, 58);
            this.sifir.TabIndex = 15;
            this.sifir.Text = "0";
            this.sifir.UseVisualStyleBackColor = true;
            this.sifir.Click += new System.EventHandler(this.sifir_Click);
            // 
            // esittir
            // 
            this.esittir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir.Location = new System.Drawing.Point(255, 251);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(79, 58);
            this.esittir.TabIndex = 16;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = true;
            this.esittir.Click += new System.EventHandler(this.esittir_Click);
            // 
            // temizle
            // 
            this.temizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.temizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Location = new System.Drawing.Point(87, 3);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(78, 56);
            this.temizle.TabIndex = 17;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.esittir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.temizle;
            this.ClientSize = new System.Drawing.Size(381, 429);
            this.Controls.Add(this.BuutonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(389, 425);
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BuutonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel BuutonsPanel;
        private System.Windows.Forms.Button bir;
        private System.Windows.Forms.Button iki;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.Button dort;
        private System.Windows.Forms.Button bes;
        private System.Windows.Forms.Button alti;
        private System.Windows.Forms.Button yedi;
        private System.Windows.Forms.Button sekiz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button sifir;
        private System.Windows.Forms.Button esittir;
        private System.Windows.Forms.Button temizle;
    }
}

