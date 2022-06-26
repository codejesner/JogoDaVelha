namespace JogodaVelha
{
    public partial class App : Form
    {
        Jogo jogo = new Jogo();
        public App()
        {
            InitializeComponent();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Mostrar(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Mostrar(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Mostrar(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Mostrar(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Mostrar(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Mostrar(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Mostrar(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Mostrar(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Mostrar(btn9);
        }

        // Mostrar X ou O quando o jogador clicar.
        private void Mostrar(Control botao)
        {
            if (botao.Text == "")
            {
                botao.Text = jogo.Marcar();
                Verificar();
                if (jogo.JogadorAtual == 0)
                {
                    lblJogadorAtual.Text = "Vez de: X";
                }
                else
                {
                    lblJogadorAtual.Text = "Vez de: O";
                }
            }
        }
        // Adiciona ponto ao campeao
        private void Ganhador(string ganhador)
        {
            if (ganhador == "X")
            {
                lblX.Text = "X: " +jogo.pontoX().ToString();
                MessageBox.Show("X foi o ganhador");
            }
            else
            {
                lblO.Text = "O: " + jogo.pontoO().ToString();
                MessageBox.Show("O foi o ganhador");
            }
        }
        // Verificar o ganhar
        private void Verificar()
        {
            // Verificando os campos Horizontais
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                Ganhador(btn1.Text);
                Limpar();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                Ganhador(btn4.Text);
                Limpar();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                Ganhador(btn7.Text);
                Limpar();
            }
            // Verificando os campos Verticais
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                Ganhador(btn1.Text);
                Limpar();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                Ganhador(btn2.Text);
                Limpar();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                Ganhador(btn3.Text);
                Limpar();
            }
            // Verificando os campos Diagonais
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                Ganhador(btn1.Text);
                Limpar();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                Ganhador(btn3.Text);
                Limpar();
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                MessageBox.Show("Empate!");
                Limpar();
            }
        }
        private void Limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        /*
        private void interval_Tick(object sender, EventArgs e)
        {
            
        }
        */
    }
}