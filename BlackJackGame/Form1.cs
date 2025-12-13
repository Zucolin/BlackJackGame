using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        // ======== VARIÁVEIS DO JOGO ========
        // Manter nomes próximos aos seus originais
        int numerosorteio1 = 0; // valor sorteado mais recente (Player1)
        int numerosorteio2 = 0; // acumulador parcial (Player1) - usado para somar
        int numerosorteio3 = 0; // valor sorteado mais recente (Player2)
        int numerosorteio4 = 0; // acumulador parcial (Player2) - usado para somar

        int numerosfinal1 = 0; // total final Player1
        int numerosfinal2 = 0; // total final Player2

        bool perdeu1Flag = false; // Player1 passou de 21
        bool perdeu2Flag = false; // Player2 passou de 21

        bool parouPlayer1 = false;   // Player1 apertou "Parar" (button2)
        bool parouPlayer2 = false;  // Player2 apertou "Parar" (button3)

        string usuarioganho = "";

        Random r = new Random(); // criar apenas UMA VEZ


        public Form1()
        {
            InitializeComponent();

            // deixar objetos invisíveis ao iniciar (se existirem no form)
            ganhou.Visible = false;
            resetbutton.Visible = false;
            perdeu1.Visible = false;
            perdeu2.Visible = false;

            // garantir textos iniciais
            num1.Text = "0";
            num2.Text = "0";
        }


        // ======== RESETAR O JOGO ========
        public void ResetGame()
        {
            // tornar controles visíveis novamente
            button1.Visible = true;  // botão sortear Player1
            button2.Visible = true;  // botão parar Player1
            num1.Visible = true;
            button3.Visible = true;  // botão parar Player2
            button4.Visible = true;  // botão sortear Player2
            num2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            // esconder mensagens de perdeu e ganhou
            perdeu1.Visible = false;
            perdeu2.Visible = false;
            ganhou.Visible = false;
            resetbutton.Visible = false;

            // reiniciar flags
            perdeu1Flag = false;
            perdeu2Flag = false;
            parouPlayer1 = false;
            parouPlayer2 = false;

            // zerar acumuladores
            numerosorteio1 = 0;
            numerosorteio2 = 0;
            numerosfinal1 = 0;

            numerosorteio3 = 0;
            numerosorteio4 = 0;
            numerosfinal2 = 0;

            // mostrar zeros nos labels/textboxes
            num1.Text = "0";
            num2.Text = "0";

            // limpar nome do vencedor
            usuarioganho = "";
        }


        // ======== JOGADOR 1 - (Button 1) ========
        private void button1_Click(object sender, EventArgs e)
        {
            // se Player1 já parou, não pode sortear mais
            if (parouPlayer1) return;

            // gerar um novo número e somar ao acumulador do jogador 1
            int sorteio = r.Next(1, 11); // 1..9
            numerosorteio1 = sorteio;
            numerosorteio2 += sorteio;   // acumulador

            numerosfinal1 = numerosorteio2; // total atual do jogador 1

            num1.Text = numerosfinal1.ToString();

            // verificar condições
            if (numerosfinal1 == 21)
            {
                usuarioganho = "Jogador 1";
                ganhoujogo();
                return;
            }

            if (numerosfinal1 > 21)
            {
                perdeu1Flag = true;
                perdeu1.Visible = true;

                // se um jogador perde, o outro vence automaticamente
                usuarioganho = "Jogador 2";
                ganhoujogo();
                return;
            }

            // se o outro já perdeu, Player1 ganha automaticamente
            if (perdeu2Flag == true)
            {
                usuarioganho = "Jogador 1";
                ganhoujogo();
                return;
            }
        }


        // ======== JOGADOR 1 - PARAR (Button 2) ========
        private void button2_Click(object sender, EventArgs e)
        {
            parouPlayer1 = true;

            // se os dois já pararam, comparar resultados
            if (parouPlayer1 && parouPlayer2)
            {
                CompararResultados();
            }
        }



        // ======== JOGADOR 2 - (Button 4) ========
        private void button4_Click(object sender, EventArgs e)
        {
            // se Player2 já parou, não pode sortear mais
            if (parouPlayer2) return;

            // gerar um novo número e somar ao acumulador do jogador 2
            int sorteio = r.Next(1, 11); // 1..9
            numerosorteio3 = sorteio;
            numerosorteio4 += sorteio; // acumulador

            numerosfinal2 = numerosorteio4; // total atual do jogador 2

            num2.Text = numerosfinal2.ToString();

            // verificar condições
            if (numerosfinal2 == 21)
            {
                usuarioganho = "Jogador 2";
                ganhoujogo();
                return;
            }

            if (numerosfinal2 > 21)
            {
                perdeu2Flag = true;
                perdeu2.Visible = true;

                // se um jogador perde, o outro vence automaticamente
                usuarioganho = "Jogador 1";
                ganhoujogo();
                return;
            }

            // se o outro já perdeu, Player2 ganha automaticamente
            if (perdeu1Flag == true)
            {
                usuarioganho = "Jogador 2";
                ganhoujogo();
                return;
            }
        }


        // ======== JOGADOR 2 - PARAR (Button 3) ========
        private void button3_Click(object sender, EventArgs e)
        {
            parouPlayer2 = true;

            // se os dois já pararam, comparar resultados
            if (parouPlayer1 && parouPlayer2)
            {
                CompararResultados();
            }
        }



        // ======== COMPARAR QUEM FICOU MAIS PERTO DE 21 ========
        public void CompararResultados()
        {
            // Se ambos passaram de 21, empate/nenhum (já tratamos perdas antes)
            bool p1Valido = numerosfinal1 <= 21;
            bool p2Valido = numerosfinal2 <= 21;

            if (!p1Valido && !p2Valido)
            {
                usuarioganho = "Empate";
                ganhoujogo();
                return;
            }

            if (p1Valido && !p2Valido)
            {
                usuarioganho = "Jogador 1";
                ganhoujogo();
                return;
            }

            if (!p1Valido && p2Valido)
            {
                usuarioganho = "Jogador 2";
                ganhoujogo();
                return;
            }

            // Ambos válidos (<=21) -> quem estiver mais perto de 21 vence
            int diff1 = 21 - numerosfinal1;
            int diff2 = 21 - numerosfinal2;

            if (diff1 < diff2)
                usuarioganho = "Jogador 1";
            else if (diff2 < diff1)
                usuarioganho = "Jogador 2";
            else
                usuarioganho = "Empate";

            ganhoujogo();
        }



        // ======== MOSTRAR VITÓRIA (com delay para você ver os números) ========
        public async void ganhoujogo()
        {
            // esperar para permitir ver os números antes de esconder os controles
            await Task.Delay(1000); // 1000ms = 1 segundo (mude se quiser)

            // esconder controles de jogo
            button1.Visible = false;
            button2.Visible = false;
            num1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            num2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            perdeu1.Visible = false;
            perdeu2.Visible = false;

            // exibir resultado final
            if (usuarioganho == "Empate")
                ganhou.Text = "Empate!";
            else
                ganhou.Text = usuarioganho + " Ganhou!";

            ganhou.Visible = true;
            resetbutton.Visible = true;
        }


        // ======== RESET BUTTON CLICK ========
        private void resetbutton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
