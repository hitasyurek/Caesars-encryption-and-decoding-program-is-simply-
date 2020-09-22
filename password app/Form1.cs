using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//{ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'İ', 'J', 'K', 'L', 'M' , 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z' };
//  { "A", "B", "C", "D", "E", "F", "G", "H", "İ", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z" };
namespace password_app
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }           
       
       
        private void frmmain_Load(object sender, EventArgs e)
        {
            

        }
        private void btnçevir_Click(object sender, EventArgs e)
        {
  
            string veri = " ";
            veri = txtgirdi.Text;
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                txtcıktı.Text += Convert.ToChar(eleman + 3 ).ToString() + " ";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string veri = " ";
            veri = txtgirdi.Text;
            char[] karakterler = veri.ToCharArray();
            foreach (char eleman in karakterler)
            {
                txtcıktı.Text += Convert.ToChar(eleman - 3).ToString() + " ";

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtcıktı.Clear();
            txtgirdi.Clear();
        }

        private void btnbilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sezarr şifrelemesi her harf için kendinden 3 sonra gelen harfi ele alır ve metni böylece anlamsız bir gale getirir");
        }

        private void btnulas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mail : hitasyurek@gmail.com");
        }
    }

      
      

     
    }

