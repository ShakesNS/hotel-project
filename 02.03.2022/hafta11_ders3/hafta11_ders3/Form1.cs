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
    public partial class Form1 : Form
    {

        frmMusteri frmMusteri;
        frmMisafir frmMisafir;
        public Form1()
        {
            InitializeComponent();
        }

        public void FrmGetir(Form frm)
        {
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            #region Draft
            //panelAna.Controls.Add(frm);
            //panelAna.Size = frm.Size;
            #endregion
            frm.Show();
        }

        public void FrmSil(Form form)
        {
            #region Draft
            //panelAna.Controls.Remove(frm);

            //List<Form> openForms = new List<Form>();

            //foreach (Form f in Application.OpenForms)
            //    openForms.Add(f);

            //foreach (Form f in openForms)
            //{

            //}


            //foreach (Form form in this.Controls.OfType<Form>())
            //{
            //    //if (frm != null)
            //    //{
            //    //    
            //    //}
            //    //form.Close();


            //        form.Close();

            //}
            #endregion
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri = new frmMusteri("pnlGetir");
            FrmSil(frmMusteri);
            FrmGetir(frmMusteri);          
        }

        private void müşteriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri = new frmMusteri("pnlGoster");
            FrmSil(frmMusteri);
            FrmGetir(frmMusteri);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Draft
            //panelAna.AutoScroll = false;
            //panelAna.HorizontalScroll.Enabled = true;
            //panelAna.HorizontalScroll.Visible = true;
            //panelAna.HorizontalScroll.Maximum = 0;
            //panelAna.VerticalScroll.Enabled = true;
            //panelAna.VerticalScroll.Visible = true;
            //panelAna.VerticalScroll.Maximum = 0;
            //panelAna.AutoScroll = true;

            //panelAna.Height=this.Height;
            //panelAna.Width=this.Width;
            #endregion
        }

        private void geriGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void misafirEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMisafir = new frmMisafir("pnlGetir");
            FrmSil(frmMisafir);
            FrmGetir(frmMisafir);          
        }

        private void misafirSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMisafir = new frmMisafir("pnlGoster");
            FrmSil(frmMisafir);
            FrmGetir(frmMisafir);          
        }
    }
}
