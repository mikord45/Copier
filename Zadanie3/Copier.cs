using System;
using System.Collections.Generic;
using System.Text;

namespace ver3
{
    public class Copier: BaseDevice
    {
        private Printer printer = new Printer();

        private Scanner scanner = new Scanner();

        public int PrinterCounter { get => printer.Counter; }

        public int ScannerCounter { get => scanner.Counter; }
        public int PrintCounter { get => printer.PrintCounter; set => printer.PrintCounter = value; }
        public int ScanCounter { get => scanner.ScanCounter; set => scanner.ScanCounter = value; }

        public void PowerOnPrinter()
        {
            printer.PowerOn();
        }
        public void PowerOffPrinter()
        {
            printer.PowerOff();
        }

        public void PowerOnScanner()
        {
             scanner.PowerOn();
        }
        public void PowerOffScanner()
        {
            scanner.PowerOff();
        }

        public new void PowerOff()
        {
            if (state == IDevice.State.on)
            {
                state = IDevice.State.off;
                printer.PowerOff();
                scanner.PowerOff();
                Console.WriteLine("... Device is off !");
            }
        }

        public new void PowerOn()
        {
            if (state == IDevice.State.off)
            {
                Counter += 1;
                state = IDevice.State.on;
                printer.PowerOn();
                scanner.PowerOn();
                Console.WriteLine("Device is on ...");
            }
        }

        public void Print(in IDocument document)
        {
            if (state == IDevice.State.on)
            {
                printer.Print(in document);
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            if (state == IDevice.State.on)
            {
                scanner.Scan(out document, formatType);
            }
            else
            {
                document = null;
            }
        }

        public void Scan(out IDocument document)
        {
            if (state == IDevice.State.on)
            {
                scanner.Scan(out document);
            }
            else {
                document = null;
            }
        }

        public void ScanAndPrint()
        {
            if (state == IDevice.State.on)
            {
                IDocument doc;
                scanner.Scan(out doc);
                printer.Print(doc);
            }
        }
    }
}
