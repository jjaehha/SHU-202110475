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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void codeDeptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codeDeptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CodeDoctorSign' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeDoctorSignTableAdapter.Fill(this.dataSet1.CodeDoctorSign);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeDoctor' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeDoctorTableAdapter.Fill(this.dataSet1.CodeDoctor);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeDoctor' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeDoctorTableAdapter.Fill(this.dataSet1.CodeDoctor);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeDept' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeDeptTableAdapter.Fill(this.dataSet1.CodeDept);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //종료버튼
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //신규등록
            codeDoctorBindingSource.AddNew();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //자료 추가 및 수정
            codeDoctorBindingSource.EndEdit();
            codeDoctorTableAdapter.Update(dataSet1.CodeDoctor);

            MessageBox.Show("자료가 저장 되었습니다.");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //현재 선택된 행을 삭제
            codeDoctorBindingSource.RemoveCurrent();
            codeDoctorTableAdapter.Update(dataSet1.CodeDoctor);

            MessageBox.Show("자료가 삭제 되었습니다.");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //사진 신규 등록
            codeDoctorSignBindingSource.AddNew();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            codeDoctorSignBindingSource.EndEdit();
            codeDoctorSignTableAdapter.Update(dataSet1.CodeDoctorSign);

            MessageBox.Show("자료가 저장 되었습니다.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            pathTextBox.Text = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //사진 가져오기
            pictureBox1.Load(pathTextBox.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //사진, 도장, 싸인중 한개를 선택한다면

            switch (comboBox1.Text)
            {
                case "사진":
                    seqTextBox.Text = "10";
                    break;
                case "도장":
                    seqTextBox.Text = "20";
                    break;
                case "싸인":
                    seqTextBox.Text = "30";
                    break;
            }

        }

        private void codeDoctorSignDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void codeDoctorSignDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void codeDoctorSignDataGridView_Click(object sender, EventArgs e)
        {
            //사진 가져오기
            pictureBox1.Load(pathTextBox.Text);
        }
    }
}
