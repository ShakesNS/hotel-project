namespace hafta11_ders3
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
            this.menuHotel = new System.Windows.Forms.MenuStrip();
            this.geriGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misafirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misafirEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misafirSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaSatışıYapmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampanyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampanyaEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampanyaSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHotel
            // 
            this.menuHotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriGitToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.misafirToolStripMenuItem,
            this.odaToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.kampanyaToolStripMenuItem});
            this.menuHotel.Location = new System.Drawing.Point(0, 0);
            this.menuHotel.Name = "menuHotel";
            this.menuHotel.Size = new System.Drawing.Size(1124, 24);
            this.menuHotel.TabIndex = 1;
            this.menuHotel.Text = "menuStrip1";
            // 
            // geriGitToolStripMenuItem
            // 
            this.geriGitToolStripMenuItem.Name = "geriGitToolStripMenuItem";
            this.geriGitToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.geriGitToolStripMenuItem.Text = "Ana Sayfa";
            this.geriGitToolStripMenuItem.Click += new System.EventHandler(this.geriGitToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEklemeToolStripMenuItem,
            this.müşteriSorgulamaToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriEklemeToolStripMenuItem
            // 
            this.müşteriEklemeToolStripMenuItem.Name = "müşteriEklemeToolStripMenuItem";
            this.müşteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.müşteriEklemeToolStripMenuItem.Text = "Müşteri Ekleme";
            this.müşteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // müşteriSorgulamaToolStripMenuItem
            // 
            this.müşteriSorgulamaToolStripMenuItem.Name = "müşteriSorgulamaToolStripMenuItem";
            this.müşteriSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.müşteriSorgulamaToolStripMenuItem.Text = "Müşteri Sorgulama";
            this.müşteriSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.müşteriSorgulamaToolStripMenuItem_Click);
            // 
            // misafirToolStripMenuItem
            // 
            this.misafirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misafirEklemeToolStripMenuItem,
            this.misafirSorgulamaToolStripMenuItem});
            this.misafirToolStripMenuItem.Name = "misafirToolStripMenuItem";
            this.misafirToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.misafirToolStripMenuItem.Text = "Misafir";
            // 
            // misafirEklemeToolStripMenuItem
            // 
            this.misafirEklemeToolStripMenuItem.Name = "misafirEklemeToolStripMenuItem";
            this.misafirEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misafirEklemeToolStripMenuItem.Text = "Misafir Ekleme";
            this.misafirEklemeToolStripMenuItem.Click += new System.EventHandler(this.misafirEklemeToolStripMenuItem_Click);
            // 
            // misafirSorgulamaToolStripMenuItem
            // 
            this.misafirSorgulamaToolStripMenuItem.Name = "misafirSorgulamaToolStripMenuItem";
            this.misafirSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misafirSorgulamaToolStripMenuItem.Text = "Misafir Sorgulama";
            this.misafirSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.misafirSorgulamaToolStripMenuItem_Click);
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaSatışıYapmaToolStripMenuItem,
            this.odaSorgulamaToolStripMenuItem});
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.odaToolStripMenuItem.Text = "Oda";
            // 
            // odaSatışıYapmaToolStripMenuItem
            // 
            this.odaSatışıYapmaToolStripMenuItem.Name = "odaSatışıYapmaToolStripMenuItem";
            this.odaSatışıYapmaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.odaSatışıYapmaToolStripMenuItem.Text = "Oda Satışı Yapma";
            // 
            // odaSorgulamaToolStripMenuItem
            // 
            this.odaSorgulamaToolStripMenuItem.Name = "odaSorgulamaToolStripMenuItem";
            this.odaSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.odaSorgulamaToolStripMenuItem.Text = "Oda Sorgulama";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEklemeToolStripMenuItem,
            this.personelSorgulamaToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEklemeToolStripMenuItem
            // 
            this.personelEklemeToolStripMenuItem.Name = "personelEklemeToolStripMenuItem";
            this.personelEklemeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.personelEklemeToolStripMenuItem.Text = "Personel Ekleme";
            // 
            // personelSorgulamaToolStripMenuItem
            // 
            this.personelSorgulamaToolStripMenuItem.Name = "personelSorgulamaToolStripMenuItem";
            this.personelSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.personelSorgulamaToolStripMenuItem.Text = "Personel Sorgulama";
            // 
            // kampanyaToolStripMenuItem
            // 
            this.kampanyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kampanyaEklemeToolStripMenuItem,
            this.kampanyaSorgulamaToolStripMenuItem});
            this.kampanyaToolStripMenuItem.Name = "kampanyaToolStripMenuItem";
            this.kampanyaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.kampanyaToolStripMenuItem.Text = "Kampanya";
            // 
            // kampanyaEklemeToolStripMenuItem
            // 
            this.kampanyaEklemeToolStripMenuItem.Name = "kampanyaEklemeToolStripMenuItem";
            this.kampanyaEklemeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kampanyaEklemeToolStripMenuItem.Text = "Kampanya Ekleme";
            // 
            // kampanyaSorgulamaToolStripMenuItem
            // 
            this.kampanyaSorgulamaToolStripMenuItem.Name = "kampanyaSorgulamaToolStripMenuItem";
            this.kampanyaSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kampanyaSorgulamaToolStripMenuItem.Text = "Kampanya Sorgulama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 562);
            this.Controls.Add(this.menuHotel);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHotel;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuHotel.ResumeLayout(false);
            this.menuHotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuHotel;
        private System.Windows.Forms.ToolStripMenuItem geriGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misafirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misafirEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misafirSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaSatışıYapmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampanyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampanyaEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampanyaSorgulamaToolStripMenuItem;
    }
}

