namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click (object sender, EventArgs e)
        { 
        
            int a, b, c;
            a = int.Parse(textBox1.Text);
            a = Math.Clamp(a, -999, 999);
            b = int.Parse(textBox2.Text);       //Inicilizacija na koeficenti
            b = Math.Clamp(b, -999, 999);
            c = int.Parse(textBox3.Text);
            c = Math.Clamp(c, -999, 999);
            if (a == 0 )
            {
                MessageBox.Show("Koeficentot a mora da e pogolem od 0");
            }
            if(textBox1.Text == string.Empty && textBox2.Text==string.Empty && textBox3.Text == string.Empty)
            {
                MessageBox.Show("Koeficentite a,b,c se zadolzitelni.");
            }

            double D, x1, x2;
            D = Math.Pow(b, 2) - (4 * a * c);  //Diskrimanta 
            if (D == 0)
            {
                x1 = Math.Pow(b, 2) / (2 * a);
                x2 = x1;
                textBox5.Text = x1.ToString();
                textBox4.Text = x2.ToString();
                textBox6.Visible = false;
                textBox7.Visible = false;
            }
            else if (D > 0)
            {
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                textBox5.Text = x1.ToString();
                textBox4.Text = x2.ToString();
                textBox6.Visible = false;
                textBox7.Visible = false;

            }
            else if (D < 0)
            {
                double i1 ;
                D = -D;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                 i1 = Math.Sqrt(D) / (2 * a);
                textBox5.Text = (x1 - i1).ToString();
                x2 = (-b - D) / (2 * a);
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox4.Text = (x2 - i1).ToString();
                textBox6.Text = i1.ToString();
                textBox7.Text = (-i1).ToString();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox6.Visible = true;
            textBox7.Visible = true;


            
        }

        
    }
                }