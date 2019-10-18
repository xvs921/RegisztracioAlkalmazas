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
                    sw.WriteLine("Név: "+textBoxNev.Text);
                    sw.WriteLine("Születési dátum: " + dateTimePickerSzulDatum.Value);
                    if (radioButtonFerfi.Checked)
                    {
                        sw.WriteLine("Nem: Férfi");
                    }
                    else if (radioButtonNo.Checked)
                    {
                        sw.WriteLine("Nem: Nő");
                    }
                    sw.WriteLine("Kedvenc hobbi: "+listBoxHobbik.SelectedItem);
                    sw.WriteLine("Kedvenc hobbik listája: ");
                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a kiírás.");
                }

            };

            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    listBoxHobbik.Items.Clear();
                    foreach (var item in sorok)
                    {
                        listBoxHobbik.Items.Add(item);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült betöltés.");
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
