using System;
using System.IO;

namespace Command
{
    public class Kernel
    {
        public void DirListAPI(string path)
        {
            if (path == string.Empty)
            {
                Console.WriteLine("ListCommand requires a valid path!");
            }
            else
            {
                string[] files = Directory.GetFiles(path);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }
        }
        public void MkDirAPI(string path)
        {
            Directory.CreateDirectory(path);
        }
        public void DeleteAPI(string path)
        {
            Directory.Delete(path);
        }

        public void QuitAPI()
        {
            Console.WriteLine("---- FreeCSD ----");
            Environment.Exit(0);
        }
    }
}
