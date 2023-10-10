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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void codeDeptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codeDeptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CodeDept' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeDeptTableAdapter.Fill(this.dataSet1.CodeDept);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //현재 화면을 닫기 
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //저장
            codeDeptBindingSource.EndEdit();
            codeDeptTableAdapter.Update(dataSet1.CodeDept);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //신규 등록
            codeDeptBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //삭제
            codeDeptBindingSource.RemoveCurrent();
            codeDeptTableAdapter.Update(dataSet1.CodeDept);

        }
    }
}
