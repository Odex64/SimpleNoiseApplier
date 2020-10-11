using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoiseApplier
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //METHODS
        public static Bitmap resizeImage(Image bmp, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / bmp.Width;
            double ratioY = (double)maxHeight / bmp.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(bmp.Width * ratio);
            int newHeight = (int)(bmp.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            Graphics graphics = Graphics.FromImage(newImage);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);
            graphics.Dispose();

            return newImage;
        }

        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        public static string RGBtoText(Color input)
        {
            return input.R.ToString() + ", " + input.G.ToString() + ", " + input.B.ToString();
        }
        //END

        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Select your image",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "PNG Files (*.png)|*.png",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PicSize.Text = Image.FromFile(dialog.FileName).Width.ToString() + ',' + Image.FromFile(dialog.FileName).Height.ToString();
                original = Image.FromFile(dialog.FileName);
                Original.Image = resizeImage(original, 360, 360);
                if (NewImage.Image != null)
                    NewImage.Image = null;

                ImageColors.Items.Clear();
                ColorPreview.BackColor = Color.Transparent;
                Bitmap img = new Bitmap(Original.Image);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        if (!ImageColors.Items.Contains(RGBtoText(img.GetPixel(x, y))))
                        {
                            ImageColors.Items.Add(RGBtoText(img.GetPixel(x, y)));
                        }
                    }
                }
                img.Dispose();
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (NewImage.Image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Title = "Save your image",
                    CheckPathExists = true,
                    Filter = "PNG Files (*.png)|*.png",
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    edited.Save(dialog.FileName);
                }
            }
        }

        Image original = null;
        Bitmap edited = null;
        private void ApplyNoise(object sender, MouseEventArgs e)
        {
            if (original != null)
            {
                edited = new Bitmap(original);
                Random rnd = new Random();
                for (int x = 0; x < edited.Width; x++)
                {
                    for (int y = 0; y < edited.Height; y++)
                    {
                        Color pixel = edited.GetPixel(x, y);
                        if (!IgnoredColors.Items.Contains(RGBtoText(pixel)) && rnd.Next(101) <= Range.Value)
                        {
                            if (pixel.GetBrightness() < 0.5)
                                edited.SetPixel(x, y, ChangeColorBrightness(pixel, (float)(Intensity.Value * -1)));
                            else
                                edited.SetPixel(x, y, ChangeColorBrightness(pixel, (float)Intensity.Value));
                        }
                    }
                }
                NewImage.Image = resizeImage(edited, 360, 360);
            }
        }

        private void RemovedIgnored(object sender, MouseEventArgs e)
        {
            if (IgnoredColors.SelectedItem != null)
            {
                IgnoredColors.Items.Remove(IgnoredColors.SelectedItem);
            }
        }

        private void AddedIgnored(object sender, MouseEventArgs e)
        {
            if (ImageColors.SelectedItem != null)
            {
                if (!IgnoredColors.Items.Contains(ImageColors.SelectedItem))
                {
                    IgnoredColors.Items.Add(ImageColors.SelectedItem);
                }
            }
        }

        private void DisplayColor(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
            {
                int[] temp = new int[3];
                string[] color = ((ListBox)sender).SelectedItem.ToString().Split(',');
                for (int i = 0; i < 3; i++)
                    temp[i] = int.Parse(color[i]);
                ColorPreview.BackColor = Color.FromArgb(temp[0], temp[1], temp[2]);
            }
        }

        private void ConvertFolder(object sender, EventArgs e)
        {
            Random rnd = new Random();
            FolderBrowserDialog browse = new FolderBrowserDialog();
            if (browse.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(browse.SelectedPath))
            {
                foreach (string file in Directory.GetFiles(browse.SelectedPath))
                {
                    if (Path.GetExtension(file) == ".png")
                    {
                        Bitmap img = new Bitmap(file);
                        for (int x = 0; x < img.Width; x++)
                        {
                            for (int y = 0; y < img.Height; y++)
                            {
                                Color pixel = img.GetPixel(x, y);
                                if (!IgnoredColors.Items.Contains(RGBtoText(pixel)) && rnd.Next(101) <= Range.Value)
                                {
                                    if (pixel.GetBrightness() <= 0.5)
                                        img.SetPixel(x, y, ChangeColorBrightness(pixel, (float)(Intensity.Value * -1)));
                                    else
                                        img.SetPixel(x, y, ChangeColorBrightness(pixel, (float)Intensity.Value));
                                }
                            }
                        }
                        img.Save(file.Substring(0, file.LastIndexOf(".png")) + "-Noise.png");
                        img.Dispose();
                    }
                }
            }
        }

        private void PickCustomColor(object sender, MouseEventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Black;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                IgnoredColors.Items.Add(RGBtoText(colorDlg.Color));
            }
        }
    }
}
