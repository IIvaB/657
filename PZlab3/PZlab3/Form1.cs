using System;

namespace PZlab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void setB_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DOit_Click(object sender, EventArgs e)
        {
            string txt9 = "������ ���� ����������";
            FIO.Text = txt9.ToString();

            string txt6 = "��21-1";
            Groupin.Text = txt6.ToString();

            string var2 = "2";
            Varin.Text = var2.ToString();

            string astr, bstr, cstr;

            astr = a_in.Text;
            bstr = b_in.Text;
            cstr = c_in.Text;

            int a, b, c;

            if (!int.TryParse(astr, out a) || !int.TryParse(bstr, out b) || !int.TryParse(cstr, out c))
            {
                result.Text = "�������, ������ �� ������� ���";
            }
            else
            {
                if ((a == b) || (c == a) || (b == c))
                {
                    Rivno.Text = "��������� ������������";
                }
                else
                {
                    Rivno.Text = "��������� �� ������������";
                }

                if ((a + b <= c) || (a + c <= b) || (c + b <= a))
                {
                    result.Text = "��������� �� ����";
                }
                else if ((a + b > c) && (a + c > b) && (c + b > a))
                {
                    result.Text = "��������� ����";
                }
            }
        }
    }
}
