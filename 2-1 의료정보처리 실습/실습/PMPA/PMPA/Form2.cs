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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void codeInsuranceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.codeInsuranceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsuranceSub' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceSubTableAdapter.Fill(this.dataSet1.CodeInsuranceSub);
            // TODO: 이 코드는 데이터를 'dataSet1.CodeInsurance' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.codeInsuranceTableAdapter.Fill(this.dataSet1.CodeInsurance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //보험 유형 신규자료 추가
            codeInsuranceBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //보조 유형 신규
            codeInsuranceSubBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //보험유형 저장
            codeInsuranceBindingSource.EndEdit();
            codeInsuranceTableAdapter.Update(dataSet1.CodeInsurance);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //보험유형 삭제하기
            codeInsuranceBindingSource.RemoveCurrent();
            codeInsuranceTableAdapter.Update(dataSet1.CodeInsurance);
        }
    }
}
