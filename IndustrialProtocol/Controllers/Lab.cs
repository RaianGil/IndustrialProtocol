using System;
using System.Collections.Generic;
using System.Text;

namespace IndustrialProtocol.Controllers
{
    class Lab
    {
        int count = 0;
        public string get()
        {
            int intVal = count;
            count = 0;
            return intVal.ToString();
        }
        public void push()
        {
            count++;
        }
    }
}
