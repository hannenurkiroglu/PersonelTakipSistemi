namespace PersonelTakipSistemi
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_pSicilNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(67, 287);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(4);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(300, 51);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(446, 418);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.Control;
            this.rectangleShape2.Location = new System.Drawing.Point(67, 192);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(300, 51);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangleShape1.Location = new System.Drawing.Point(67, 101);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(300, 51);
            // 
            // txt_parola
            // 
            this.txt_parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txt_parola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_parola.ForeColor = System.Drawing.Color.White;
            this.txt_parola.Location = new System.Drawing.Point(72, 209);
            this.txt_parola.Margin = new System.Windows.Forms.Padding(4);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(278, 18);
            this.txt_parola.TabIndex = 3;
            this.txt_parola.Text = "Parola";
            this.txt_parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_parola.Click += new System.EventHandler(this.txt_parola_Click);
            this.txt_parola.TextChanged += new System.EventHandler(this.txt_parola_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(447, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 4;
            // 
            // txt_pSicilNo
            // 
            this.txt_pSicilNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txt_pSicilNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pSicilNo.ForeColor = System.Drawing.Color.White;
            this.txt_pSicilNo.Location = new System.Drawing.Point(72, 116);
            this.txt_pSicilNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pSicilNo.Name = "txt_pSicilNo";
            this.txt_pSicilNo.Size = new System.Drawing.Size(278, 18);
            this.txt_pSicilNo.TabIndex = 5;
            this.txt_pSicilNo.Text = "TC Kimlik Numarası";
            this.txt_pSicilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pSicilNo.Click += new System.EventHandler(this.txt_pSicilNo_Click);
            this.txt_pSicilNo.TextChanged += new System.EventHandler(this.txt_pSicilNo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(446, 418);
            this.Controls.Add(this.txt_pSicilNo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Verdana", 10.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_pSicilNo;
    }
}

