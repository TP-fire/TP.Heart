namespace EasyFiles
{
    public class FileCleaner
    {
        private string path;
        public FileCleaner(string path)
        {
            this.path = path;
        }

        public bool deleteByDay(int day)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo dic = new DirectoryInfo(path);
                var allFile = dic.GetFiles();
                foreach (var file in allFile)
                {
                    if (file.LastWriteTime < DateTime.Now.AddDays(-day))
                    {
                        file.Delete();
                    }
                }
                return true;
            }
            else  return false; 
        }

    }
}