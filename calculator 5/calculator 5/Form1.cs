using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_5
{
    public partial class Form1 : Form
    {
        double enterFirstValues , enterSecondValues ;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValues = Convert.ToDouble(txtRuslt.Text);
            switch (op)
            {
                case "+":
                    txtRuslt.Text = (enterFirstValues + enterSecondValues).ToString();
                    break;
                case "-":
                    txtRuslt.Text = (enterFirstValues - enterSecondValues).ToString();
                    break;                  
                case "*":
                    txtRuslt.Text = (enterFirstValues * enterSecondValues).ToString();
                    break;
                case "/":
                    txtRuslt.Text = (enterFirstValues / enterSecondValues).ToString();
                    break;
                case "Mod":
                    txtRuslt.Text = (enterFirstValues % enterSecondValues).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtRuslt.Text);
                    double j;
                    j = enterSecondValues;
                    txtRuslt.Text = Math.Exp(i*Math.Log(j*4)).ToString();
                    break;
                default:
                    break;

            }
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num=(Button)sender;
            if (txtRuslt.Text == "0")
                txtRuslt.Text = "";
            {
                if (num.Text == ".")
                {
                    if(!txtRuslt.Text.Contains("."))

                        txtRuslt.Text = txtRuslt.Text + num.Text;
                }
                else
                {
                    txtRuslt.Text=txtRuslt.Text + num.Text;
                }

            }


        }

        private void NumberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValues = Convert.ToDouble(txtRuslt.Text);
            op = num.Text;
            txtRuslt.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRuslt.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtRuslt.Text = "0";

            string f, s;

            f = Convert.ToString(enterFirstValues);
            s=Convert.ToString(enterSecondValues);

            f = "";
            s = "";
        }

        private void btnBM_Click(object sender, EventArgs e)
        {
            double q=Convert .ToDouble(txtRuslt.Text);
            txtRuslt.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtRuslt.Text.Length > 0)
            {
                txtRuslt.Text=txtRuslt.Text.Remove(txtRuslt.Text.Length - 1, 1);
            }

            if (txtRuslt.Text =="")
            {
                txtRuslt.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 250; //816
            txtRuslt.Width = 222;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 250; //816
            txtRuslt.Width = 222;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 500; //816
            txtRuslt.Width = 468;
        }

        private void extToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtRuslt.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg=Convert.ToDouble(txtRuslt.Text);
            logg = Math.Log10(logg);
            txtRuslt.Text = Convert.ToString(logg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtRuslt.Text);
            sq = Math.Sqrt(sq);
            txtRuslt.Text = Convert.ToString(sq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x;
            x=Convert.ToDouble(txtRuslt.Text)*Convert.ToDouble(txtRuslt.Text);
            txtRuslt.Text = Convert.ToString(x);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x,q,p,m;
            q= Convert.ToDouble(txtRuslt.Text) * Convert.ToDouble(txtRuslt.Text);
            p = Convert.ToDouble(txtRuslt.Text) * Convert.ToDouble(txtRuslt.Text);
            m= Convert.ToDouble(txtRuslt.Text) * Convert.ToDouble(txtRuslt.Text);
            x = (q * p * m);

            
            txtRuslt.Text = Convert.ToString(x);

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {

            double sh = Convert.ToDouble(txtRuslt.Text);
            sh = Math.Sinh(sh);
            txtRuslt.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double sin = Convert.ToDouble(txtRuslt.Text);
            sin = Math.Sin(sin);
            txtRuslt.Text = Convert.ToString(sin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double cosh = Convert.ToDouble(txtRuslt.Text);
            cosh = Math.Cosh(cosh);
            txtRuslt.Text = Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cos = Convert.ToDouble(txtRuslt.Text);
            cos = Math.Cos(cos);
            txtRuslt.Text = Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {

            double tanh = Convert.ToDouble(txtRuslt.Text);
            tanh = Math.Tanh(tanh);
            txtRuslt.Text = Convert.ToString(tanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double tan = Convert.ToDouble(txtRuslt.Text);
            tan = Math.Tan(tan);
            txtRuslt.Text = Convert.ToString(tan);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtRuslt.Text));
            txtRuslt.Text = Convert.ToString(a);
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double inx = Convert.ToDouble(txtRuslt.Text);
            inx = Math.Log(inx);
            txtRuslt.Text = Convert.ToString(inx);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtRuslt.Text) / Convert.ToDouble(100);
            txtRuslt.Text = Convert.ToString(a);

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtRuslt.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtRuslt.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRuslt.Text);
            txtRuslt.Text=Convert.ToString(a,2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRuslt.Text);
            txtRuslt.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRuslt.Text);
            txtRuslt.Text = Convert.ToString(a, 8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
