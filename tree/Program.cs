using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tree
{
    class Program
    {static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            while (true)
            {
                string[] dirs = null;
                Console.WriteLine("Ффедите путь к фифектории:");
                Console.Write(">");
                string dirName = Console.ReadLine();
                

                if (dirName == "exit")
                {
                    break;
                }

                if (Directory.Exists(dirName))
                {
                    
                    try
                    {
                        dirs = Directory.GetFileSystemEntries(dirName, "*", SearchOption.AllDirectories);
                    }
                    catch
                    {
                        Console.WriteLine("Unauthorized Access. Ошибка доступа к файлу/папке. Требуется больше прав... или хотябы золота.\n");
                        continue;
                    }
                    Array.Sort(dirs, StringComparer.CurrentCulture);

                    for (int k = 0; k < dirs.Length; k++)
                    {
                        string text = dirs[k];
                        string text_1 = null;
                        string text_2 = null;
                        int index_c = 0;
                        int count_1 = 0;
                        for (int j = 0; j < text.Length; j++)
                        {
                            int result = String.Compare(Convert.ToString(text[j]), "\u005C");
                            if (result == 0)
                            {
                                count_1++;
                                if (count_1 > 2)
                                {
                                    text_1 = $"{text_1}" +" |";
                                }
                            }
                        }
                        
                        index_c = text.LastIndexOf('\u005C');
                        text_2 = text.Substring(index_c + 1);

                        dirs[k] = String.Concat(text_1, " |>", text_2);
                        Console.WriteLine(dirs[k]);

                    }

                }
                else
                {
                    Console.WriteLine("Фифектория не фуфестфует.\n");
                }
            }
            Console.Write("Печать сколько-нибудь ключ до простираться ...");
            Console.ReadLine();
        }
    }    
}

