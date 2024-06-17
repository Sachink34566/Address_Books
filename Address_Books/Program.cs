using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> city = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> state = new Dictionary<string, List<string>>();
            MultipleAddressBook addressBook = new MultipleAddressBook(1, "Default");

            addressBook.Open(city, state);
        }
    }
}
