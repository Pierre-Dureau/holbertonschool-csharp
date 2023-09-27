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
    /// public static void Inverse
    /// </summary>
    /// <param name="filenames"></param>
    public static void Inverse(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            try
            {
                // Read the original image as a byte array
                byte[] imageData = File.ReadAllBytes(filename);

                // Invert the colors of the image
                byte[] invertedData = InvertColors(imageData);

                // Save the inverted image with the "_inverse" suffix
                string outputFilename = $"{Path.GetFileNameWithoutExtension(filename)}_inverse{Path.GetExtension(filename)}";
                File.WriteAllBytes(outputFilename, invertedData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing {filename}: {ex.Message}");
            }
        }
    }

     private static byte[] InvertColors(byte[] imageData)
    {
        byte[] invertedData = new byte[imageData.Length];

        for (int i = 0; i < imageData.Length; i++)
        {
            // Invert each byte (color channel)
            invertedData[i] = (byte)(255 - imageData[i]);
        }

        return invertedData;
    }
}
