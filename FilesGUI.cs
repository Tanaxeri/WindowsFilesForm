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

namespace WindowsFilesForm
{
    public partial class FilesGUI : Form
    {
        public FilesGUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NevText.Text))
            {

                MessageBox.Show("Nem adott meg nevet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NevText.Focus();
                return;

            }
            if (string.IsNullOrEmpty(FajlSzov_Box.Text))
            {

                MessageBox.Show("Nem adott meg szöveget!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FajlSzov_Box.Focus();
                return;

            }

            FileSaveDialog.Filter = "Minden fájl (*.*)| *.* |Szöveg Fájl (*.txt)| *.txt |Vesszővel tagolt szövegfájl (*.csv)| *.csv";

            if (FileSaveDialog.ShowDialog() == DialogResult.OK)
            {

                string szoveg = string.Join(";", NevText.Text, FajlSzov_Box.Text);
                string kivFile = FileSaveDialog.FileName;
                File.WriteAllText(kivFile, szoveg);
                NevText.Text = "";
                FajlSzov_Box.Text = "";

            }
            else
            {

                MessageBox.Show("Nincs kiválasztva!");

            }

        }

        private void Openbutton_Click(object sender, EventArgs e)
        {

            if (FileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                string kivFile = FileOpenDialog.FileName;
                string beolvasottszoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottszoveg.Split(';');

                NevText.Text = adatok[0];
                FajlSzov_Box.Text = adatok[1];

            }

        }
    }
}
