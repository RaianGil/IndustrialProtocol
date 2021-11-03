using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndustrialProtocol.Controllers
{
    class File
    {
        public static FileStream get = new FileStream(@"C:\app\SimuFile.txt", FileMode.Open);
    }
}
