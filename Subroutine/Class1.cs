using SharpCompress.Common;
using System;

namespace Subroutine
{
    public class Class1
    {
        public void Run()
        {
            try
            {
                var archiveEncoding = new ArchiveEncoding();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
