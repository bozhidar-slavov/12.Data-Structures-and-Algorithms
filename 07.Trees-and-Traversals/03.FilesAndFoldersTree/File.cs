﻿namespace FilesAndFoldersTree
{
    public class File
    {
        public File(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }

        public double Size { get; set; }
    }
}
