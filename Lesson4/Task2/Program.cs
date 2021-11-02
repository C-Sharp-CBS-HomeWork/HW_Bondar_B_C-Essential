using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler newDoc = null;
            bool typeChoosen = false;
            while (!typeChoosen)
            {
                Console.Write("Enter file type (txt, doc, xml):");
                string fileType = Console.ReadLine();
                switch (fileType)
                {
                    case "txt":
                        {
                            newDoc = new TXTHandler();
                            typeChoosen = true;
                            break;
                        }
                    case "doc":
                        {
                            newDoc = new DOCHandler();
                            typeChoosen = true;
                            break;
                        }
                    case "xml":
                        {
                            newDoc = new XMLHandler();
                            typeChoosen = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong type. Please, try again.");
                        typeChoosen = false;
                        break;
                }
            }
            Console.Write("Enter document name:");
            string docName = Console.ReadLine();
            newDoc.Open(docName);
            newDoc.Change(docName);
            newDoc.Create(docName);
            newDoc.Save(docName);
            Console.ReadKey();
        }
    }
}
