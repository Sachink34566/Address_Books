using Address_Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Books
{
    public class SearchContact
    {
        public static bool DoesExist(List<Contacts> list, string firstName, string lastName)
        {
            return list.Any((Contacts) => Contacts.Firstname == firstName && Contacts.Lastname == lastName);
        }
    }
}

