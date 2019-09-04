namespace PersonelTakipSistemi
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_gorevler = new System.Windows.Forms.Button();
            this.btn_projeler = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_proje = new System.Windows.Forms.Panel();
            this.dataGridViewProje = new System.Windows.Forms.DataGridView();
            this.panel_profil = new System.Windows.Forms.Panel();
            this.btn_sifredegis = new System.Windows.Forms.Button();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.label_bolum = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_tc = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_gorev = new System.Windows.Forms.Panel();
            this.dataGridViewGorev = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_pGrup = new System.Windows.Forms.Button();
            this.hosgeldin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_proje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProje)).BeginInit();
            this.panel_profil.SuspendLayout();
            this.panel_gorev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorev)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.hosgeldin);
            this.panel1.Controls.Add(this.btn_pGrup);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_gorevler);
            this.panel1.Controls.Add(this.btn_projeler);
            this.panel1.Controls.Add(this.btn_profil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 518);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_gorevler
            // 
            this.btn_gorevler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_gorevler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gorevler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gorevler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevler.ForeColor = System.Drawing.Color.White;
            this.btn_gorevler.Location = new System.Drawing.Point(8, 297);
            this.btn_gorevler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gorevler.Name = "btn_gorevler";
            this.btn_gorevler.Size = new System.Drawing.Size(253, 39);
            this.btn_gorevler.TabIndex = 4;
            this.btn_gorevler.Text = "Görevlerim";
            this.btn_gorevler.UseVisualStyleBackColor = true;
            this.btn_gorevler.Click += new System.EventHandler(this.btn_gorevler_Click);
            // 
            // btn_projeler
            // 
            this.btn_projeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_projeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_projeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_projeler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_projeler.ForeColor = System.Drawing.Color.White;
            this.btn_projeler.Location = new System.Drawing.Point(8, 344);
            this.btn_projeler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_projeler.Name = "btn_projeler";
            this.btn_projeler.Size = new System.Drawing.Size(253, 39);
            this.btn_projeler.TabIndex = 2;
            this.btn_projeler.Text = "Projelerim";
            this.btn_projeler.UseVisualStyleBackColor = true;
            this.btn_projeler.Click += new System.EventHandler(this.btn_projeler_Click);
            // 
            // btn_profil
            // 
            this.btn_profil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profil.ForeColor = System.Drawing.Color.White;
            this.btn_profil.Location = new System.Drawing.Point(8, 250);
            this.btn_profil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(253, 39);
            this.btn_profil.TabIndex = 1;
            this.btn_profil.Text = "Profil";
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 36);
            this.panel2.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(927, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 23);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Takip Sistemi";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.panel_proje);
            this.panel3.Controls.Add(this.panel_profil);
            this.panel3.Controls.Add(this.panel_gorev);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 554);
            this.panel3.TabIndex = 2;
            // 
            // panel_proje
            // 
            this.panel_proje.Controls.Add(this.dataGridViewProje);
            this.panel_proje.Location = new System.Drawing.Point(275, 68);
            this.panel_proje.Margin = new System.Windows.Forms.Padding(4);
            this.panel_proje.Name = "panel_proje";
            this.panel_proje.Size = new System.Drawing.Size(656, 361);
            this.panel_proje.TabIndex = 2;
            // 
            // dataGridViewProje
            // 
            this.dataGridViewProje.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewProje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProje.Location = new System.Drawing.Point(57, 52);
            this.dataGridViewProje.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProje.Name = "dataGridViewProje";
            this.dataGridViewProje.Size = new System.Drawing.Size(485, 185);
            this.dataGridViewProje.TabIndex = 0;
            // 
            // panel_profil
            // 
            this.panel_profil.BackColor = System.Drawing.SystemColors.Window;
            this.panel_profil.Controls.Add(this.btn_sifredegis);
            this.panel_profil.Controls.Add(this.txt_yenisifre);
            this.panel_profil.Controls.Add(this.label_bolum);
            this.panel_profil.Controls.Add(this.label_soyad);
            this.panel_profil.Controls.Add(this.label_ad);
            this.panel_profil.Controls.Add(this.label_tc);
            this.panel_profil.Controls.Add(this.textBox6);
            this.panel_profil.Controls.Add(this.textBox4);
            this.panel_profil.Controls.Add(this.textBox3);
            this.panel_profil.Controls.Add(this.textBox2);
            this.panel_profil.Controls.Add(this.textBox1);
            this.panel_profil.Location = new System.Drawing.Point(279, 57);
            this.panel_profil.Margin = new System.Windows.Forms.Padding(4);
            this.panel_profil.Name = "panel_profil";
            this.panel_profil.Size = new System.Drawing.Size(645, 283);
            this.panel_profil.TabIndex = 0;
            // 
            // btn_sifredegis
            // 
            this.btn_sifredegis.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_sifredegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifredegis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_sifredegis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btn_sifredegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifredegis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_sifredegis.Location = new System.Drawing.Point(208, 192);
            this.btn_sifredegis.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sifredegis.Name = "btn_sifredegis";
            this.btn_sifredegis.Size = new System.Drawing.Size(113, 28);
            this.btn_sifredegis.TabIndex = 12;
            this.btn_sifredegis.Text = "Sifre Degistir";
            this.btn_sifredegis.UseVisualStyleBackColor = false;
            this.btn_sifredegis.Click += new System.EventHandler(this.btn_sifredegis_Click);
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(117, 160);
            this.txt_yenisifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(132, 22);
            this.txt_yenisifre.TabIndex = 11;
            // 
            // label_bolum
            // 
            this.label_bolum.AutoSize = true;
            this.label_bolum.Location = new System.Drawing.Point(116, 138);
            this.label_bolum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bolum.Name = "label_bolum";
            this.label_bolum.Size = new System.Drawing.Size(20, 17);
            this.label_bolum.TabIndex = 9;
            this.label_bolum.Text = "...";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Location = new System.Drawing.Point(116, 102);
            this.label_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(20, 17);
            this.label_soyad.TabIndex = 8;
            this.label_soyad.Text = "...";
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(116, 64);
            this.label_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(20, 17);
            this.label_ad.TabIndex = 7;
            this.label_ad.Text = "...";
            // 
            // label_tc
            // 
            this.label_tc.AutoSize = true;
            this.label_tc.Location = new System.Drawing.Point(116, 28);
            this.label_tc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tc.Name = "label_tc";
            this.label_tc.Size = new System.Drawing.Size(20, 17);
            this.label_tc.TabIndex = 6;
            this.label_tc.Text = "...";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(4, 165);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 15);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Yeni Şifre :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(4, 138);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 15);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Bölüm :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(4, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 15);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Soyad :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(4, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Ad :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(4, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tc No :";
            // 
            // panel_gorev
            // 
            this.panel_gorev.Controls.Add(this.dataGridViewGorev);
            this.panel_gorev.Location = new System.Drawing.Point(279, 84);
            this.panel_gorev.Margin = new System.Windows.Forms.Padding(4);
            this.panel_gorev.Name = "panel_gorev";
            this.panel_gorev.Size = new System.Drawing.Size(629, 295);
            this.panel_gorev.TabIndex = 1;
            // 
            // dataGridViewGorev
            // 
            this.dataGridViewGorev.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewGorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGorev.Location = new System.Drawing.Point(53, 44);
            this.dataGridViewGorev.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGorev.Name = "dataGridViewGorev";
            this.dataGridViewGorev.Size = new System.Drawing.Size(517, 185);
            this.dataGridViewGorev.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_pGrup
            // 
            this.btn_pGrup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pGrup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pGrup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pGrup.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pGrup.ForeColor = System.Drawing.Color.White;
            this.btn_pGrup.Location = new System.Drawing.Point(8, 391);
            this.btn_pGrup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pGrup.Name = "btn_pGrup";
            this.btn_pGrup.Size = new System.Drawing.Size(253, 39);
            this.btn_pGrup.TabIndex = 6;
            this.btn_pGrup.Text = "Proje Grubum";
            this.btn_pGrup.UseVisualStyleBackColor = true;
            this.btn_pGrup.Click += new System.EventHandler(this.btn_pGrup_Click);
            // 
            // hosgeldin
            // 
            this.hosgeldin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hosgeldin.Location = new System.Drawing.Point(44, 186);
            this.hosgeldin.Name = "hosgeldin";
            this.hosgeldin.Size = new System.Drawing.Size(183, 40);
            this.hosgeldin.TabIndex = 7;
            this.hosgeldin.Text = "label2";
            this.hosgeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(960, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel_proje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProje)).EndInit();
            this.panel_profil.ResumeLayout(false);
            this.panel_profil.PerformLayout();
            this.panel_gorev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_projeler;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_gorevler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_gorev;
        private System.Windows.Forms.Panel panel_profil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_proje;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_bolum;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_tc;
        private System.Windows.Forms.DataGridView dataGridViewGorev;
        private System.Windows.Forms.DataGridView dataGridViewProje;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button btn_sifredegis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_pGrup;
        private System.Windows.Forms.Label hosgeldin;
    }
}