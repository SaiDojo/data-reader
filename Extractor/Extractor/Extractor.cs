using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extractor
{
    public interface IExtractor
    {
        int Extract(string filePath);
        int Extract(StreamReader reader);
    }

    public class Extractor: IExtractor
    {
        public int Extract(StreamReader reader)
        {
            string line;
            int totalLines = 0 ;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                totalLines++;
            }
            return totalLines;
        }

        public int Extract(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            {
                return Extract(reader);
            }
        }

    }
}
