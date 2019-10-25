using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fileName);
                    sw.WriteLine(textBoxNev.Text);
                    sw.WriteLine(dateTimePickerSzulDatum.Text);
                    if (radioButtonFerfi.Checked)
                    {
                        sw.WriteLine("Férfi");
                    }
                    else if (radioButtonNo.Checked)
                    {
                        sw.WriteLine("Nő");
                    }
                    sw.WriteLine(listBoxHobbik.SelectedItem);
                    foreach (var item in listBoxHobbik.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a kiírás.");
                }

            };

            openFileDialog1.FileOk += (senderFile, e) =>
            {
                try
                {
                    string fileName = openFileDialog1.FileName;
                    string[] tomb = File.ReadAllLines(fileName);
                    textBoxNev.Text = tomb[0];
                    dateTimePickerSzulDatum.Text = tomb[1];
                    if (tomb[2] == "Férfi")
                    {
                        radioButtonFerfi.Checked = true;
                        radioButtonNo.Checked = false;
                    }
                    else
                    {
                        radioButtonNo.Checked = true;
                        radioButtonFerfi.Checked = false;
                    }
                    listBoxHobbik.SelectedItem = tomb[3];
                    for (int i = 4; i < tomb.Length; i++)
                    {
                        if (!listBoxHobbik.Items.Contains(tomb[i]))
                        {
                            listBoxHobbik.Items.Add(tomb[i]);
                        }
                    }
                    
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Sikertelen betöltés");
                }
            };
        }


        private void btnMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            listBoxHobbik.Items.Add(textBoxUjHobbi.Text);
        }
    }
}
