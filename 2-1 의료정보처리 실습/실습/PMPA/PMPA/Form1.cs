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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //로그인 코딩

            //1. Employee테이블에서 내가 입력한 ID값 가져오기 
            employeeTableAdapter.FillByID(dataSet1.Employee, textID.Text);

            //2. 데이터 유무 확인하기 
            if (employeeBindingSource.Count > 0)
            {
                //입력한 ID의 데이터가 있다.

                //3. 입력한 Password와 테이블에 저장된 Password 비교

                DataRowView drv = (DataRowView)employeeBindingSource.Current;
                if (textPassword.Text == drv["Password"].ToString())
                {
                    //로그인 성공

                    lblName.Text = drv["Name"].ToString();
                    lblTitle.Text = drv["Title"].ToString();
                    lblDept.Text = drv["Department"].ToString();


                    //사진가져오기
                    //pictureBox1.Load(@"c:\사진\사용자1.jpg");


                    //Panel2를 숨기기
                    panel2.Visible = false;
                    panel4.Visible = true;
                    panel3.Visible = true;


                    return; //버튼1 클릭 이벤트 종료 
                }
            }
            //여기는 데이터가 없는 경우
            MessageBox.Show("ID 또는 비밀번호가 잘 못 입력하였습니다.");






        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //진료과 화면을 호출하기 
            frmDepartment form = new frmDepartment();
            form.MdiParent = this;
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //진료의 관리
            frmDoctor form = new frmDoctor();
            form.MdiParent = this;
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.MdiParent = this;
            form.Show();
        }
    }
}
