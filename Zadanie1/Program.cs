using System;

namespace ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Copier copier = new Copier();
            IDocument document = new PDFDocument("aaa.pdf");
            copier.Print(document);
            IDocument doc1 = new PDFDocument("aaa.pdf");
            IDocument doc2 = new ImageDocument("img.img");
            copier.Scan(out doc1, doc1.GetFormatType());
            copier.Scan(out doc2);
            Console.WriteLine("Hello World!");
        }
    }
}
