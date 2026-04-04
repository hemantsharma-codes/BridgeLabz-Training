using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    internal interface ILibraryOperation
    {
        void AddBook(Book book);
        void PartialSearchBook(string title);
        
        void UpdateBookStatus(string title,string author);  
    }
}
