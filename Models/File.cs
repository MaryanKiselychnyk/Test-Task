using System.IO;

namespace Test
{
    class File
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }

        public File(FileSystemInfo fsi)
        {
            FileInfo f = new FileInfo(fsi.FullName);
            Name = fsi.Name;
            Size = f.Length;
            Path = fsi.FullName;
        }
    }
}
