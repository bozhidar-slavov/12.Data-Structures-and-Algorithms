namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            string path = @"C:\Windows";

            var dirInfo = new DirectoryInfo(path);
            DirectoryTraverse(dirInfo);
        }

        private static void DirectoryTraverse(DirectoryInfo dir)
        {
            try
            {
                FileInfo[] files = dir.GetFiles();
                var result = new StringBuilder();
                foreach (var file in files)
                {
                    if (file.FullName.EndsWith(".exe"))
                    {
                        result.AppendLine(file.FullName);
                    }
                }

                DirectoryInfo[] children = dir.GetDirectories();
                foreach (var child in children)
                {
                    DirectoryTraverse(child);
                }

                Console.WriteLine(result.ToString());
            }
            catch (Exception)
            {
            }
        }
    }
}
