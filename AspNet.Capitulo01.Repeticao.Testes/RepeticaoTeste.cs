using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.Repeticao.Testes {
    [TestClass]
    public class RepeticaoTeste {
        [TestMethod]
        public void TabuadaTeste() {

            for(int i = 0; i <=10; i++) {
                for(int j=0;j<=10; j++) {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 50));
                Console.WriteLine();
            }

        }

        [TestMethod]
        public void EstruturaForTeste() {
            int i = 1;
            // o for só vai rodar 1 vez assim
            for(Console.WriteLine("Iniciou");i<=3; Console.WriteLine(i)) { i++; }

            /*
             for(1.inicialização; 2. Criterio; 4. Pós-execução ){
                3.Execução
             }
             */
        }

        [TestMethod]
        public void ForApenasComCondicaoTeste() {
            int i = 1;

            for (;i<=3;) {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste() {

            for (int i = 0; i <= 10; i++) {
                if (i < 6)
                    continue; // continue faz voltar para o for

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste() {

            for (int i = 0; i <= 10; i++) {
                if (i >= 6)
                    break; // continue faz voltar para o for

                Console.WriteLine(i);
            }
        }

    }
}
