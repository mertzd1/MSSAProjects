namespace customersDAO
{
    public class contacts
    {
        public int contactsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int customersId { get; set; }
        public customers customers { get; set; }
    }
}