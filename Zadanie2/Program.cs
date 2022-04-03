using System;

namespace ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiMachine = new MultifunctionalDevice();
            multiMachine.PowerOn();
            IDocument doc1 = new PDFDocument("aaa.pdf");
            multiMachine.Print(in doc1);

            IDocument doc2;
            multiMachine.Scan(out doc2);

            multiMachine.ScanAndPrint();
            System.Console.WriteLine(multiMachine.Counter);
            System.Console.WriteLine(multiMachine.PrintCounter);
            System.Console.WriteLine(multiMachine.ScanCounter);
            System.Console.WriteLine(multiMachine.FaxCounter);
            IDocument doc3 = new PDFDocument("aaa.pdf");
            multiMachine.Fax(out doc3);
            System.Console.WriteLine(multiMachine.FaxCounter);
        }
    }
}
