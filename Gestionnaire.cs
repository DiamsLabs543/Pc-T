using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using System.Windows.Forms;
using System.IO;
using CsvHelper.Configuration;

namespace PasswordCreatorAndTestor
{
    public partial class Gestionnaire : Form
    {
        public class Passwords
        {
            public string Title { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }
        public Gestionnaire()
        {
            InitializeComponent();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };


            using (var streamReader = File.OpenText("Mots de passe.csv"))
            using (var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture))
            {
                var passwords = csvReader.GetRecords<Passwords>();

                dgrPasswords.AutoGenerateColumns = true;
                dgrPasswords.DataSource = passwords.ToList();
            }




        }
    }
}
