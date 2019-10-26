using System;
using System.Windows.Forms;

namespace Ex01_ImpactaAspNet.Capitulo01.Variaveis {
    public partial class VariaveisForm : Form {

        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;

        public VariaveisForm() {
            InitializeComponent();

        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e) {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;

            string nome = "Daniel";

            var m = (decimal)20.50;

            DateTime hoje = DateTime.Now;
            DateTime dateTime = new DateTime(1993, 03, 06);


            resultadoListBox.Items.Add(string.Format("a = {0}", a));

            resultadoListBox.Items.Add(string.Concat("b = ", b));

            resultadoListBox.Items.Add(string.Format("c = {0}", c));

            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add("-----------------");

            resultadoListBox.Items.Add($"c * d = {d * c}");

            resultadoListBox.Items.Add($"d / a = {d / a}");

            resultadoListBox.Items.Add($"d % d = {d % a}");
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e) {
            var x = 5;
            resultadoListBox.Items.Add($"x = {x}");

            x -= 3;
            resultadoListBox.Items.Add($"x = {x}");




        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < 9; i++)
                resultadoListBox.Items.Add($"x = {i}");
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e) {

            x = 32;
            y = 16;
            w = 45;
            z = 32;

            DescricaoVariaveis();

            resultadoListBox.Items.Add($"w <= x = {w <= x}");

            resultadoListBox.Items.Add($"x == z = {x == z}");

            resultadoListBox.Items.Add($"x != z = {x != z}");


        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e) {
/*          x = 32;
            y = 16;
            w = 45;
            z = 32; */

            DescricaoVariaveis();

            resultadoListBox.Items.Add($"w <= x  || y == 16 = {w <= x || y == 16}");

            resultadoListBox.Items.Add($"x == z  && z != x = {x == z && z != x}");

            resultadoListBox.Items.Add($"!(y > w) {!(y > w)}");
        }

        private void DescricaoVariaveis() {

            resultadoListBox.Items.Clear();

            resultadoListBox.Items.Add($"x = {x}");

            resultadoListBox.Items.Add($"y = {y}");

            resultadoListBox.Items.Add($"w = {w}");

            resultadoListBox.Items.Add($"z = {z}");

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void ternarioToolStripMenuItem_Click(object sender, EventArgs e) {
            int ano = 2014;

            resultadoListBox.Items
                .Add($"O ano {ano} é bissexto? {(ano%4==0?"Sim":"Não")}");


            ano = 2020;
            resultadoListBox.Items
                .Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}");
        }
    }
}
