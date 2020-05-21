using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int income = int.Parse(textBox34.Text) * 12;//รายรับ
            //หมวดครอบครัว
            int fees = int.Parse(textBox35.Text);//ค่าคลอด
            int disab = (int)numericUpDown3.Value * 60000;//พิการ
            //อสังหาริมทรัพย์
            int interest_living = int.Parse(textBox5.Text);//ดอกเบี้ยเงินกู้ยืมเพื่อการมีที่อยู่อาศัย
            //มาตรการกระตุ้นเศรษฐกิจของรัฐ
            int shop = int.Parse(textBox6.Text);//ช้อปช่วยชาติ
            int book = int.Parse(textBox7.Text);//ซื้อหนังสือ
            int otop = int.Parse(textBox8.Text);//otop
            int bookED = int.Parse(textBox9.Text);//ซื้อหนังสือการศึกษา
            //เงินออมและการลงทุน+ประกัน
            int insure1 = int.Parse(textBox12.Text);//ประกันสังคม
            int LTF = int.Parse(textBox13.Text);//กองทุน LTF
            int Provident_fund = int.Parse(textBox14.Text);//กองทุนสำรองเลี้ยงชีพ
            int Savings_fund = int.Parse(textBox15.Text);//กองทุนการออม
            int RMF = int.Parse(textBox16.Text);//กองทุนRMF
            int Privateschoolteacher_fund = int.Parse(textBox18.Text);//กองทุนครูโรงเรียนเอกชน
            int Government_Pension_Fund = int.Parse(textBox17.Text);//กองทุนกองทุนบำเหน็จบำนาญข้าราชการ
            //เงินบริจาค
            int Help_Pabukstorm = int.Parse(textBox29.Text);//ช่วยเหลืออุทกภัยจากพายุปาบึก
            int General_donation = int.Parse(textBox28.Text);//บริจาคทั่วไป
            int Donate_political_parties = int.Parse(textBox27.Text);//บริจาคให้พรรคการเมือง
            int Savings_fundSupport_education = int.Parse(textBox26.Text);//สนับสนุนการศึกษา
            int For_government_hospitals = int.Parse(textBox25.Text);//ให้สถานพยาบาลของรัฐ
            int publicbenefits = int.Parse(textBox24.Text);//เพื่อสาธารณะประโยชน์ต่างๆ
            int sport = int.Parse(textBox23.Text);//สนับสนุนการกีฬา
            int deduction = 60000 + fees + disab + interest_living +book+shop+bookED+otop+
                insure1+LTF+Privateschoolteacher_fund+Provident_fund+Savings_fund+RMF+
                Government_Pension_Fund+Help_Pabukstorm+General_donation+Donate_political_parties+Savings_fundSupport_education+For_government_hospitals+publicbenefits+sport;//ค่าลดหย่อน
            int vat;//อัตราภาษี
            int net = 0;//รายได้สุทธิ
            int tax;//ภาษีที่ต้องจ่าย
            //หมวดครอบครัว-----------------------------------------------------------
            switch (comboBox1.SelectedIndex)//เงื่อนไขสถานะ
            {
                case 0://โสด
                    deduction = deduction +0 ;
                    net = income - deduction;
                    vat = 0;
                    if (net <= 150000)
                    {
                        vat = 0;
                    }
                    if (net > 150000 && net <= 300000)
                    {
                        vat = 5;
                    }
                    if (net > 300000 && net <= 500000)
                    {
                        vat = 10;
                    }
                    if (net > 500000 && net <= 750000)
                    {
                        vat = 15;
                    }
                    if (net > 750000 && net <= 1000000)
                    {
                        vat = 20;
                    }
                    if (net > 1000000 && net <= 2000000)
                    {
                        vat = 25;
                    }
                    if (net > 2000000 && net <= 5000000)
                    {
                        vat = 30;
                    }
                    if (net > 5000000)
                    {
                        vat = 35;
                    }
                    tax = net * vat / 100;
                    if (net < 0)
                    {
                        net = 0;
                    }
                    if (tax < 0)
                    {
                        tax = 0;
                    }
                    netTX.Text = net.ToString();
                    deductionTX.Text = deduction.ToString();
                    taxTX.Text = tax.ToString();
                    break;
                case 1://คู่สมรสมีรายได้

                    deduction = deduction + 0;
                    net = income - deduction;
                    vat = 0;
                    if (net <= 150000)
                    {
                        vat = 0;
                    }
                    if (net > 150000 && net <= 300000)
                    {
                        vat = 5;
                    }
                    if (net > 300000 && net <= 500000)
                    {
                        vat = 10;
                    }
                    if (net > 500000 && net <= 750000)
                    {
                        vat = 15;
                    }
                    if (net > 750000 && net <= 1000000)
                    {
                        vat = 20;
                    }
                    if (net > 1000000 && net <= 2000000)
                    {
                        vat = 25;
                    }
                    if (net > 2000000 && net <= 5000000)
                    {
                        vat = 30;
                    }
                    if (net > 5000000)
                    {
                        vat = 35;
                    }
                    tax = net * vat / 100;
                    if (net < 0)
                    {
                        net = 0;
                    }
                    if (tax < 0)
                    {
                        tax = 0;
                    }
                    netTX.Text = net.ToString();
                    deductionTX.Text = deduction.ToString();
                    taxTX.Text = tax.ToString();

                    break;
                case 2://คู่สมรสไม่มีรายได้

                    deduction = deduction + 60000;
                    net = income - deduction;
                    vat = 0;
                    if (net <= 150000)
                    {
                        vat = 0;
                    }
                    if (net > 150000 && net <= 300000)
                    {
                        vat = 5;
                    }
                    if (net > 300000 && net <= 500000)
                    {
                        vat = 10;
                    }
                    if (net > 500000 && net <= 750000)
                    {
                        vat = 15;
                    }
                    if (net > 750000 && net <= 1000000)
                    {
                        vat = 20;
                    }
                    if (net > 1000000 && net <= 2000000)
                    {
                        vat = 25;
                    }
                    if (net > 2000000 && net <= 5000000)
                    {
                        vat = 30;
                    }
                    if (net > 5000000)
                    {
                        vat = 35;
                    }
                    tax = net * vat / 100;
                    if (net < 0)
                    {
                        net = 0;
                    }
                    if (tax < 0)
                    {
                        tax = 0;
                    }
                    netTX.Text = net.ToString();
                    deductionTX.Text = deduction.ToString();
                    taxTX.Text = tax.ToString();
                    break;
            }
            if(checkBox1.Checked)//ไม่มีบุตร
            {
                deduction = deduction + 0;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox2.Checked)//บุตรที่เกิดก่อน 2561
            {
                deduction = deduction + (int)numericUpDown1.Value*30000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox3.Checked)//บุตรที่เกิดหลัง 2561
            {
                deduction = deduction + (int)numericUpDown2.Value*60000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox4.Checked)//ไม่อุปการะบิดามารดา
            {
                deduction = deduction + 0;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox5.Checked)//อุปการะมารดา
            {
                deduction = deduction + 30000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox6.Checked)//อุปการะบิดา
            {
                deduction = deduction + 30000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox7.Checked)//อุปการะบิดาคู่สมรส
            {
                deduction = deduction + 30000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox8.Checked)//อุปการะมารดาคู่สมรส
            {
                deduction = deduction + 30000;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            //หมวดอสังหาริมทรัพย์-----------------------------------------------------------
            if (checkBox10.Checked)//บ้านหลังแรกปี 2558
            {
                deduction = deduction + int.Parse(textBox4.Text) ;
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox9.Checked)//บ้านหลังแรกปี 2562
            {
                deduction = deduction + int.Parse(textBox3.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            //หมวดอุทกภัย-----------------------------------------------------------
            if (checkBox18.Checked)//พายุปาบึก ค่าซ่อมแซมอสังหาริมทรัพย์(ตามที่จ่ายจริง แต่ไม่เกิน 100,000)
            {
                deduction = deduction + int.Parse(textBox31.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox17.Checked)//พายุปาบึก ซ่อมแซมรถ
            {
                deduction = deduction + int.Parse(textBox30.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox19.Checked)//พายุโพดุล ค่าซ่อมแซมอสังหาริมทรัพย์
            {
                deduction = deduction + int.Parse(textBox33.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox20.Checked)//พายุโพดุล ซ่อมแซมรถ
            {
                deduction = deduction + int.Parse(textBox32.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            //หมวดมาตรการกระตุ้นเศรษฐกิจของรัฐ-----------------------------------------------------------
            if (checkBox12.Checked)//เที่ยวเมืองหลัก
            {
                deduction = deduction + int.Parse(textBox11.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox11.Checked)//เที่ยวเมืองรอง
            {
                deduction = deduction + int.Parse(textBox10.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            //กลุ่มเบี้ยประกัน-----------------------------------------------------------
            if (checkBox14.Checked)//ประกันตนเอง
            {
                deduction = deduction + int.Parse(textBox20.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox13.Checked)//ประกันบิดา-มารดา
            {
                deduction = deduction + int.Parse(textBox19.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox16.Checked)//ประกันชีวิตทั่วไป/เงินฝากเพื่อสงเคราะห์ชีวิต
            {
                deduction = deduction + int.Parse(textBox22.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
            if (checkBox15.Checked)//ประกันชีวิตบำเนาญ
            {
                deduction = deduction + int.Parse(textBox21.Text);
                net = income - deduction;
                vat = 0;
                if (net <= 150000)
                {
                    vat = 0;
                }
                if (net > 150000 && net <= 300000)
                {
                    vat = 5;
                }
                if (net > 300000 && net <= 500000)
                {
                    vat = 10;
                }
                if (net > 500000 && net <= 750000)
                {
                    vat = 15;
                }
                if (net > 750000 && net <= 1000000)
                {
                    vat = 20;
                }
                if (net > 1000000 && net <= 2000000)
                {
                    vat = 25;
                }
                if (net > 2000000 && net <= 5000000)
                {
                    vat = 30;
                }
                if (net > 5000000)
                {
                    vat = 35;
                }
                tax = net * vat / 100;
                if (net < 0)
                {
                    net = 0;
                }
                if (tax < 0)
                {
                    tax = 0;
                }
                netTX.Text = net.ToString();
                deductionTX.Text = deduction.ToString();
                taxTX.Text = tax.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox34.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox35.Clear();

        }
    }
}
