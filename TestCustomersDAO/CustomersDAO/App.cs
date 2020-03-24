using System;
using System.Collections.Generic;
using System.Linq;

namespace customersDAO
{
    public class App
    {
        public IDAO<customers> customersDAO { get; set; }
        public IDAO<contacts> contactsDAO { get; set; }
        
        public App(IDAO<customers> customersDAO, IDAO<contacts> contactsDAO)
        {
            customersDAO = customersDAO;
            contactsDAO = contactsDAO;
        }

        public void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("New customers & First contacts Creation Prompts");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please Enter The customers Name: ");
            string customersName = Console.ReadLine();
            Addcustomers(customersName);
            Printcustomerss();
            Console.WriteLine("Please Enter A customers Id To Search By: ");
            int customersId = int.Parse(Console.ReadLine());
            Printcustomerss(customersId);
            Console.WriteLine("Please Enter A customers Name To Search By: ");
            customersName = Console.ReadLine();
            Printcustomerss(customersName);
        }

        public void Addcustomers(string customersName)
        {
            customers b = new customers();
            b.Name = customersName;
            customersDAO.Create(b);
        }

        public void Printcustomerss()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------- customerss ----------------");
            Console.WriteLine("--------------------------------------");
            foreach(customers b in Getcustomerss())
            {
                Console.WriteLine($"{b.customersId}) {b.Name}");
            }
            Console.WriteLine("--------------------------------------");
        }

        public IEnumerable<customers> Getcustomerss()
        {
            return customersDAO.Data;
        }
        public void Printcustomerss(string name)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------- customerss ----------------");
            Console.WriteLine("--------------------------------------");
            foreach(customers b in SearchcustomerssBycustomersName(name))
            {
                Console.WriteLine($"{b.customersId}) {b.Name}");
            }
            Console.WriteLine("--------------------------------------");
        }
        public void Printcustomerss(int id)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------- customerss ----------------");
            Console.WriteLine("--------------------------------------");
            foreach(customers b in SearchcustomerssBycustomersId(id))
            {
                Console.WriteLine($"{b.customersId}) {b.Name}");
            }
            Console.WriteLine("--------------------------------------");
        }

        public IEnumerable<customers> SearchcustomerssBycustomersName(string name)
        {
            return customersDAO.Data.Where(b => b.Name.Contains(name)).ToList();
        }

        public IEnumerable<customers> SearchcustomerssBycustomersId(int customersId)
        {
            return customersDAO.Data.Where(b => b.customersId == customersId).ToList();
        }
    }
}