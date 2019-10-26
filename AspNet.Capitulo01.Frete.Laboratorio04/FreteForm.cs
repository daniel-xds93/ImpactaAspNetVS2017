using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNet.Capitulo01.Frete.Laboratorio04 {
    public partial class FreteForm : Form {
        public FreteForm() {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void calcularButton_Click(object sender, EventArgs e) {
             var erros = ValidarFormulario();

            if (erros.Count == 0)
                Calcular();
            else
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        public void Calcular() {

            decimal percentual = 0.0M;
            decimal valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string> { "BA", "AL", "CE" };

            switch (ufComboBox.Text) {
                case "SP":
                    percentual = 0.2M; break;
                case "RJ":
                case "ES":
                    percentual = 0.3M; break;
                case "MG":
                    percentual = 0.35M;break;
                case "AM":
                    percentual = 0.6M; break;

                case var uf when nordeste.Contains(uf):
                    percentual = 0.4M; break;

                default:
                    percentual = 0.7M; break;

            }

            // p2 indica que o valor é porcentagem
            freteTextBox.Text = percentual.ToString("p2");


            totalTextBox.Text = (valor += valor * percentual).ToString();
        }

        public List<string> ValidarFormulario() {

            var erros = new List<string>();

            if (string.IsNullOrEmpty(clienteTextBox.Text))
                erros.Add("O campo Cliente é obrigatório!"); ;
            if (ufComboBox.SelectedIndex == -1)
                erros.Add("Selecione a UF");
            if (string.IsNullOrWhiteSpace(valorTextBox.Text))
                erros.Add("Informe o valor");
            else {
                if(!decimal.TryParse(valorTextBox.Text.Trim(), out decimal valorConvertido)){
                    erros.Add("O campo valor deve ser númerico!");
                }
            }

            return erros;
       
        }

        private void limparButton_Click(object sender, EventArgs e) {
      //      ufComboBox.Text
        }
    }
}
