using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSSchool.Events
{
    public delegate void OnOut(string message,string path="");
    internal class OnOutConsole
    {
        public static OnOut? OnOut;
    }
}
