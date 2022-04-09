using System;
using System.Collections.Generic;
using System.Text;

namespace ver3
{
    class Scanner: BaseDevice, IScanner
    {
        public int ScanCounter = 0;
        public void Scan(out IDocument document, IDocument.FormatType formatType)
        {
            if (state == IDevice.State.on)
            {
                ScanCounter += 1;
                switch (formatType)
                {
                    case IDocument.FormatType.PDF:
                        Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "PDFScan" + ScanCounter + ".pdf");
                        document = new PDFDocument("PDFScan" + ScanCounter + ".pdf");
                        break;
                    case IDocument.FormatType.JPG:
                        Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "ImageScan" + ScanCounter + ".jpg");
                        document = new ImageDocument("ImageScan" + ScanCounter + ".jpg");
                        break;
                    case IDocument.FormatType.TXT:
                        Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "TextScan" + ScanCounter + ".txt");
                        document = new TextDocument("TextScan" + ScanCounter + ".txt");
                        break;
                    default:
                        document = null;
                        break;
                }
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
                ScanCounter += 1;
                Console.WriteLine(DateTime.Now.ToString() + " Scan: " + "ImageScan" + ScanCounter + ".jpg");
                document = new ImageDocument("ImageScan" + ScanCounter + ".jpg");
            }
            else
            {
                document = null;
            }
        }
    }
}
