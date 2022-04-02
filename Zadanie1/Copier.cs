using System;
using System.Collections.Generic;
using System.Text;

namespace ver1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter = 0;

        public int ScanCounter = 0;
        public void Print(in IDocument document)
        {
            Console.WriteLine(DateTime.Now.ToString() + " Print: " + document.GetFileName());
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            Console.WriteLine(formatType);
            switch (formatType)
            {
                case IDocument.FormatType.PDF:
                    Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "PDFScan" + Counter + ".pdf");
                    document = new PDFDocument("PDFScan" + Counter + ".pdf");
                    break;
                case IDocument.FormatType.JPG:
                    Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "ImageScan" + Counter + ".jpg");
                    document = new ImageDocument("ImageScan" + Counter + ".jpg");
                    break;
                case IDocument.FormatType.TXT:
                    Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "TextScan" + Counter + ".txt");
                    document = new TextDocument("TextScan" + Counter + ".txt");
                    break;
                default:
                    document = null;
                    break;
            }
        }

        public void Scan(out IDocument document)
        {
            Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "ImageScan" + Counter + ".jpg");
            document = new ImageDocument("ImageScan" + Counter + ".jpg");
        }

        public void ScanAndPrint()
        {
            IDocument doc = new ImageDocument("image.img");
            Scan(out doc);
            Print(doc);
        }
    }
}
