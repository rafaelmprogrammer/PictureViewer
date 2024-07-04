/*Aplicação de vizualisação de imagens*/

namespace PictureViewerApp
{
    /*Componente principal onde aparecem os botões para imagens e cores de fundo*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Inicialização dos componentes de interface*/
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*Método para click no botão de adicionar uma imagem*/
        private void showButton_Click(object sender, EventArgs e)
        {
            // Mostra a janela de abrir arquivos e onde o utilizador por clicar no ok e carrgar uma imagem
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
        /*Método para limpar a imagem carregada*/
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Elimina a imagem
            pictureBox1.Image = null;
        }

        /*Método para click no botão de alterar a cor de background*/
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Se o utilizador clicar aparece um quadro com opções de cores para o background
            //se clicar em ok a cor de background altera para o que o utilizador escolher 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            this.Close();
        }

        /*Método para fazer strech  da imagem*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Se o utilizador clicar na check box a PictureBox altera para o SizeMode para strech.
            //Se o utilizador retirar a opção da check box as definições do SizeMode passam para normal 
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        /*Método para eliminar a cor de background*/
        private void clearBackground_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = clearBackground.BackColor;

        }
    }
}
