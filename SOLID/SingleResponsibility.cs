using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Bir classın değiştirilmek için en az bir sebebi olmalı
    /// </summary>
    internal class SingleResponsibility
    {
        internal void Run()
        {
            Journal journal = new Journal();
            Console.WriteLine(journal);
            FileOperations fileOperations = new FileOperations();
            fileOperations.SaveToFile(journal, "Temp_File.txt");
        }
        // Günlük ile ilgili gerekli işlemler yapılıyor.
        // Fakat biz bunları dosyaya aktarmak istiyoruz diyelim.
        // Bu işlemi yapmak için birden çok yöntem var fakat sorun burada journal sınıfına birden çok 
        // iş yüklemek. 
        // Şimdi, journal sınıfını değiştirmek için birden çok sebebimiz var. 
        // Bu iş yükünü farklı bir classa dökeceğiz.
        class Journal
        {
            public Journal()
            {
                // temp records
                AddEntry("I cried today");
                AddEntry("I ate bugs");
            }
            private readonly List<string> journals = new List<string>();

            private static int Count = 0;
            public int AddEntry(string text)
            {
                journals.Add($"{++Count} : {text}");
                return Count;
                //Memento pattern, bir nesnenin önceki durumunu, uygulama detaylarını açığa
                //çıkartmadan kaydetmeniz ve geri getirmenizi sağlayan bir tasarım
                //desenidir.
            }
            public void Remove(int index)
            {
                journals.RemoveAt(index);
            }
            public override string ToString()
            {
                return string.Join(Environment.NewLine, journals);
            }
        }
        class FileOperations
        {
            public void SaveToFile(Journal journal, string fileName)
            {
                Console.WriteLine($"{fileName} created.");
            }
        }
    }
}
