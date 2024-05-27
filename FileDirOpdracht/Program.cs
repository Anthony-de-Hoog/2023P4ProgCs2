namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DirectoryInfo dir = new DirectoryInfo(@"C:\school-backup\ma\bewijzenmap\p1.4\2023P4ProgCs2\2023P4ProgCs2.csproj"); 
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine(file.FullName);
            }
            foreach (DirectoryInfo file in dir.GetDirectories()) 
            {
                Console.WriteLine(dir.FullName);
            }
        }
    }
}
