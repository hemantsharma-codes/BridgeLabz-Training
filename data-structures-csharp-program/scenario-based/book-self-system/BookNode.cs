namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
{
    internal class BookNode
    {
        public Book data;
        public BookNode next;

        public BookNode(Book book)
        {
            data = book;
            next = null;
        }
    }
}
