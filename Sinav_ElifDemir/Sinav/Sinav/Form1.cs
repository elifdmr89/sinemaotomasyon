using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sinav
{
    public partial class Form1 : Form
    {   


        //Koltuk resimleri için
        PictureBox blue = new PictureBox();
        PictureBox red = new PictureBox();
        public Form1()
        {
            InitializeComponent();
        }
        //int sayac=1;
        int kayit = 0;
        int koltukCount = 60;
        PictureBox pp = new PictureBox();
        public void KoltukOlustur() {
            
            for (int i = 0; i < 6; i++)
            {
                int ilkiki=0;
              
                if (i % 2 == 0)
                {
                    ilkiki = 1;
                    
                }
                else
                {
                    ilkiki = 0;
                   
                }
                for (int j = 0; j < 12; j++)
                {
                    if ((ilkiki == 1) && ((j==0) || (j==1) || (j==10) || (j==11)))  { }
                    else{
                    PictureBox baslangic = new PictureBox();
                    baslangic.ImageLocation = "../../blue.PNG";
                    baslangic.Location = new Point(j * 60 + 110, i * 80 + 130);
                    baslangic.Size = new Size(40, 40);
                    baslangic.Tag = "";
                    this.Controls.Add(baslangic);
                    baslangic.MouseClick += baslangic_MouseClick;
                    //baslangic.MouseEnter += baslangic_MouseEnter;
                    //sayac++;
                    }

                   
                   
                
            }


                       
        }
        }

       

     

      

        int btndurum=0;
        void baslangic_MouseClick(object sender, MouseEventArgs e)
        {
            
            pp = sender as PictureBox;
            int iptalEtme = 0;
            //PictureBox pp = sender as PictureBox;
            //MessageBox.Show(pp.Tag.ToString());
            string bilgi = pp.Tag.ToString();
            if (bilgi == "")
            {
                groupBox1.Visible = true;

             
            }
            else {
                if ((MessageBox.Show("Evet Veya Hayır", "Rezervasyonunuz İptal edilecektir",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    pp.ImageLocation = "../../blue.png";

                    string[] adsoyadIptal;
                    adsoyadIptal = pp.Tag.ToString().Split('\n');
                    string iptalAdi=adsoyadIptal[0];
                    string[] noktaliAdSoy;
                    noktaliAdSoy = iptalAdi.Split(':');
                    string AdiIptal = noktaliAdSoy[1];

                    //TC kimlik Numarası
                    string noktaliTC = adsoyadIptal[1];
                    string[] TC;
                    TC= noktaliTC.Split(':');
                    string GosterilecekTc=TC[1];

                    //Cinsiyet
                    string cinsiyet = adsoyadIptal[2];
                    string[] cinsiyetG;
                    cinsiyetG= cinsiyet.Split(':');
                    string GosterilecekCinsiyet = cinsiyetG[1];



                    kayit--;
                    koltukCount++;
                    lblBlue.Text = koltukCount.ToString();
                    lblRed.Text = kayit.ToString();
                    pp.Tag = "";
                    iptalEtme = 1;
                    MessageBox.Show("Sayın " + AdiIptal + " adlı  TC " + GosterilecekTc + "  Cinsiyeti " + GosterilecekCinsiyet + " olan rezervasyon iptal edilmiştir.");
                    
                    

                }
            }
            //MessageBox.Show(bilgi);
            if ((bilgi.Contains("Dolu") == true) && (iptalEtme==0))
            {
                
                
                MessageBox.Show(pp.Tag.ToString() + " yukardaki kişi için ayrıltılmıştır.");
            }
            else { }
            button2.MouseClick+=button2_MouseClick;
               //Mavi ise kırmızı yapıcak
           
            
          
                //MessageBox.Show(pp.Tag.ToString());
               
           
            //Eğer kırmızı ise mavi yapacak
            
            
           
          
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            btndurum = 1;
            groupBox1.Visible = false;
            
            //button2.CausesValidation = true;
        
        }


        Label lblRed = new Label();
        Label lblBlue = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Başlık Oluşturma
            Label lbl = new Label();
            string labeltxt = "Sinema Otomasyonu";
            lbl.Text = labeltxt.ToUpper();
            lbl.Location = new Point(0, 0);
            lbl.BackColor = Color.Red;
            lbl.ForeColor = Color.White;
            lbl.Width = 1365;
            lbl.Height = 120;
            lbl.BackColor = Color.Gray;
            lbl.Font = new Font("Arial", 24f, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            //lbl.Size = new Size(50, 50);
             lbl.ForeColor = Color.Black;
            this.Controls.Add(lbl);

            //Koltuklar yazısı hazırlama
            Label lblKoltuk = new Label();
            lblKoltuk.Text = "Koltuklar";
            lblKoltuk.Location = new Point(0,135);
            this.Controls.Add(lblKoltuk);


            //Aşağıdaki sabit Koltukları oluşturma
           
            //Koltuk Label oluşturma (Blue)
            
            lblBlue.Text = koltukCount.ToString();
            lblBlue.Size = new Size(40, 20);
            lblBlue.Location = new Point(840, 660);
            this.Controls.Add(lblBlue);

            blue.Location = new Point(880,650);
            blue.ImageLocation = "../../blue.PNG";
            blue.Size = new Size(50, 50);
            blue.Tag = "Boş";
            this.Controls.Add(blue);


            //Koltuk Label oluşturma (Red)
            
            lblRed.Text = kayit.ToString();
            lblRed.Size = new Size(40, 20);
            lblRed.Location = new Point(750, 660);
            this.Controls.Add(lblRed);

            red.Location = new Point(790, 650);
            red.ImageLocation = "../../red.PNG";
            red.Size = new Size(50, 50);
            red.Tag = "Dolu";
            this.Controls.Add(red);
            //Koltuk Oluşturma 
            KoltukOlustur();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((textBox1.Text=="") || (maskedTextBox1.Text=="") || ((radioButton1.Checked==false) && (radioButton2.Checked==false))){
            MessageBox.Show("Lütfen değerleri boşluksuz doldurunuz");
            groupBox1.Visible = true;
            }
            else{
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Adsoyad = textBox1.Text;
            string cinsiyet="";
            if (radioButton2.Checked) { cinsiyet = "Kadın"; }
            if (radioButton1.Checked) { cinsiyet = "Erkek"; }
            rezervasyon.Cinsiyet = cinsiyet;
            rezervasyon.Dolumu = "Dolu";

            rezervasyon.TC = maskedTextBox1.Text;
            pp.Tag = rezervasyon;
            pp.ImageLocation = "../../red.png";


            if (btndurum == 1)
            {
                btndurum = 0;

            }
            btndurum = 0;
            ClearAll(groupBox1);
            kayit++;
            koltukCount--;
            lblBlue.Text = koltukCount.ToString();
            lblRed.Text = kayit.ToString();
            }


        }

        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
                maskedTextBox1.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll(this.groupBox1);
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll(groupBox1);
            groupBox1.Visible = false;
            
        }
    }
}
