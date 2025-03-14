using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai14_tinhtoantrendayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int batdau = Int32.Parse(txtbatdau.Text);
            int ketthuc = Int32.Parse(txtketthuc.Text);
            if (batdau > ketthuc) 
            {
                MessageBox.Show("nhập số từ nhỏ đến lớn");
                return;
            }


            long tong=0 ,tongchan=0 ,tongle =0 ;

            for (int i = batdau; i <= ketthuc; i++)
            {
                tong += i;
                if (i%2=0)
                {
                    // số chẵn
                    tongchan += i;
                }
                else 
                {
                    tongle += i;
                }
                    

            } 
            
            ///xuất kết quả
            txttong.Text=tong.ToString();
            txttongchan.Text=tongchan.ToString();
            txttongle.Text = tongle.ToString();


        }
    }
}
