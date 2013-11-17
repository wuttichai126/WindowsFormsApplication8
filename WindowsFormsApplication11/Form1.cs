using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op1,op2,op3,op4;
            //เพศ
            if (radioButton1.Checked == true)
            {
                op1 = "ชาย";
            }
            else 

            {
                op1 = "หญิง";
            }
            //สถานะภาพ

            if (radioButton3.Checked == true)
            {
                op2 = "โสด";
            }
            else if (radioButton4.Checked == true)
            {
            op2 = "สมรส";
            }
            else 
            {
            op2 = "อย่าร้าง/แยกกันอยู่";
            }
            //ระดัยการศึกษา
            if (radioButton6.Checked==true)
            {
            op3 = "มัธยมศึกษา";
            }
            else if (radioButton7.Checked == true)
            {
                op3 = "ปริญญาตรี";
            }
            else if (radioButton8.Checked == true)
            {
                op3 = "ปริญญาโท";
            }
            else

            {
                op3 = "ปริญญาเอก";
            }
            //คุณใช้บริการบ่อยแค่ไหน

            if (radioButton10.Checked == true)
            {
                op4 = "มาก";
            }
            else if (radioButton11.Checked == true)

            {
                op4 = "บ่อย";
            }
            else if (radioButton12.Checked == true)
            {
                op4 = "พแสมควร";
            }
            else
            {
                op4 = "น้อย";
            }
            Form2 ms = new Form2(op1,op2,op3,op4);
            ms.Show();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
