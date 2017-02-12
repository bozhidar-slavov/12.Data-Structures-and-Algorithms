namespace FilesAndFoldersTree
{
    using System;
    using System.IO;

    public class Startup
    {
        public static void Main()
        {
            string path = "C:\\Windows";

            var folder = new Folder(new DirectoryInfo(path).Name);
            TraverseDir(new DirectoryInfo(path), folder);

            double folderSize = TraverseSizeDir(new DirectoryInfo(path));
            Console.WriteLine($"Folder C files size: {folderSize} bytes");

            // TraverseFolder(folder);
        }

        private static void TraverseFolder(Folder newFolder)
        {
            try
            {
                var files = newFolder.Files;
                foreach (var file in files)
                {
                    Console.WriteLine($"{file.Name}=>{file.Size}");
                }

                var children = newFolder.ChildFolders;
                foreach (var child in children)
                {
                    TraverseFolder(child);
                }
            }
            catch (Exception)
            {
            }
        }

        private static long TraverseSizeDir(DirectoryInfo directoryInfo)
        {
            long sum = 0;
            try
            {
                DirectoryInfo[] children = directoryInfo.GetDirectories();
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    sum += (file.Length);
                }
                foreach (DirectoryInfo child in children)
                {
                    sum += TraverseSizeDir(child);
                }
            }
            catch (Exception)
            {
            }
            return sum;
        }

        private static void TraverseDir(DirectoryInfo dir, Folder newFolder)
        {
            try
            {
                DirectoryInfo[] children = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                newFolder.Name = dir.FullName;
                foreach (var file in files)
                {
                    newFolder.Files.Add(new File(file.Name, file.Length));
                }
                foreach (var child in children)
                {
                    Folder folder = new Folder(child.Name);
                    TraverseDir(child, folder);
                    newFolder.ChildFolders.Add(folder);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
