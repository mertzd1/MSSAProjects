using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;

namespace customersDAO.Tests
{
    public class AppTest
    {
        public App app { get; set; }

        public void InitTest(List<customers> customersList, List<contacts> contactsList)
        {
            Mock<IDAO<customers>> mockcustomersDAO = new Mock<IDAO<customers>>();
            mockcustomersDAO.Setup(DAO => DAO.Data).Returns(customersList.AsQueryable());

            Mock<IDAO<contacts>> mockcontactsDAO = new Mock<IDAO<contacts>>();
            mockcontactsDAO.Setup(DAO => DAO.Data).Returns(contactsList.AsQueryable());
            
            app = new App(mockcustomersDAO.Object, mockcontactsDAO.Object);
        }


        [Fact]
        public void GetcustomerssByName()
        {
            List<customers> customersList = new List<customers>();
            customers testcustomers = new customers(1, "Test");
            customersList.Add(testcustomers);
            customersList.Add(new customers(2, "Nothing"));
            customers testingcustomers = new customers(3, "Testing");
            customersList.Add(testingcustomers);
            customersList.Add(new customers(4, "Nothing"));
            customers testedcustomers = new customers(5, "Tested");
            customersList.Add(testedcustomers);
            customersList.Add(new customers(6, "Something"));
            
            List<contacts> contactsList = new List<contacts>();

            InitTest(customersList, contactsList);

            IEnumerable<customers> customerssFound = app.SearchcustomerssBycustomersName("Test");
            Assert.True(customerssFound.Count() == 3);
            Assert.True(customerssFound.Contains(testcustomers));
            Assert.True(customerssFound.Contains(testingcustomers));
            Assert.True(customerssFound.Contains(testedcustomers));
        }
        
        [Fact]
        public void GetcustomerssById()
        {
            List<customers> customersList = new List<customers>();
            customers testcustomers = new customers(1, "Test");
            customersList.Add(testcustomers);
            customersList.Add(new customers(2, "Nothing"));
            customers testingcustomers = new customers(3, "Testing");
            customersList.Add(testingcustomers);
            customersList.Add(new customers(4, "Nothing"));
            customers testedcustomers = new customers(5, "Tested");
            customersList.Add(testedcustomers);
            customersList.Add(new customers(6, "Something"));
            
            List<contacts> contactsList = new List<contacts>();

            InitTest(customersList, contactsList);

            IEnumerable<customers> customerssFound = app.SearchcustomerssBycustomersId(5);
            Assert.True(customerssFound.Count() == 1);
            Assert.True(customerssFound.Contains(testedcustomers));
        }
    }
}
