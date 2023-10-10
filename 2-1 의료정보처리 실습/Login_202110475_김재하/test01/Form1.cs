using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.Employee' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. 아이디 찾기
            this.employeeTableAdapter.FillByID(this.dataSet1.Employee, textBox1.Text);
            //2. ID 찾기 결과

            if (employeeBindingSource.Count > 0)
            {
                //2.1비교
                DataRowView drv = (DataRowView)employeeBindingSource[0];
                if(textBox2.Text == drv["Password"].ToString())
                {
                    MessageBox.Show("로그인 성공");
                    return;
                }
            }

            //3. id 찾기 실패
            MessageBox.Show("ID 또는 비밀번호 찾지 못했습니다.");
        }
    }
}
