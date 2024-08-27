namespace ProxyPattern.Protection
{
    public class FileProcessProxy : IFileProcess
    {
        private IFileProcess _fileProcess;
        private bool _isAuthorized;

        public FileProcessProxy(IFileProcess fileProcess, bool isAuthorized)
        {
            _fileProcess = fileProcess;
            _isAuthorized = isAuthorized;
        }

        public void DeleteFile(string filePath)
        {
            if (_isAuthorized)
            {
                _fileProcess.DeleteFile(filePath);
            }
            else
            {
                Console.WriteLine("Yetkisiz kullanıcı, dosya silinemedi.");
            }
        }
    }
}
