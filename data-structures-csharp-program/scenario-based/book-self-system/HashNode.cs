namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BookShelfSystem
{
    internal class HashNode
    {
        public string genre;
        public BookLinkedList books;
        public HashNode next;

        public HashNode(string genre)
        {
            this.genre = genre;
            books = new BookLinkedList();
            next = null;
        }
    }
}
