using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Main : Form
    {
        private bool flagPìntar = false;
        private bool flagApagar = false;
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private Image imagemSalvar;
        private Graphics graphicsImagem;

        public Main()
        {
            InitializeComponent();

            for (int espessura = 2; espessura <= 100; espessura += 2) comboBoxEspessuraDaCaneta.Items.Add(espessura);
            comboBoxEspessuraDaCaneta.Text = "10";
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 4;
            comboBoxEspessuraDaCaneta.IntegralHeight = false;

            graphicsPainelPintura = panelPintura.CreateGraphics();
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text);
            corBorracha = panelPintura.BackColor;

            imagemSalvar = new Bitmap(panelPintura.Width, panelPintura.Height);
            graphicsImagem = Graphics.FromImage(imagemSalvar);
            graphicsImagem.Clear(panelPintura.BackColor);
        }

        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var corEscolhida = colorDialog.ShowDialog();
            
            if (corEscolhida == DialogResult.OK)
            {
                buttonCorCaneta.BackColor = colorDialog.Color;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPìntar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPìntar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPìntar)
            {
                if (!flagApagar)
                {
                    graphicsPainelPintura
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    graphicsImagem
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                    graphicsImagem
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar tudo?", "Apagar desenho", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                graphicsPainelPintura.Clear(Color.White);
                imagemSalvar = new Bitmap(panelPintura.Width, panelPintura.Height);
                graphicsImagem = Graphics.FromImage(imagemSalvar);
            }
        }

        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color;
                }
            }
            else
            {
                flagApagar = !flagApagar;
                if (flagApagar) 
                    buttonBorracha.BackColor = corBorracha;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch(saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;

                    case 2:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void panelPintura_Resize(object sender, EventArgs e)
        {
            var imagemTemp = new Bitmap(panelPintura.Width, panelPintura.Height);
            var graphicsTemp = Graphics.FromImage(imagemTemp);
            
            graphicsPainelPintura = panelPintura.CreateGraphics();
            
            graphicsTemp.DrawImage(imagemSalvar, 0, 0);
            imagemSalvar = imagemTemp;
            graphicsImagem = graphicsTemp;
        }
    }
}
