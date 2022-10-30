using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            kq = a - b;
            txtKQ.Text = kq.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            Calculation cal = new Calculation(a, b);
            txtKQ.Text = cal.Execute("+").ToString();

            //if (txtSoA.Text != String.Empty && txtSoB.Text != String.Empty)
            //{
            //    a = int.Parse(txtSoA.Text);
            //    b = int.Parse(txtSoB.Text);
            //    kq = a + b;
            //    txtKQ.Text = kq.ToString();
            //}
        }
        
    }
}
