using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(textBox1.Text);
                try
                {
                    b = int.Parse(textBox2.Text);
                    double mocnina = 1;

                    try
                    {
                        if (b != 0)
                        {
                            for (int i = 0; i < Math.Abs(b); i++)
                            {
                                mocnina *= a;
                            }
                            if (double.IsInfinity(mocnina)) throw new OverflowException();
                            if (b < 0) mocnina = 1 / mocnina;
                        }
                        else mocnina = 1;
                    }
                    catch(OverflowException)
                    {
                        MessageBox.Show("Výsledek je příliš malý nebo velké");
                    }
                    MessageBox.Show("Mocnina: " + mocnina);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Číslo je příliš malé nebo velké");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Musítě zadat celé číslo");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Číslo je příliš malé nebo velké");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            catch (FormatException)
            {
                MessageBox.Show("Musítě zadat celé číslo");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }
}
