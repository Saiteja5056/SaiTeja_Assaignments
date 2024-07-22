using System.IO;
namespace D16
{
    internal class Program
    {
        public void create(string fpath)
        {
            File.Create(fpath);
        }
        public void read(string fpath)
        {
            string content=File.ReadAllText(fpath);
            Console.WriteLine(content);
        }
        public void write(string fpath)
        {
            string content = "welcome to file handling";
            File.AppendAllText(fpath,Environment.NewLine+content);
        }
        static void Main(string[] args)
        {
            string fpath = Console.ReadLine();
            Program p=new Program();
            p.write(fpath);
          p.read(fpath);
        }
    }
}
