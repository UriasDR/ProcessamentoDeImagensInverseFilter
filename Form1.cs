using System;
using System.Drawing;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using Accord.Math;

namespace ProcessamentoDeImagensWienerInverso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap img1 = null;
        byte[,] vImg1Gray;

        private void btLoad_A_Click(object sender, EventArgs e)
        {
            

            // Configurações iniciais da OpenFileDialogBox
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Se um arquivo foi localizado com sucesso...
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Armazena o path do arquivo de imagem
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;
                try
                {
                    img1 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                // Se a imagem carregou perfeitamente...
                if (bLoadImgOK == true)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Adiciona imagem na PictureBox
                    pictureBox1.Image = img1;

                    vImg1Gray = new byte[img1.Width, img1.Height];

                    // Percorre todos os pixels da imagem...
                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            // Para imagens em escala de cinza, extrair o valor do pixel com...
                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;
                        }
                    }
                }
            }
        }

        
        private byte[,] ApplyWienerInverseFilter(byte[,] image, double noiseVariance)
        {
            int width = image.GetLength(0);
            int height = image.GetLength(1);

            // Realizar o processamento de filtragem inversa de Wiener
            byte[,] filteredImage = new byte[width, height];

            // Calcula o espectro de potência da imagem original
            double[,] powerSpectrum = CalculatePowerSpectrum(image);

            // Calcula o espectro de potência do ruído
            double noisePower = noiseVariance * (width * height);

            // Aplica o filtro de Wiener inverso
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double wienerCoeff = powerSpectrum[i, j] / (powerSpectrum[i, j] + noisePower);
                    double intensity = image[i, j] / wienerCoeff;
                    filteredImage[i, j] = (byte)Math.Round(intensity);
                }
            }

            return filteredImage;
        }

        private double[,] CalculatePowerSpectrum(byte[,] image)
        {
            int width = image.GetLength(0);
            int height = image.GetLength(1);

            // Nova matriz para calcular o espectro da potência
            double[,] powerSpectrum = new double[width, height];

            // Calcula o espectro de potência como o quadrado do valor de intensidade
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double intensity = image[i, j];
                    powerSpectrum[i, j] = intensity * intensity;
                }
            }

            return powerSpectrum;
        }

        private Bitmap ConvertToBitmap(byte[,] image)
        {
            int width = image.GetLength(0);
            int height = image.GetLength(1);

            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    byte pixelValue = image[i, j];
                    Color pixelColor = Color.FromArgb(pixelValue, pixelValue, pixelValue);
                    bitmap.SetPixel(i, j, pixelColor);
                }
            }

            return bitmap;
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            if (txVariance.Text.Length < 1) txVariance.Text = "0";
            double iVariance = Double.Parse(txVariance.Text);


            // Aplicar o filtro de Wiener inverso na imagem em escala de cinza
            byte[,] filteredImage = ApplyWienerInverseFilter(vImg1Gray, iVariance);

            // Exibir a imagem filtrada na PictureBox
            Bitmap filteredBitmap = ConvertToBitmap(filteredImage);
            pictureBox2.Image = filteredBitmap;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bitmap imagem = (Bitmap)pictureBox2.Image;

            if (imagem != null)
            {
                // Define o caminho do arquivo onde a imagem será salva
                string caminhoArquivo = "C:\\Matlab\\Imagem.Bmp";
                // Salva a imagem no arquivo
                imagem.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Bmp);

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Imagem salva com sucesso!");
            }
            else
            {
                // Exibe uma mensagem de erro se a imagem não estiver definida
                MessageBox.Show("A imagem não está definida!");
            }
        }
    }
}