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
            List<Contacts> list = new List<Contacts>();
            AddDetails.AddDetail(list);
        }
    }
}
