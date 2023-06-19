using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta11_ders3
{
    public partial class frmMisafir : Form
    {

        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=DB_Bilgi_Hotel;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        public frmMisafir()
        {
            InitializeComponent();
        }
        public frmMisafir(string sayfa)
        {
            InitializeComponent();
            if (sayfa == "pnlGetir")
            {

                panelMisafirEkle.Visible = true;
                panelMisafirSorgula.Visible = false;
                Goster();

            }
            else if (sayfa == "pnlGoster")
            {


                panelMisafirEkle.Visible = false;
                panelMisafirSorgula.Visible = true;

                Goster();

            }

        }


        public void Goster()
        {
            lwMisafirler.Items.Clear();

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Misafir";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["MisafirId"].ToString());
                item.SubItems.Add(dr["MisafirAd"].ToString());
                item.SubItems.Add(dr["MisafirSoyad"].ToString());
                item.SubItems.Add(dr["MisafirTcKimlik"].ToString());
                item.SubItems.Add(dr["MisafirDogumTarihi"].ToString());
                item.SubItems.Add(dr["MisafirUyrukId"].ToString());
                item.SubItems.Add(dr["MisafirEposta"].ToString());
                item.SubItems.Add(dr["MisafirTelefon"].ToString());
                item.SubItems.Add(dr["MisafirPasaportNo"].ToString());
                item.SubItems.Add(dr["CinsiyetId"].ToString());
                item.SubItems.Add(dr["MisafirAdres"].ToString());
                item.SubItems.Add(dr["IlID"].ToString());
                item.SubItems.Add(dr["IlceID"].ToString());
                item.SubItems.Add(dr["UlkeID"].ToString());
                item.SubItems.Add(dr["MisafirAciklama"].ToString());
                item.SubItems.Add(dr["MisafirHesKod"].ToString());
                item.SubItems.Add(dr["DilID"].ToString());


                lwMisafirler.Items.Add(item);
            }
            cnn.Close();
        }



        private void frmMisafir_Load(object sender, EventArgs e)
        {
            btnMisafirGuncelle.Visible = false;
            lwMisafirler.Columns.Add("MisafirId");
            lwMisafirler.Columns.Add("MisafirAd");
            lwMisafirler.Columns.Add("MisafirSoyad");
            lwMisafirler.Columns.Add("MisafirTcKimlik");
            lwMisafirler.Columns.Add("MisafirDogumTarihi");
            lwMisafirler.Columns.Add("MisafirUyrukId");
            lwMisafirler.Columns.Add("MisafirEposta");
            lwMisafirler.Columns.Add("MisafirTelefon");
            lwMisafirler.Columns.Add("MisafirPasaportNo");
            lwMisafirler.Columns.Add("CinsiyetId");
            lwMisafirler.Columns.Add("MisafirAdres");
            lwMisafirler.Columns.Add("IlID");
            lwMisafirler.Columns.Add("IlceID");
            lwMisafirler.Columns.Add("UlkeID");
            lwMisafirler.Columns.Add("MisafirAciklama");
            lwMisafirler.Columns.Add("MisafirHesKod");
            lwMisafirler.Columns.Add("DilID");

            Goster();

            //diller
            cbDil.Items.Add("Lütfen Bir Değer Seçiniz");
            cbDil.SelectedIndex = 0;
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Diller";
            SqlDataReader drDil = cmd.ExecuteReader();
            while (drDil.Read())
            {
                cbDil.Items.Add(drDil[1].ToString());
            }
            cnn.Close();


            ////ulkeler

            cbUlke.Items.Add("Lütfen Bir Değer Seçiniz");

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Ulke";
            SqlDataReader drUlke = cmd.ExecuteReader();
            while (drUlke.Read())
            {
                cbUlke.Items.Add(drUlke[1].ToString());
            }
            cnn.Close();

            // uyruk
            cbMisafirUyruk.Items.Add("Lütfen Bir Değer Seçiniz");

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Ulke";
            SqlDataReader drUyruk = cmd.ExecuteReader();
            while (drUyruk.Read())
            {
                cbMisafirUyruk.Items.Add(drUyruk[1].ToString());
            }
            cnn.Close();

            //cinsiyet
            cbCinsiyet.Items.Add("Lütfen Bir Değer Seçiniz");

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Cinsiyet";
            SqlDataReader drCinsiyet = cmd.ExecuteReader();
            while (drCinsiyet.Read())
            {
                cbCinsiyet.Items.Add(drCinsiyet[1].ToString());
            }
            cnn.Close();


            //şehirler
            cbSehir.Items.Add("Lütfen Bir Değer Seçiniz");
            cbIlce.Items.Add("Lütfen Bir Değer Seçiniz");

            cbCinsiyet.SelectedIndex = 0;
            cbMisafirUyruk.SelectedIndex = 0;
            cbUlke.SelectedIndex = 0;
            cbSehir.SelectedIndex = 0;
            cbIlce.SelectedIndex = 0;


        }

        private void cbUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbSehir.Items.Clear();
            cbSehir.Items.Add("Lütfen Bir Değer Seçiniz");
            //şehirler
            int secilenDeger = cbUlke.SelectedIndex;

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Il where UlkeId=@UlkeID ";
            cmd.Parameters.AddWithValue("@UlkeID", secilenDeger);
            SqlDataReader drSehir = cmd.ExecuteReader();
            while (drSehir.Read())
            {
                cbSehir.Items.Add(drSehir[1].ToString());
            }
            cnn.Close();

        }

        private void cbSehir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ilçeler
            cbIlce.Items.Clear();
            cbIlce.Items.Add("Lütfen Bir Değer Seçiniz");
            int secilenDeger = cbSehir.SelectedIndex;

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Ilce where IlId=@IlID";
            cmd.Parameters.AddWithValue("@IlID", secilenDeger);
            SqlDataReader drIlce = cmd.ExecuteReader();
            while (drIlce.Read())
            {
                cbIlce.Items.Add(drIlce[1].ToString());
            }
            cnn.Close();
        }

        private void btnMisafirEkle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            //cmd.CommandText = "INSERT INTO tbl_Musteriler (MusteriAd, MusteriSoyad, MusteriTCKimlik, MusteriPasaportNo, MusteriUnvan, MusteriYetkiliAdSoyad, MusteriVergiNo, MusteriVergiDairesi, MusteriTelefon, MusteriPosta,MusteriAdres, IlID, IlceID, UlkeID, MusteriAciklama, MusteriKurumsalOK, DilID) VALUES (@MusteriAd, @MusteriSoyad, @MusteriTCKimlik, @MusteriPasaportNo, @MusteriUnvan, @MusteriYetkiliAdSoyad, @MusteriVergiNo, @MusteriVergiDairesi, @MusteriTelefon,@MusteriPosta,              @MusteriAdres, @IlID, @IlceID, @UlkeID, @MusteriAciklama, @MusteriKurumsalOK, @DilID)";
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MisafirINSERT";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MisafirAd" ,  tbMisafirAd.Text);
            cmd.Parameters.AddWithValue("@MisafirSoyad",   tbMisafirSoyad.Text);
            cmd.Parameters.AddWithValue("@MisafirTcKimlik",   tbMisafirTcKimlik.Text);
            cmd.Parameters.AddWithValue("@MisafirDogumTarihi",  dtMisafirDT.Value);
            cmd.Parameters.AddWithValue("@MisafirUyrukId",  cbMisafirUyruk.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirEposta",   tbMisafirEposta.Text);
            cmd.Parameters.AddWithValue("@MisafirTelefon",   tbMisafirTelefon.Text);
            cmd.Parameters.AddWithValue("@MisafirPasaportNo",  tbMisafirPasaport.Text);
            cmd.Parameters.AddWithValue("@CinsiyetId",  cbCinsiyet.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirAdres",  tbMisafirAdres.Text);
            cmd.Parameters.AddWithValue("@IlId",  cbSehir.SelectedIndex);
            cmd.Parameters.AddWithValue("@IlceId",  cbIlce.SelectedIndex);
            cmd.Parameters.AddWithValue("@UlkeId",  cbUlke.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirAciklama", tbMisafirAciklama.Text);
            cmd.Parameters.AddWithValue("@MisafirHesKod", tbMisafirHesKod.Text);
            cmd.Parameters.AddWithValue("@dilId",  cbDil.SelectedIndex);


            cmd.ExecuteNonQuery();
            cnn.Close();
            Goster();
        }

        private void btnMisafirGuncelle_Click(object sender, EventArgs e)
        {
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MisafirUPDATE";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MisafirID", GuncellemeID);
            cmd.Parameters.AddWithValue("@MisafirAd", tbMisafirAd.Text);
            cmd.Parameters.AddWithValue("@MisafirSoyad", tbMisafirSoyad.Text);
            cmd.Parameters.AddWithValue("@MisafirTcKimlik", tbMisafirTcKimlik.Text);
            cmd.Parameters.AddWithValue("@MisafirDogumTarihi", dtMisafirDT.Value);
            cmd.Parameters.AddWithValue("@MisafirUyrukId", cbMisafirUyruk.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirEposta", tbMisafirEposta.Text);
            cmd.Parameters.AddWithValue("@MisafirTelefon", tbMisafirTelefon.Text);
            cmd.Parameters.AddWithValue("@MisafirPasaportNo", tbMisafirPasaport.Text);
            cmd.Parameters.AddWithValue("@CinsiyetId", cbCinsiyet.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirAdres", tbMisafirAdres.Text);
            cmd.Parameters.AddWithValue("@IlId", cbSehir.SelectedIndex);
            cmd.Parameters.AddWithValue("@IlceId", cbIlce.SelectedIndex);
            cmd.Parameters.AddWithValue("@UlkeId", cbUlke.SelectedIndex);
            cmd.Parameters.AddWithValue("@MisafirAciklama", tbMisafirAciklama.Text);
            cmd.Parameters.AddWithValue("@MisafirHesKod", tbMisafirHesKod.Text);
            cmd.Parameters.AddWithValue("@dilId", cbDil.SelectedIndex);

            cmd.ExecuteNonQuery();
            cnn.Close();
            Goster();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lwMisafirler.SelectedItems)
            {
                int seciliindex = Convert.ToInt32(eachItem.SubItems[0].Text);
                cnn.Open();

                cmd = cnn.CreateCommand();
                cmd.CommandText = "delete from tbl_Misafir where MisafirId=@MisafirID";


                cmd.Parameters.AddWithValue("@MisafirID", seciliindex);

                cmd.ExecuteNonQuery();
                cnn.Close();
                Goster();

                lwMisafirler.Items.Remove(eachItem);
            }
        }
        int GuncellemeID;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMisafirEkle.Visible = false;
            btnMisafirGuncelle.Visible = true;
            panelMisafirEkle.Visible = true;
            panelMisafirSorgula.Visible = false;
            foreach (ListViewItem eachItem in lwMisafirler.SelectedItems)
            {
                GuncellemeID = Convert.ToInt32(eachItem.SubItems[0].Text);
                tbMisafirAd.Text = eachItem.SubItems[1].Text;
                tbMisafirSoyad.Text = eachItem.SubItems[2].Text;
                tbMisafirTcKimlik.Text = eachItem.SubItems[3].Text;
                dtMisafirDT.Value = Convert.ToDateTime(eachItem.SubItems[4].Text);
                cbMisafirUyruk.SelectedIndex = Convert.ToInt32(eachItem.SubItems[5].Text);
                tbMisafirEposta.Text = eachItem.SubItems[6].Text;
                tbMisafirTelefon.Text = eachItem.SubItems[7].Text;
                tbMisafirPasaport.Text = eachItem.SubItems[8].Text;
                cbCinsiyet.SelectedIndex = Convert.ToInt32(eachItem.SubItems[9].Text);
                tbMisafirAdres.Text = eachItem.SubItems[10].Text;              
                cbUlke.SelectedIndex = Convert.ToInt32(eachItem.SubItems[13].Text);
                tbMisafirAciklama.Text = eachItem.SubItems[14].Text;
                tbMisafirHesKod.Text = eachItem.SubItems[15].Text;
                cbDil.SelectedIndex = Convert.ToInt32(eachItem.SubItems[16].Text);

                cbSehir.Items.Clear();
                cbSehir.Items.Add("Lütfen Bir Değer Seçiniz");
                //şehirler
                int secilenDeger = cbUlke.SelectedIndex;

                cnn.Open();
                cmd = cnn.CreateCommand();
                cmd.CommandText = "select * from tbl_Il where UlkeId=@UlkeID ";
                cmd.Parameters.AddWithValue("@UlkeID", secilenDeger);
                SqlDataReader drSehir = cmd.ExecuteReader();
                while (drSehir.Read())
                {
                    cbSehir.Items.Add(drSehir[1].ToString());
                }
                cnn.Close();


                cbSehir.SelectedIndex = int.Parse(eachItem.SubItems[11].Text);

                cbIlce.Items.Clear();
                cbIlce.Items.Add("Lütfen Bir Değer Seçiniz");
                int secilenDeger2 = cbSehir.SelectedIndex;

                cnn.Open();
                cmd = cnn.CreateCommand();
                cmd.CommandText = "select * from tbl_Ilce where IlId=@IlID";
                cmd.Parameters.AddWithValue("@IlID", secilenDeger2);
                SqlDataReader drIlce = cmd.ExecuteReader();
                while (drIlce.Read())
                {
                    cbIlce.Items.Add(drIlce[1].ToString());
                }
                cnn.Close();
                cbIlce.SelectedIndex = Convert.ToInt32(eachItem.SubItems[12].Text);








            }
        }
    }
}
