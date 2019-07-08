using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfOOP
{
    class Program
    {
        //static double MyNexDouble(Random rnd, double min, double max)
        //{
        //    return rnd.NextDouble() * (max - min) + min;
        //}

        static void Main(string[] args)
        {
            //    foreach (var file in Directory.GetFiles("\\"))
            //        Console.WriteLine(file);
            //    Console.WriteLine(Directory.GetParent("."));

            //    var directoryInfo = new DirectoryInfo(".");
            //    foreach (var file in directoryInfo.GetFiles())
            //        Console.WriteLine(file.Name);
            //    directoryInfo = directoryInfo.Parent;
            //    Console.WriteLine(directoryInfo.FullName);


            //var rnd = new Random();
            //Console.WriteLine(MyNexDouble(rnd, 10, 20));
            //Console.WriteLine(rnd.NextDouble(10, 20));
            //var array = new int[] { 1, 2, 3, 4, 5 };
            //array.Swap(0, 1);

            //char a1 = '4';
            //char a2 = '7';
            //Console.WriteLine(a2 - a1);
            //"42".ToInt();

            //var arg1 = "100500";
            //Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
            List<FileInfo> files = new List<FileInfo>();
            files.Add(new FileInfo("\\A\\1.mp3"));
            files.Add(new FileInfo("\\B\\2.mp3"));
            files.Add(new FileInfo("\\A\\3.mp3"));
            List<DirectoryInfo> dirInfo = GetAlbums(files);

            // files.Add("\\A\\1.mp3");


            Console.ReadKey();
        }
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {
            List<DirectoryInfo> listDirInfo = new List<DirectoryInfo>();
            foreach (var dir in files)
            {

                if (!listDirInfo.Contains(dir.Directory))
                    listDirInfo.Add(dir.Directory);
            }
            return listDirInfo;
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                result += (str[str.Length - i - 1] - '0') * (int)Math.Pow(10, i);
            }
            return result;
        }
    }

    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }

    public static class ArrayExtensions
    {
        public static void Swap(this int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}
