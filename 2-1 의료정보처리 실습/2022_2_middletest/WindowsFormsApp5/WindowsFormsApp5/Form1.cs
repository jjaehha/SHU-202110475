using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //자료 삭제
            patientBindingSource.RemoveCurrent();
            patientTableAdapter.Update(dataSet1.Patient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //신규 데이터 생성
            patientBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //자료 저장
            patientBindingSource.EndEdit();
            patientTableAdapter.Update(dataSet1.Patient);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //환자번호로 자료 가져오기 
            this.patientTableAdapter.FillByChartNo(this.dataSet1.Patient,chartNoTextBox.Text);
        }
    }
}
