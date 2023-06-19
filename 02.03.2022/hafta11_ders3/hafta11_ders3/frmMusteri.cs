using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hafta11_ders3
{
    public partial class frmMusteri : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=DB_Bilgi_Hotel;Integrated Security=True"); 
        SqlDataReader dr;
        SqlCommand cmd;
        
        public frmMusteri()
        {
            InitializeComponent();
        }

        public frmMusteri(string sayfa)
        {
            InitializeComponent();
            if (sayfa == "pnlGetir")
            {

                panelMusteriEkle.Visible = true;
                panelMusteriSorgula.Visible = false;
                Goster();

            }
            else if (sayfa == "pnlGoster")
            {


                panelMusteriEkle.Visible = false;
                panelMusteriSorgula.Visible = true;

                Goster();

            }

        }

        public void Goster()
        {
            lwMusteriler.Items.Clear();

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Musteriler";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["MusteriID"].ToString());
                item.SubItems.Add(dr["MusteriAd"].ToString());
                item.SubItems.Add(dr["MusteriSoyad"].ToString());  
                item.SubItems.Add(dr["MusteriTCKimlik"].ToString());
                item.SubItems.Add(dr["MusteriPasaportNo"].ToString());
                item.SubItems.Add(dr["MusteriUnvan"].ToString());
                item.SubItems.Add(dr["MusteriYetkiliAdSoyad"].ToString());
                item.SubItems.Add(dr["MusteriVergiNo"].ToString());
                item.SubItems.Add(dr["MusteriVergiDairesi"].ToString());
                item.SubItems.Add(dr["MusteriTelefon"].ToString());
                item.SubItems.Add(dr["MusteriPosta"].ToString());
                item.SubItems.Add(dr["MusteriAdres"].ToString());
                item.SubItems.Add(dr["IlID"].ToString());
                item.SubItems.Add(dr["IlceID"].ToString());
                item.SubItems.Add(dr["UlkeID"].ToString());
                item.SubItems.Add(dr["MusteriAciklama"].ToString());
                item.SubItems.Add(dr["MusteriKurumsalOK"].ToString());
                item.SubItems.Add(dr["DilID"].ToString());


                 lwMusteriler.Items.Add(item);
            }
            cnn.Close();
        }


        private void frmMusteri_Load(object sender, EventArgs e)
        {
            btnGuncelle.Visible = false;
            lwMusteriler.Columns.Add("MusteriId");
            lwMusteriler.Columns.Add("MusteriAd");
            lwMusteriler.Columns.Add("MusteriSoyad");
            lwMusteriler.Columns.Add("MusteriTCKimlik");
            lwMusteriler.Columns.Add("MusteriPasaportNo");
            lwMusteriler.Columns.Add("MusteriUnvan");
            lwMusteriler.Columns.Add("MusteriYetkiliAdSoyad");
            lwMusteriler.Columns.Add("MusteriVergiNo");
            lwMusteriler.Columns.Add("MusteriVergiDairesi");
            lwMusteriler.Columns.Add("MusteriTelefon");
            lwMusteriler.Columns.Add("MusteriPosta");
            lwMusteriler.Columns.Add("MusteriAdres");
            lwMusteriler.Columns.Add("IlID");
            lwMusteriler.Columns.Add("IlceID");
            lwMusteriler.Columns.Add("UlkeID");
            lwMusteriler.Columns.Add("MusteriAciklama");
            lwMusteriler.Columns.Add("MusteriKurumsalOK");
            lwMusteriler.Columns.Add("DilID");

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

            //cbUlke.Items.Add("Lütfen Bir Değer Seçiniz");
            
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Ulke";
            SqlDataReader drUlke = cmd.ExecuteReader();
            while (drUlke.Read())
            {
                cbUlke.Items.Add(drUlke[1].ToString());
            }
            cnn.Close();


            //şehirler
            //cbSehir.Items.Add("Lütfen Bir Değer Seçiniz");
            //cbIlce.Items.Add("Lütfen Bir Değer Seçiniz");

            //cbUlke.SelectedIndex = 0;
            //cbSehir.SelectedIndex = 0;
            //cbIlce.SelectedIndex = 0;













        }

        private void cbUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            cbSehir.DataSource = null;
            cbSehir.Items.Clear();
            //cbSehir.Items.Add("Lütfen Bir Değer Seçiniz");
            //şehirler
            int secilenDeger = cbUlke.SelectedIndex+1;

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Il where UlkeId=@UlkeID ";
            cmd.Parameters.AddWithValue("@UlkeID", secilenDeger);
            SqlDataReader drSehir = cmd.ExecuteReader();
            while (drSehir.Read())
            {
                data.Add(new KeyValuePair<int, string> ( Convert.ToInt32(drSehir[0]), drSehir[1].ToString() ));
                //cbSehir.Items.Add(drSehir[1].ToString());
            }
            cbSehir.DataSource = new BindingSource(data, null);
            cbSehir.DisplayMember = "Value";
            cbSehir.ValueMember = "Key";
            cnn.Close();
            drSehir.Close();
        }

        private void cbSehir_SelectionChangeCommitted(object sender, EventArgs e)
        {

            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();
            cbIlce.DataSource = null;
            //ilçeler
            cbIlce.Items.Clear();
            //cbIlce.Items.Add("Lütfen Bir Değer Seçiniz");
            int secilenDeger = cbSehir.SelectedIndex+1;

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tbl_Ilce where IlId=@IlID";
            cmd.Parameters.AddWithValue("@IlID", secilenDeger);
            SqlDataReader drIlce = cmd.ExecuteReader();
            while (drIlce.Read())
            {
                data.Add(new KeyValuePair<int, string>(Convert.ToInt32(drIlce[0]), drIlce[1].ToString()));
                //cbIlce.Items.Add(drIlce[1].ToString());
            }
            cbIlce.DataSource = new BindingSource(data, null);
            cbIlce.DisplayMember = "Value";
            cbIlce.ValueMember = "Key";
            cnn.Close();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {

            //KeyValuePair<int, string> selectedPairUlke = (KeyValuePair<int, string>)cbUlke.SelectedItem;
            KeyValuePair<int, string> selectedPairIl = (KeyValuePair<int, string>)cbSehir.SelectedItem;
            KeyValuePair<int, string> selectedPairIlce = (KeyValuePair<int, string>)cbIlce.SelectedItem;
            cnn.Open();
            //cmd.CommandText = "INSERT INTO tbl_Musteriler (MusteriAd, MusteriSoyad, MusteriTCKimlik, MusteriPasaportNo, MusteriUnvan, MusteriYetkiliAdSoyad, MusteriVergiNo, MusteriVergiDairesi, MusteriTelefon, MusteriPosta,MusteriAdres, IlID, IlceID, UlkeID, MusteriAciklama, MusteriKurumsalOK, DilID) VALUES (@MusteriAd, @MusteriSoyad, @MusteriTCKimlik, @MusteriPasaportNo, @MusteriUnvan, @MusteriYetkiliAdSoyad, @MusteriVergiNo, @MusteriVergiDairesi, @MusteriTelefon,@MusteriPosta,              @MusteriAdres, @IlID, @IlceID, @UlkeID, @MusteriAciklama, @MusteriKurumsalOK, @DilID)";
            cmd=cnn.CreateCommand();
            cmd.CommandText = "sp_MusterilerINSERT";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriAd",               tbMusteriAd.Text);
            cmd.Parameters.AddWithValue("@MusteriSoyad",            tbMusteriSoyad.Text);
            cmd.Parameters.AddWithValue("@MusteriTCKimlik",         tbMusteriTcKimlik.Text);
            cmd.Parameters.AddWithValue("@MusteriPasaportNo",       tbMusteriPasaportNo.Text);
            cmd.Parameters.AddWithValue("@MusteriUnvan",            tbUnvan.Text);
            cmd.Parameters.AddWithValue("@MusteriYetkiliAdSoyad",   tbYetkiliAdSoyad.Text);
            cmd.Parameters.AddWithValue("@MusteriVergiNo",          tbVergiNo.Text);
            cmd.Parameters.AddWithValue("@MusteriVergiDairesi",     tbVergiDairesi.Text);
            cmd.Parameters.AddWithValue("@MusteriTelefon",          tbTelefonNo.Text);
            cmd.Parameters.AddWithValue("@MusteriPosta",            tbEposta.Text);
            cmd.Parameters.AddWithValue("@MusteriAdres",            tbAdres.Text);
            cmd.Parameters.AddWithValue("@IlID",                    selectedPairIl.Key);                                   
            cmd.Parameters.AddWithValue("@IlceID",                  selectedPairIlce.Key);
            cmd.Parameters.AddWithValue("@UlkeID",                  cbUlke.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@MusteriAciklama",         tbAciklama.Text);
            cmd.Parameters.AddWithValue("@MusteriKurumsalOK",       checkKurumsalBireysel.Checked);
            cmd.Parameters.AddWithValue("@DilID",                   cbDil.SelectedIndex);

            cmd.ExecuteNonQuery();
            cnn.Close();
            Goster();

        }

        private void checkKurumsalBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if(checkKurumsalBireysel.Checked==true)
            {
                checkKurumsalBireysel.Text = "Kurumsal";
            }
            else
            {
                checkKurumsalBireysel.Text = "Bireysel";
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lwMusteriler.SelectedItems)
            {
                int seciliindex = Convert.ToInt32(eachItem.SubItems[0].Text);
                cnn.Open();

                cmd = cnn.CreateCommand();
                cmd.CommandText = "delete from tbl_Musteriler where MusteriID=@MusteriID";
                

                cmd.Parameters.AddWithValue("@MusteriID", seciliindex);

                cmd.ExecuteNonQuery();
                cnn.Close();
                Goster();

                lwMusteriler.Items.Remove(eachItem);
            }


        }

        int guncellemeID;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMusteriEkle.Visible = false;
            btnGuncelle.Visible = true;
            panelMusteriEkle.Visible = true;
            panelMusteriSorgula.Visible = false;
            foreach (ListViewItem eachItem in lwMusteriler.SelectedItems)
            {
                guncellemeID=Convert.ToInt32(eachItem.SubItems[0].Text);
                tbMusteriAd.Text = eachItem.SubItems[1].Text;
                tbMusteriSoyad.Text = eachItem.SubItems[2].Text;
                tbMusteriTcKimlik.Text = eachItem.SubItems[3].Text;
                tbMusteriPasaportNo.Text = eachItem.SubItems[4].Text;
                tbUnvan.Text = eachItem.SubItems[5].Text;
                tbYetkiliAdSoyad.Text = eachItem.SubItems[6].Text;
                tbVergiNo.Text = eachItem.SubItems[7].Text;
                tbVergiDairesi.Text = eachItem.SubItems[8].Text;
                tbTelefonNo.Text = eachItem.SubItems[9].Text;
                tbEposta.Text = eachItem.SubItems[10].Text;
                tbAdres.Text = eachItem.SubItems[11].Text;
                cbUlke.SelectedIndex = Convert.ToInt32(eachItem.SubItems[14].Text);

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


                cbSehir.SelectedIndex = int.Parse(eachItem.SubItems[12].Text);

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
                cbIlce.SelectedIndex = Convert.ToInt32(eachItem.SubItems[13].Text);
                
                tbAciklama.Text = eachItem.SubItems[15].Text;
                checkKurumsalBireysel.Checked = Convert.ToBoolean(eachItem.SubItems[16].Text);
                cbDil.SelectedIndex = Convert.ToInt32(eachItem.SubItems[17].Text);






            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            cnn.Open();
            //cmd.CommandText = "INSERT INTO tbl_Musteriler (MusteriAd, MusteriSoyad, MusteriTCKimlik, MusteriPasaportNo, MusteriUnvan, MusteriYetkiliAdSoyad, MusteriVergiNo, MusteriVergiDairesi, MusteriTelefon, MusteriPosta,MusteriAdres, IlID, IlceID, UlkeID, MusteriAciklama, MusteriKurumsalOK, DilID) VALUES (@MusteriAd, @MusteriSoyad, @MusteriTCKimlik, @MusteriPasaportNo, @MusteriUnvan, @MusteriYetkiliAdSoyad, @MusteriVergiNo, @MusteriVergiDairesi, @MusteriTelefon,@MusteriPosta,              @MusteriAdres, @IlID, @IlceID, @UlkeID, @MusteriAciklama, @MusteriKurumsalOK, @DilID)";
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MusterilerUpdate";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriID", guncellemeID);
            cmd.Parameters.AddWithValue("@MusteriAd", tbMusteriAd.Text);
            cmd.Parameters.AddWithValue("@MusteriSoyad", tbMusteriSoyad.Text);
            cmd.Parameters.AddWithValue("@MusteriTCKimlik", tbMusteriTcKimlik.Text);
            cmd.Parameters.AddWithValue("@MusteriPasaportNo", tbMusteriPasaportNo.Text);
            cmd.Parameters.AddWithValue("@MusteriUnvan", tbUnvan.Text);
            cmd.Parameters.AddWithValue("@MusteriYetkiliAdSoyad", tbYetkiliAdSoyad.Text);
            cmd.Parameters.AddWithValue("@MusteriVergiNo", tbVergiNo.Text);
            cmd.Parameters.AddWithValue("@MusteriVergiDairesi", tbVergiDairesi.Text);
            cmd.Parameters.AddWithValue("@MusteriTelefon", tbTelefonNo.Text);
            cmd.Parameters.AddWithValue("@MusteriPosta", tbEposta.Text);
            cmd.Parameters.AddWithValue("@MusteriAdres", tbAdres.Text);
            cmd.Parameters.AddWithValue("@IlID", cbSehir.SelectedIndex);
            cmd.Parameters.AddWithValue("@IlceID", cbIlce.SelectedIndex);
            cmd.Parameters.AddWithValue("@UlkeID", cbUlke.SelectedIndex);
            cmd.Parameters.AddWithValue("@MusteriAciklama", tbAciklama.Text);
            cmd.Parameters.AddWithValue("@MusteriKurumsalOK", checkKurumsalBireysel.Checked);
            cmd.Parameters.AddWithValue("@DilID", cbDil.SelectedIndex);

            cmd.ExecuteNonQuery();
            cnn.Close();
            Goster();
        }
    }
}
