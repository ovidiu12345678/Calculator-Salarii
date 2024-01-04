using CalculatorSalarii.Formulare;

namespace CalculatorSalarii
{
    public partial class FormularCalculatorSalarii : MaterialSkin.Controls.MaterialForm
    {
        public FormularCalculatorSalarii()
        {
            InitializeComponent();
        }

        private void BtnAngajat_Click(object sender, EventArgs e)
        {
            FormularDetaliiAngajati obFormularDetalii = new FormularDetaliiAngajati();
            this.Hide();
            obFormularDetalii.Show();
        }

        private void BtnSalarii_Click(object sender, EventArgs e)
        {

        }

        private void BtnRapoarte_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void BtnClient_Click(object sender, EventArgs e)
        {

        }

        private void BtnDespre_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}