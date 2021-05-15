using System;

namespace interfaces_
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("DOSYA LOG YAZAR");
        }
    }
}