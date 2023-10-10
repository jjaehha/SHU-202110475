using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway_202110475_김재하
{
    public partial class Form3 : Form
    {
        int unitPrice;
        string type;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string station, int price)
        {
            InitializeComponent();
            lblStation.Text = station;
            unitPrice = price;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ComputePrice(4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ComputePrice(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "일반용";
            ComputePrice(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = "일반용";
            ComputePrice(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            type = "어린이용";
            ComputePrice(1);
        }

        private void ComputePrice (int  qty)
        {
            int price;

            if (type == "일반용")
                price = qty * unitPrice;
            else
                price = qty * unitPrice / 2;
            lblPrice.Text = String.Format("{0:#,0} 원", price);

            if (unitPrice == 1000)
            {
                label13.Text = "500원";
            }
            else
            {
                label13.Text = "250원";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComputePrice(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ComputePrice(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ComputePrice(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ComputePrice(3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ComputePrice(5);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
