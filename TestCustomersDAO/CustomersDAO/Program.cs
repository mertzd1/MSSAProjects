using System;

namespace customersDAO
{
    class Program
    {
        static void Main(string[] args)
        {
            using(customersContext context = new customersContext())
            {
                IDAO<customers> customersDAO = new customersDAO<customers>(context);
                IDAO<contacts> contactsDAO = new customersDAO<contacts>(context);
                App customers = new App(customersDAO, contactsDAO);
                customers.Run();
            }
        }
    }
}
