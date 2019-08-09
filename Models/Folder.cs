using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Folder
    {
        public string Name { get; set; }
        public string DateCreated { get; set; }
        public List<File> Files { get; set; }
        public List<Folder> Children { get; set; }

        public Folder(FileSystemInfo fsi)
        {
            Name = fsi.Name;
            Children = new List<Folder>();
            Files = new List<File>();
            DateCreated = fsi.CreationTime.ToString("dd MMMM yyyy hh:mm tt");
            foreach (FileSystemInfo f in (fsi as DirectoryInfo).GetFileSystemInfos())
            {

                if (f.Attributes == FileAttributes.Directory)
                    Children.Add(new Folder(f));
                else
                {
                    Files.Add(new File(f));
                }
            }
        }
    }
}
