using System;

namespace ver3
{
    class Program
    {
        static void Main(string[] args)
        {
            var xerox = new Copier();
            xerox.PowerOn();
            IDocument doc1 = new PDFDocument("aaa.pdf");
            xerox.Print(in doc1);

            IDocument doc2;
            xerox.Scan(out doc2);

            xerox.ScanAndPrint();
            System.Console.WriteLine(xerox.Counter);
            System.Console.WriteLine(xerox.PrintCounter);
            System.Console.WriteLine(xerox.ScanCounter);

            var multiMachine = new MultidimensionalDevice();
            multiMachine.PowerOn();
            IDocument doc3 = new PDFDocument("aaa.pdf");
            multiMachine.Print(in doc3);

            IDocument doc4;
            multiMachine.Scan(out doc4);

            multiMachine.ScanAndPrint();
            System.Console.WriteLine(multiMachine.Counter);
            System.Console.WriteLine(multiMachine.PrintCounter);
            System.Console.WriteLine(multiMachine.ScanCounter);
            System.Console.WriteLine(multiMachine.FaxCounter);
            IDocument doc5 = new PDFDocument("aaa.pdf");
            multiMachine.Fax(out doc5);
            System.Console.WriteLine(multiMachine.FaxCounter);
        }
    }
}
