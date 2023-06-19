namespace hafta11_ders3
{
    partial class frmOda
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
            this.dB_Bilgi_HotelDataSet = new hafta11_ders3.DB_Bilgi_HotelDataSet();
            this.tblOdalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OdalarTableAdapter = new hafta11_ders3.DB_Bilgi_HotelDataSetTableAdapters.tbl_OdalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Bilgi_HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_Bilgi_HotelDataSet
            // 
            this.dB_Bilgi_HotelDataSet.DataSetName = "DB_Bilgi_HotelDataSet";
            this.dB_Bilgi_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOdalarBindingSource
            // 
            this.tblOdalarBindingSource.DataMember = "tbl_Odalar";
            this.tblOdalarBindingSource.DataSource = this.dB_Bilgi_HotelDataSet;
            // 
            // tbl_OdalarTableAdapter
            // 
            this.tbl_OdalarTableAdapter.ClearBeforeFill = true;
            // 
            // frmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 453);
            this.Name = "frmOda";
            this.Text = "frmOda";
            this.Load += new System.EventHandler(this.frmOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Bilgi_HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB_Bilgi_HotelDataSet dB_Bilgi_HotelDataSet;
        private System.Windows.Forms.BindingSource tblOdalarBindingSource;
        private DB_Bilgi_HotelDataSetTableAdapters.tbl_OdalarTableAdapter tbl_OdalarTableAdapter;
    }
}