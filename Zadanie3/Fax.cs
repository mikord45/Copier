using System;
using System.Collections.Generic;
using System.Text;

namespace ver3
{
    class FaxMachine: BaseDevice, IFax
    {
        public int FaxCounter { get; set; } = 0;

        public void Fax(out IDocument document)
        {
            if (state == IDevice.State.on)
            {
                FaxCounter += 1;
                document = new FaxDocument("Fax" + FaxCounter);
                Console.WriteLine(DateTime.Now.ToString() + " Fax: " + document.GetFileName());
            }
            else
            {
                document = null;
            }
        }
    }
}
