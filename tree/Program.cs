using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1)
            {
                Console.Write(">");
                string dirName = Console.ReadLine();

                if (dirName == "exit")
                {
                    i = 1;
                }

                if (Directory.Exists(dirName))
                {
                    string[] dirs = Directory.GetFileSystemEntries(dirName, "*", SearchOption.AllDirectories);
                    Array.Sort(dirs, StringComparer.CurrentCulture);

                    for (int k = 0; dirs.Length > k; k++)
                    {
                        string text = dirs[k];

                        Console.WriteLine(dirs[k]);
                    }

                    foreach (string s in dirs)

                    {
                        Console.WriteLine(s);
                    }


                }
            }
            Console.Write("Печать сколько-нибудь ключ до простираться ...");
            Console.ReadLine();
        }
    }    
}
/*var dirs = Directory.EnumerateFiles(dirName, "*", SearchOption.AllDirectories);*/
