using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace EsercitaTowers
{
    public partial class Form1 : Form
    {
        private Bancomat bancomat;
        private Conto conto;
        public Form1()
        {
            InitializeComponent();
            conto = new Conto("Yunjie", "Mediolanum", 600);
            bancomat = new Bancomat("12347654239", "177", conto);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(conto.Saldo);
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
    }
}
