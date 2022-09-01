namespace PersonelEndeksaCalisan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtİşeGiriş = new System.Windows.Forms.TextBox();
            this.mskticket = new System.Windows.Forms.MaskedTextBox();
            this.txtcinsiyet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdepartman = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtİşeGiriş);
            this.groupBox1.Controls.Add(this.mskticket);
            this.groupBox1.Controls.Add(this.txtcinsiyet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdepartman);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Giriş";
            // 
            // txttid
            // 
            this.txttid.Location = new System.Drawing.Point(107, 25);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(125, 27);
            this.txttid.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "İşeGirişTarihi";
            // 
            // txtİşeGiriş
            // 
            this.txtİşeGiriş.Location = new System.Drawing.Point(107, 157);
            this.txtİşeGiriş.Name = "txtİşeGiriş";
            this.txtİşeGiriş.Size = new System.Drawing.Size(125, 27);
            this.txtİşeGiriş.TabIndex = 15;
            this.txtİşeGiriş.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mskticket
            // 
            this.mskticket.Location = new System.Drawing.Point(107, 190);
            this.mskticket.Mask = "00000";
            this.mskticket.Name = "mskticket";
            this.mskticket.Size = new System.Drawing.Size(125, 27);
            this.mskticket.TabIndex = 14;
            this.mskticket.ValidatingType = typeof(int);
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.Location = new System.Drawing.Point(107, 223);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(125, 27);
            this.txtcinsiyet.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cinsiyet";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "TicketMiktarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departman";
            // 
            // txtdepartman
            // 
            this.txtdepartman.Location = new System.Drawing.Point(107, 124);
            this.txtdepartman.Name = "txtdepartman";
            this.txtdepartman.Size = new System.Drawing.Size(125, 27);
            this.txtdepartman.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(107, 91);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(125, 27);
            this.txtsoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(107, 59);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(125, 27);
            this.txtad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(342, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İslemler";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(28, 208);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(94, 29);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(28, 164);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(94, 29);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(28, 118);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 29);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(28, 76);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 29);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(28, 33);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(94, 29);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 199);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(712, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private TextBox txtdepartman;
        private TextBox txtsoyad;
        private Label label3;
        private TextBox txtad;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private TextBox txtcinsiyet;
        private MaskedTextBox mskticket;
        private GroupBox groupBox2;
        private Button btntemizle;
        private Button btnguncelle;
        private Button btnsil;
        private Button btnkaydet;
        private Button btnlistele;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtİşeGiriş;
        private TextBox txttid;
    }
}