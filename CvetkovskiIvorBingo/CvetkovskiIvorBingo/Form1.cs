using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvetkovskiIvorBingo
{
    public partial class Form1 : Form
    {
        int[] brojevi = new int[6];
        BingoKontrola kontrola = new BingoKontrola();
        public Form1()
        {
            InitializeComponent();
        }

        //unosi unos
        //ispisuje zadnji unos
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                richTextBoxIspis.Clear();
                
                brojevi[0] = Convert.ToInt32(textBoxPrvi.Text);
                brojevi[1] = Convert.ToInt32(textBoxDrugi.Text);
                brojevi[2] = Convert.ToInt32(textBoxTreci.Text);
                brojevi[3] = Convert.ToInt32(textBoxCetvrti.Text);
                brojevi[4] = Convert.ToInt32(textBoxPeti.Text);
                brojevi[5] = Convert.ToInt32(textBoxSesti.Text);

#region for petlje (uvjeti)

                for(int i=0;i<5;i++)
                {
                    for(int j = 1;j<6-i;j++)
                    {
                        if(brojevi[i]==brojevi[i+j])
                        {
                            textBoxPrvi.Clear();
                            textBoxDrugi.Clear();
                            textBoxTreci.Clear();
                            textBoxCetvrti.Clear();
                            textBoxPeti.Clear();
                            textBoxSesti.Clear();

                            MessageBox.Show("Unesite 6 jedinstvenih brojeva!");
                        }
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    if (brojevi[i]>49 && brojevi[i]<1)
                    {
                        textBoxPrvi.Clear();
                        textBoxDrugi.Clear();
                        textBoxTreci.Clear();
                        textBoxCetvrti.Clear();
                        textBoxPeti.Clear();
                        textBoxSesti.Clear();

                        MessageBox.Show("Unesite brojeve od 1 do 49!");
                    }
                }
#endregion

                Listic listic = kontrola.kreirajListic(brojevi);

                richTextBoxIspis.AppendText(kontrola.ispisiListic(listic));

                textBoxPrvi.Clear();
                textBoxDrugi.Clear();
                textBoxTreci.Clear();
                textBoxCetvrti.Clear();
                textBoxPeti.Clear();
                textBoxSesti.Clear();
            }
            catch
            {
                MessageBox.Show("Unesite broj!");
            }
        }


        //ispisuje sve listice
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxIspis.Clear();
            richTextBoxIspis.Text = kontrola.ispisiSveListice();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
