
namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ Chuong trinh hien thi cac tap tin trong thu muc ~~~");
            Console.WriteLine("Hay nhap duong dan thu muc: ");
            string? path = Console.ReadLine();
            try
            {
                var items = Directory.EnumerateFileSystemEntries(path);
                
                foreach (string currentFile in items)
                {
                    Console.Write(currentFile.Substring(path.Length+1) + " ");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}