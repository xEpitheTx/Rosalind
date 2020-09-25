using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Class1
    {
        public static List<string> ProcessDNACollection(string DNACollection, int idLength)
        {
            List<string> processedCollection = DNACollection.Split('>').ToList();
            processedCollection.RemoveAt(0);
            for (int str = 0; str < processedCollection.Count; str++)
            {
                processedCollection[str] = processedCollection[str].Remove(0, idLength);
                processedCollection[str] = processedCollection[str].Trim();
                processedCollection[str] = processedCollection[str].Replace("\r\n", "");
            }
            return processedCollection;
        }
    }
}
