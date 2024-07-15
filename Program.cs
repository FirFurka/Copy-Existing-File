using System.Windows.Forms;

namespace CopyAFile
{
    internal class CopyAFile
    {
        private static void Main(string[] args)
        {
            string sourceFile = Application.ExecutablePath.ToString();
            File.Copy(sourceFile, @"D:\GitHub\FileCopy\copyTesting.exe");
        }
    }
}