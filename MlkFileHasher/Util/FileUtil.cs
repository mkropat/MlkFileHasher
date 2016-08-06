using System;
using System.IO;

namespace MlkFileHasher.Util
{
    public static class FileUtil
    {
        public static FileInfo ReadFileInfo(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new InvalidFilePath("Select a file");

            if (Directory.Exists(path))
                throw new InvalidFilePath("Path is a directory");

            FileInfo fi;
            try
            {
                fi = new FileInfo(path);
            }
            catch (Exception ex)
            {
                throw new InvalidFilePath(ex.Message);
            }

            if (!fi.Exists)
                throw new InvalidFilePath("Path does not exist");

            try
            {
                using (fi.OpenRead()) { }
            }
            catch (Exception ex)
            {
                throw new InvalidFilePath(ex.Message);
            }

            return fi;
        }
    }

    public class InvalidFilePath : Exception
    {
        public InvalidFilePath(string message) : base(message) { }
    }
}
