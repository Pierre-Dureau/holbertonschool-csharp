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
    /// Inverse the color of images
    /// </summary>
    /// <param name="filenames"> The names of all images </param>
    public static void Inverse(string[] filenames)
    {
        foreach (var filename in filenames)
        {
            string baseName = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            byte[] imageData = File.ReadAllBytes(filename);
            byte[] invertedData = new byte[imageData.Length];

            for (int i = 0; i < imageData.Length; i++)
            {
                invertedData[i] = (byte)(255 - imageData[i]);
            }
            File.WriteAllBytes($"{baseName}_inverse{extension}", invertedData);
        }
    }
}
