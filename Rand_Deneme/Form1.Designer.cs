namespace MotoServisRandevuSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxSaatler = new System.Windows.Forms.ListBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.buttonRandevuEkle = new System.Windows.Forms.Button();
            this.buttonRandSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDetay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxSaatler
            // 
            this.listBoxSaatler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxSaatler.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxSaatler.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBoxSaatler.FormattingEnabled = true;
            this.listBoxSaatler.ItemHeight = 38;
            this.listBoxSaatler.Location = new System.Drawing.Point(13, 13);
            this.listBoxSaatler.Name = "listBoxSaatler";
            this.listBoxSaatler.Size = new System.Drawing.Size(452, 498);
            this.listBoxSaatler.TabIndex = 0;
            this.listBoxSaatler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSaatler_MouseDoubleClick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(477, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected_1);
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIsim.Location = new System.Drawing.Point(596, 284);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(248, 34);
            this.textBoxIsim.TabIndex = 2;
            // 
            // buttonRandevuEkle
            // 
            this.buttonRandevuEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonRandevuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRandevuEkle.Location = new System.Drawing.Point(614, 432);
            this.buttonRandevuEkle.Name = "buttonRandevuEkle";
            this.buttonRandevuEkle.Size = new System.Drawing.Size(213, 43);
            this.buttonRandevuEkle.TabIndex = 3;
            this.buttonRandevuEkle.Text = "RANDEVU VER";
            this.buttonRandevuEkle.UseVisualStyleBackColor = false;
            this.buttonRandevuEkle.Click += new System.EventHandler(this.buttonRandevuEkle_Click_1);
            // 
            // buttonRandSil
            // 
            this.buttonRandSil.BackColor = System.Drawing.Color.Red;
            this.buttonRandSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRandSil.Location = new System.Drawing.Point(614, 472);
            this.buttonRandSil.Name = "buttonRandSil";
            this.buttonRandSil.Size = new System.Drawing.Size(213, 39);
            this.buttonRandSil.TabIndex = 4;
            this.buttonRandSil.Text = "RANDEVUYU SİL";
            this.buttonRandSil.UseVisualStyleBackColor = false;
            this.buttonRandSil.Click += new System.EventHandler(this.buttonRandSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(518, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "İSİM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(485, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "DETAY:";
            // 
            // richTextBoxDetay
            // 
            this.richTextBoxDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxDetay.Location = new System.Drawing.Point(597, 326);
            this.richTextBoxDetay.Name = "richTextBoxDetay";
            this.richTextBoxDetay.Size = new System.Drawing.Size(247, 96);
            this.richTextBoxDetay.TabIndex = 8;
            this.richTextBoxDetay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rand_Deneme.Properties.Resources.avrp;
            this.ClientSize = new System.Drawing.Size(1201, 580);
            this.Controls.Add(this.richTextBoxDetay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandSil);
            this.Controls.Add(this.buttonRandevuEkle);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.listBoxSaatler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AVRUPA MOTOR RANDEVU SİSTEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSaatler;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.Button buttonRandevuEkle;
        private System.Windows.Forms.Button buttonRandSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDetay;
    }
}

