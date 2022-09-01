using System.Data.SqlClient;

namespace PersonelEndeksaCalisan
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\Okan;Initial Catalog=dboEndeksUsers2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void temizle()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            txttid.Text = "";
            txtdepartman.Text = "";
            txtÝþeGiriþ.Text = "";
            mskticket.Text = "";
            txtcinsiyet.Text = "";
            txtad.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<endeksaCalisan> list = new List<endeksaCalisan>();

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Okan;Initial Catalog=dboEndeksUsers2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "SELECT TOP (1000) [Id],[isim],[Soyad],[Departman],[ÝþeGiriþTarih],[ticketmiktari],[Cinsiyet],[musteriId]  " +
                "FROM [dboEndeksUsers2].[dbo].[EndeksaCalisan]";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                endeksaCalisan calisan = new endeksaCalisan();
                calisan.Id = reader.GetInt32(0);
                calisan.Ad = reader.GetString(1);
                calisan.SoyAd = reader.GetString(2);
                calisan.Departman = (Departman) reader.GetValue(3);
                calisan.IseGiris = reader.GetDateTime(4);
                calisan.ticketMiktar = reader.GetInt32(5);
                calisan.Cinsiyet = Convert.ToChar( reader.GetString(6));

                list.Add(calisan);


                //list_customer.Items.Add($"{calisan.Ad} {calisan.SoyAd} {calisan.Departman} {calisan.IseGiris} {calisan.Cinsiyet} {calisan.ticketMiktar} ");
                //dataGridView2.Items.Add($"{calisan.Ad} {calisan.SoyAd} {calisan.Departman} {calisan.IseGiris} {calisan.Cinsiyet} {calisan.ticketMiktar} ");

            }
            reader.Close();
            con.Close();


            if (list != null && list.Count > 0)
            {
                dataGridView1.DataSource = list;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into EndeksaCalisan (isim,Soyad,Departman,ÝþeGiriþTarih,ticketmiktari,Cinsiyet ) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtdepartman.Text);
            komut.Parameters.AddWithValue("@p4", txtÝþeGiriþ.Text);
            komut.Parameters.AddWithValue("@p5", mskticket.Text);
            komut.Parameters.AddWithValue("@p6", txtcinsiyet.Text);
           // komut.Parameters.AddWithValue("@p7", txttid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklemeniz Tamamlandý");   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txttid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtdepartman.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            txtÝþeGiriþ.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            mskticket.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtcinsiyet.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From EndeksaCalisan Where Id=@p7", baglanti);
            sil.Parameters.AddWithValue("@p7",txttid.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayýt Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update EndeksaCalisan Set isim=@p1,Soyad=@p2,Departman=@p3,ÝþeGiriþTarih=@p4,ticketmiktari=@p5,Cinsiyet=@p6 where Id=@p7", baglanti);
            guncelle.Parameters.AddWithValue("p1", txtad.Text);
            guncelle.Parameters.AddWithValue("p2", txtsoyad.Text);
            guncelle.Parameters.AddWithValue("p3", (Departman.Ik));
            guncelle.Parameters.AddWithValue("p4", txtÝþeGiriþ.Text);
            guncelle.Parameters.AddWithValue("p5", mskticket.Text);
            guncelle.Parameters.AddWithValue("p6", Convert.ToChar(txtcinsiyet.Text));
            guncelle.Parameters.AddWithValue("p7", txttid.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellenesi Tamamlandý");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
