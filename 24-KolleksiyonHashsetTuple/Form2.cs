using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_KolleksiyonHashsetTuple
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        List<int> mayin = new List<int>();
        int i = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            for (int i = 0; i < 20; i++)
            {
                mayin.Add(rnd.Next(0, 103));
            }
            for (int i = 0; i < 102; i++)
            {
                Button btn = new Button();
                btn.Height = btn.Width = 30;
                btn.Name = i.ToString();
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }        
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int sayi = Convert.ToInt32(btn.Name);
            foreach (var item in mayin)
            {
                if (sayi == item)
                {
                    btn.BackColor = Color.Red;
                    MessageBox.Show("Kaybettiniz");
                    this.Close();
                    return;      
                }
            }
            btn.BackColor = Color.Green;
            i++;
            label1.Text = "Puan: " + i;
        }
    }
}
