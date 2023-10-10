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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("단대오거리",1000);
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("답십리", 1200);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("달월", 1100);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("당고개", 1000);
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("당산", 1200);
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("당정", 1200);
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("대곡", 1000);
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("대공원", 1100);
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("대림", 1000);
            form.ShowDialog();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3("대모산입구", 1000);
            form.ShowDialog();
        }
    }
}
