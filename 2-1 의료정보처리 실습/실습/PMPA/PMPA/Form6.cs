using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMPA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.PatientAcceptance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //환자정보를 찾는 코딩
            this.patientTableAdapter.FillByChartNo(this.dataSet1.Patient, chartNoTextBox.Text);

            DataRowView drv = (DataRowView)patientBindingSource.Current;
            if (drv["BirthdayType"].ToString() == "S")
                radS.Checked = true;
            else
                radL.Checked = true;
            //Where ChartNo = @ChartNo and AccDate = @AccDate
            this.patientAcceptanceTableAdapter.FillByDate(
                this.dataSet1.PatientAcceptance,
                chartNoTextBox.Text, 
                DateTime.Now.Date   );
            if (patientAcceptanceBindingSource.Count < 1)
            {
                //신규 접수내역 등록
                patientAcceptanceBindingSource.AddNew();

                DataRowView drvAcceptance = 
                    (DataRowView)patientAcceptanceBindingSource.Current;

                drvAcceptance["AccNo"] = "";
                drvAcceptance["ChartNo"] = chartNoTextBox.Text;
                drvAcceptance["AccDate"] = DateTime.Now.Date;
                drvAcceptance["DeptCode"] = "";
                drvAcceptance["DocNo"] = "";
                drvAcceptance["ExamType"] = "";
                drvAcceptance["InsuCode"] = "";

                patientAcceptanceBindingSource.EndEdit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //신규등록
            patientBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //현재 화면에서 선택된 행
            DataRowView drv = (DataRowView)patientBindingSource.Current;


            if (radS.Checked == true)
                drv["BirthdayType"] = "S";
            else
                drv["BirthdayType"] = "L";



            //저장
            //DataSet1 -> Databae
            patientBindingSource.EndEdit();
            patientTableAdapter.Update(dataSet1.Patient);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //삭제
            patientBindingSource.RemoveCurrent();
            patientTableAdapter.Update(dataSet1.Patient);
        }

        private void chartNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void radF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
