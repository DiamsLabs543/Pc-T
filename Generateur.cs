using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordCreatorAndTestor
{
    public partial class Generateur : Form
    {
        public string[] lines;
        public Random rnd = new Random();
        public Generateur()
        {
            InitializeComponent();

            lines = System.IO.File.ReadAllLines(@"liste de mots.txt");

            var result = Array.FindAll(lines, element => element.Length == 1);
            lstMots.Items.AddRange(result);

            txtTexteGenere.Text = "";

            lblMessage.Text = "";
        }

        private void butHaut_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (lstSpecs.SelectedIndex > 0)
            {
                int index = lstSpecs.SelectedIndex;
                string element = lstSpecs.Items[lstSpecs.SelectedIndex].ToString();
                lstSpecs.Items.RemoveAt(lstSpecs.SelectedIndex);
                lstSpecs.Items.Insert(index-1, element);
                lstSpecs.SelectedIndex = index - 1;
            }
        }

        private void butBas_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (lstSpecs.SelectedIndex < (lstSpecs.Items.Count-1))
            {
                int index = lstSpecs.SelectedIndex;
                string element = lstSpecs.Items[lstSpecs.SelectedIndex].ToString();
                lstSpecs.Items.RemoveAt(lstSpecs.SelectedIndex);
                lstSpecs.Items.Insert(index+1, element);
                lstSpecs.SelectedIndex = index + 1;
            }
        }

        private void lstAttributs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifier si la taille est dépassée
            int nvTaille = Int32.Parse(lblMaxCompteur.Text) - 1;
            if (nvTaille < 0)
            {
                lblMessage.Text = "Vous allez dépasser le nombre de caractères";
            }
            else
            {
                string cTexte = lstAttributs.SelectedItem.ToString() + " (1)";
                // Ajouter l'élément dans la liste à côté
                lstSpecs.Items.Add(cTexte);
                lblMaxCompteur.Text = (nvTaille).ToString();

                lblMessage.Text = "";
            }
        }

        //private void lstAttributs_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control == true && e.KeyCode == Keys.C)
        //    {
        //        string s = lstAttributs.SelectedItem.ToString();
        //        Clipboard.SetData(DataFormats.StringFormat, s);
        //    }
        //}

        private void butSupprimer_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (lstSpecs.SelectedIndex != -1)
            {
                for (int i = lstSpecs.SelectedItems.Count - 1; i >= 0; i--)
                { 
                    // Réajuster la taille
                    string cTexte = lstSpecs.SelectedItems[i].ToString();
                    string cLongueur = cTexte.Substring(cTexte.LastIndexOf(" ") + 1).Replace("(", "").Replace(")", "");
                    int nvTaille = Int32.Parse(lblMaxCompteur.Text) + Int32.Parse(cLongueur);
                    lblMaxCompteur.Text = (nvTaille).ToString();

                    lstSpecs.Items.Remove(lstSpecs.SelectedItems[i]);
                }
            }
         }

        private void butMotInclure_Click(object sender, EventArgs e)
        {
            // Vérifier si la taille est dépassée
            int nvTaille = Int32.Parse(lblMaxCompteur.Text) - txtMotInclure.TextLength;
            if (nvTaille < 0)
            {
                lblMessage.Text = "Vous allez dépasser le nombre de caractères";
            }
            else
            {
                // Ajouter le mot à inclure dans la liste à côté
                string cTexte = txtMotInclure.Text + " (" + txtMotInclure.Text.Length.ToString() + ")";
                lstSpecs.Items.Add(cTexte);
                lblMaxCompteur.Text = (nvTaille).ToString();

                lblMessage.Text = "";
            }
        }

        private void lstMots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butGénérer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int indexRnd = rnd.Next(lstMots.Items.Count);
            lstMots.SelectedIndex = indexRnd;

            lblMessage.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int taille = (int)numericUpDown1.Value;
            var result = Array.FindAll(lines, element => element.Length == taille);
            lstMots.Items.Clear();
            lstMots.Items.AddRange(result);

            lblMessage.Text = "";
        }

        private void butListeMotsInclure_Click(object sender, EventArgs e)
        {
            // Ajouter le mot à inclure dans la liste à côté
            if (lstMots.SelectedIndex != -1)
            {
                // Vérifier si la taille est dépassée
                int nvTaille = Int32.Parse(lblMaxCompteur.Text) - lstMots.SelectedItem.ToString().Length;
                if (nvTaille < 0)
                {
                    lblMessage.Text = "Vous allez dépasser le nombre de caractères";
                }
                else
                {
                    // Ajouter le mot à inclure dans la liste à côté
                    string cTexte = lstMots.SelectedItem.ToString() + " (" + lstMots.SelectedItem.ToString().Length.ToString() + ")";
                    lstSpecs.Items.Add(cTexte);
                    lblMaxCompteur.Text = (nvTaille).ToString();

                    lblMessage.Text = "";
                }
            }
        }

        private void txtTaille_ValueChanged(object sender, EventArgs e)
        {
            lstSpecs.Items.Clear();
            lblMaxCompteur.Text = txtTaille.Value.ToString();

            lblMessage.Text = "";
        }

        private void butGenerer_Click(object sender, EventArgs e)
        {
            for (int n=1; n <= int.Parse(txtNbGen.Text); n++)
            {
                foreach (var item in lstSpecs.Items)
                {
                    // Item = Symbole (1), Chiffre (1), Lettre Majuscule (1), Lettre Minuscule (1) ?
                    switch (item)
                    {
                        case "Symbole (1)":
                            string symboles = "\"#$%&!'()*+,-./:;<=>?@[\\]^_`{|}€~°¨£¤µ§";
                            int chiffre = rnd.Next(0, symboles.Length);  // creates a number between 0 and length of symboles
                            txtTexteGenere.Text += symboles.Substring(chiffre, 1);
                            break;

                        case "Chiffre (1)":
                            chiffre = rnd.Next(0, 9);  // creates a number between 0 and 9
                            txtTexteGenere.Text += chiffre.ToString();
                            break;

                        case "Lettre majuscule (1)":
                            chiffre = rnd.Next(0, 25);  // creates a number between 0 and 25
                            txtTexteGenere.Text += "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(chiffre, 1);
                            break;

                        case "Lettre minuscule (1)":
                            chiffre = rnd.Next(0, 25);  // creates a number between 0 and 25
                            txtTexteGenere.Text += "abcdefghijklmnopqrstuvwxyz".Substring(chiffre, 1);
                            break;

                        default:
                            txtTexteGenere.Text += item.ToString().Substring(0, item.ToString().Length - 4);
                            break;
                    }
                }
                txtTexteGenere.Text += "\r\n";
            }
        }

        private void lstAttributs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lstAttributs.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void butEnrTexte_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog
            {
                Title = "Donner le nom du fichier à sauver",
                Filter = "txt files (*.txt)|*.txt"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               using (StreamWriter writer = File.CreateText(ofd.FileName))
                {
                    writer.WriteLine(txtTexteGenere.Text);
                }

                lblMessage.Text = "Le fichier '"+ofd.FileName+"' a bien été enregistré.";
            }
        }
    }
}
