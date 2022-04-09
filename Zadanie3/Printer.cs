using System;
using System.Collections.Generic;
using System.Text;

namespace ver3
{
    class Printer: BaseDevice, IPrinter
    {
        public int PrintCounter = 0;
        public void Print(in IDocument document)
        {
            if (state == IDevice.State.on)
            {
                PrintCounter += 1;
                Console.WriteLine(DateTime.Now.ToString() + " Print: " + document.GetFileName());
            }
        }
    }
}
