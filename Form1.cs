using System.Media;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool btnConfirma = true;
        private Dictionary<string, Candidato> _dicCandidato;

        public Form1()
        {
            InitializeComponent();
            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("13", new Candidato() { Id = 13, Nome = "Luiz Ignacio", Partido = "PT", Foto = Properties.Resources.lula });
            _dicCandidato.Add("22", new Candidato() { Id = 22, Nome = "Bolsonaro", Partido = "PL", Foto = Properties.Resources.bolsonaro });

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
             pnFim.Visible = true;
              Limpar();

            SoundPlayer s = new SoundPlayer(Properties.Resources.Clique);
            s.Play();

            timer.Tick += new EventHandler(AcaoFinal);
            timer.Interval = 3000;
            timer.Enabled = true;
            timer.Start();
        }


        private void btnCorrige_Click(object sender, EventArgs e)
        {
            Limpar();
            timer.Stop();
            timer.Enabled = btnConfirma;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPresidente1.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                return;
            }

              pnFim.Visible = true;
             Limpar();
            SoundPlayer s = new SoundPlayer(Properties.Resources.Voto);
            s.Play();

            timer.Tick += new EventHandler(AcaoFinal);
            timer.Interval = 3000;
            timer.Enabled = true;
            timer.Start();

        }

        private void AcaoFinal(Object myObject, EventArgs myEventArgs)
        {
            timer.Stop();
            timer.Enabled = false;
            pnFim.Visible = false;
        }

        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(txtPresidente1.Text))
                txtPresidente1.Text = digito;
            else
            {
                txtPresidente2.Text = digito;
                PreencherCandidato(txtPresidente1.Text, txtPresidente2.Text);
            }

            SoundPlayer s = new SoundPlayer(Properties.Resources.Clique);
            s.Play();
        }

        private void PreencherCandidato(string d1, string d2)
        {
            if (_dicCandidato.ContainsKey(d1 + d2))
            {
                lblNome.Text = _dicCandidato[d1 + d2].Nome;
                lblPartido.Text = _dicCandidato[d1 + d2].Partido;
                picFoto.Image = _dicCandidato[d1 + d2].Foto;
            }
            else
            {
                MessageBox.Show("Candidato não encontrado!");
            }
        }

        private void Limpar()
        {
            txtPresidente1.Text = "";
            txtPresidente2.Text = "";
            lblNome.Text = String.Empty;
            lblPartido.Text = String.Empty;
            picFoto.Image = null;
        }

        private void pnFim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDigitar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Candidato
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public Image Foto { get; set; }
    }
}