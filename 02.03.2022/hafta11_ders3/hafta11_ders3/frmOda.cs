using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta11_ders3
{
    public partial class frmOda : Form
    {
        public frmOda()
        {
            InitializeComponent();
        }

        private void frmOda_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_Bilgi_HotelDataSet.tbl_Odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_OdalarTableAdapter.Fill(this.dB_Bilgi_HotelDataSet.tbl_Odalar);

        }
    }
}
