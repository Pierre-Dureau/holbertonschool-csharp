using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

/// <summary>
/// ImageProcessor class
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Call the InvertColors for all image with parallelisme
    /// </summary>
    /// <param name="filenames"> The names of all images </param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, (filename) => InvertColors(filename));
    }

    /// <summary>
    /// Invert the color of an image
    /// </summary>
    /// <param name="filename"> The name of the image </param>
    static void InvertColors(string filename)
    {
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
    }
}
