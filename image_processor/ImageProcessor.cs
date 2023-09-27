using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// ImageProcessor class
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Inverse the color of each image
    /// </summary>
    /// <param name="filenames"> The images </param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (filename) => {
            string baseName = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            Bitmap original = new Bitmap(filename);
            int width = original.Width;
            int height = original.Height;

            Bitmap inverted = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        255 - originalColor.R,
                        255 - originalColor.G,
                        255 - originalColor.B
                    );

                    inverted.SetPixel(x, y, invertedColor);
                }
            }

            inverted.Save($"{baseName}_inverse{extension}");

            original.Dispose();
            inverted.Dispose();
        });
    }

    /// <summary>
    /// Converts each image to grayscale
    /// </summary>
    /// <param name="filenames"> The images </param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, (filename) => {
            string baseName = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            Bitmap original = new Bitmap(filename);
            int width = original.Width;
            int height = original.Height;

            Bitmap grayscale = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int grayValue = (originalColor.R + originalColor.G + originalColor.B) / 3;
                    Color grayscaleColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    grayscale.SetPixel(x, y, grayscaleColor);
                }
            }

            grayscale.Save($"{baseName}_grayscale{extension}");

            original.Dispose();
            grayscale.Dispose();
        });
    }

    /// <summary>
    /// Reduces each image to only black and white
    /// </summary>
    /// <param name="filenames"> The images </param>
    /// <param name="threshold"> Define if the pixel is black or white with his luminance </param>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, (filename) => {
            string baseName = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            Bitmap original = new Bitmap(filename);
            int width = original.Width;
            int height = original.Height;

            Bitmap blackAndWhite = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int luminance = (int)(0.299 * originalColor.R + 0.587 * originalColor.G + 0.114 * originalColor.B);
                    if (luminance > threshold)
                        blackAndWhite.SetPixel(x, y, Color.White);
                    else
                        blackAndWhite.SetPixel(x, y, Color.Black);
                }
            }

            blackAndWhite.Save($"{baseName}_bw{extension}");

            original.Dispose();
            blackAndWhite.Dispose();
        });
    }

    /// <summary>
    /// Creates each thumbnail image base on a given height
    /// </summary>
    /// <param name="filenames"> The images </param>
    /// <param name="newHeight"> The new height </param>
    public static void Thumbnail(string[] filenames, int newHeight)
    {
        Parallel.ForEach(filenames, (filename) => {
            string baseName = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            Bitmap original = new Bitmap(filename);
            int width = original.Width;
            int height = original.Height;

            int newWidth = (int)((double)width * newHeight / height);
            Bitmap resized = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, 0, 0, newWidth, newHeight);
            }

            resized.Save($"{baseName}_th{extension}");

            original.Dispose();
            resized.Dispose();
        });
    }
}
