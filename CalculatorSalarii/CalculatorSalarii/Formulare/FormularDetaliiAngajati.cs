using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSalarii.Formulare
{
    public partial class FormularDetaliiAngajati : MaterialSkin.Controls.MaterialForm
    {
        string numeFisier;
        public FormularDetaliiAngajati()
        {
            InitializeComponent();
        }

        private void DetaliiAngajati_Load(object sender, EventArgs e)
        {

        }

        private void BtnTablouBord_Click(object sender, EventArgs e)
        {
            FormularCalculatorSalarii obFormularCalculator = new FormularCalculatorSalarii();
            this.Hide();
            obFormularCalculator.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdaugaPoza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog obpoza = new OpenFileDialog() { Filter = "JPEg|*jpg", ValidateNames = true, Multiselect = false })
            {
                if (obpoza.ShowDialog() == DialogResult.OK)
                {
                    numeFisier = obpoza.FileName;
                    pictureImage.Image = Image.FromFile(obpoza.FileName);
                }
            }
        }

        private void BtnStergePozaAdauga_Click(object sender, EventArgs e)
        {
            pictureImage.Image = null;
        }

        private void TextAngajatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextCnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDataNasterii_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextGen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextLocalitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextJudet_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextCodPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalvare_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizeaza_Click(object sender, EventArgs e)
        {

        }

        private void BtnSterge_Click(object sender, EventArgs e)
        {

        }
    }
}
