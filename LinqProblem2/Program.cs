using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            NameLibrary nameLibrary = new NameLibrary();
            List<string> words = nameLibrary.GetStrings();

            var nameList = words.GroupBy(l => l);
            var duplicates = nameList.Where(d => d.Count() >= 1);
            var names = duplicates.Select(n => n.Key).ToList();

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
