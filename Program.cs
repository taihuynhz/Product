using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();
            FindFileInfo();
        }

        static void WriteFile()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            try
            {
                using (StreamWriter writer = new StreamWriter(File.Open(@"D:\test.txt", FileMode.Create)))
                {
                    {
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Begin Write");

                        writer.WriteLine("Mã sản phẩm");
                        writer.WriteLine("Tên sản phẩm");
                        writer.WriteLine("Hãng sản xuất");
                        writer.WriteLine("Giá");
                        writer.WriteLine("Các mô tả khác");

                        Console.WriteLine("============================================================");
                        Console.WriteLine("End Write");
                        writer.Close();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra lỗi");
            }
        }

        static void ReadFile()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            try
            {
                using (StreamReader reader = new StreamReader(@"D:\test.txt"))
                {
                    List<string> list = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        list.Add(line);
                    }

                    Console.WriteLine("============================================================");
                    Console.WriteLine("Begin Read");
                    Console.WriteLine("============================================================");

                    foreach (string element in list)
                    Console.WriteLine(element);

                    Console.WriteLine("============================================================");
                    Console.WriteLine("End Read");
                    Console.WriteLine("============================================================");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy file");
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra lỗi");
            }         
        }

        static void FindFileInfo()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            try
            {
                using (StreamReader reader = new StreamReader(@"D:\test.txt"))
                {
                    List<string> list = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        list.Add(line);
                    }

                    Console.Write("Nhập thông tin cần tìm: ");
                    string target = Console.ReadLine();

                    if (list.Contains(target))
                    {
                        Console.WriteLine("============================================================");
                        Console.WriteLine($"Tìm thấy \"{target}\" trong test.txt");
                    }
                    else
                    {
                        Console.WriteLine("============================================================");
                        Console.WriteLine($"Không tìm thấy \"{target}\" trong test.txt");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Không tìm thấy file");
            }
            catch (Exception)
            {
                Console.WriteLine("Xảy ra lỗi");
            }
        }
    }   
}
