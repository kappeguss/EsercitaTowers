using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace EsercitaTowers
{
    public partial class Form1 : Form
    {
        private Bancomat bancomat, bancomat2;
        private Conto conto, conto2;
        public Form1()
        {
            InitializeComponent();
            conto = new Conto("Hu", "Mediolanum", 600);
            bancomat = new Bancomat("12347654239", "177", conto);
            conto2 = new Conto("Signorelli", "Skibidi", 1200);
            bancomat2 = new Bancomat("6578342150", "090", conto2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(conto.Saldo);
            label5.Text = Convert.ToString(conto2.Saldo);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bancomat.Prelievo(Convert.ToDouble(numericUpDown1.Value));
            label2.Text = Convert.ToString(conto.Saldo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bancomat.Deposito(Convert.ToDouble(numericUpDown1.Value));
            label2.Text = Convert.ToString(conto.Saldo);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bancomat2.Prelievo(Convert.ToDouble(numericUpDown1.Value));
            label5.Text = Convert.ToString(conto2.Saldo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bancomat2.Deposito(Convert.ToDouble(numericUpDown1.Value));
            label5.Text = Convert.ToString(conto2.Saldo);
        }

    }
       
    
}
