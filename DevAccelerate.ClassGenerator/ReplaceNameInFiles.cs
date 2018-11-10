using System;
using System.IO;

namespace DevAccelerate.Net
{
    public static class ReplaceNameInFiles
    {
        public static void Replace(string path, string txtOriginal, string txtNew)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach(FileInfo file in di.GetFiles())
            {
                string newName = file.Name.Replace(txtOriginal, txtNew);
                string newFullPath = Path.Combine(di.FullName, newName);
                file.MoveTo(newFullPath);
            }
        }
    }
}
