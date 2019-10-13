using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interview.Implementation;
namespace Inteview.Tests
{
    [TestClass]
    public class CustomerRespositoryTests
    {

        [TestMethod]
        public void can_add_customer()
        {
            CustomerRepository<Custommer<int>, int> cr = new CustomerRepository<Custommer<int>, int>();
            Custommer<int> customer1 = new Custommer<int>();
            customer1.Id = 1;
            cr.Save(customer1);

            Assert.IsTrue(cr.Get(1) == customer1, "Unable to save a customer");
        }

        [TestMethod]
        public void can_select_customer_by_customer_id()
        {
            CustomerRepository<Custommer<int>, int> cr = new CustomerRepository<Custommer<int>, int>();
            Custommer<int> customer1 = new Custommer<int>();
            customer1.Id = 1;
            cr.Save(customer1);

            var customer = cr.Get(1);
            Assert.IsNotNull(customer, "Could not find customer by id");
           
        }

        [TestMethod]
        public void can_delete_customer()
        {
            CustomerRepository<Custommer<int>, int> cr = new CustomerRepository<Custommer<int>, int>();
            Custommer<int> customer1 = new Custommer<int>();
            customer1.Id = 1;
            cr.Save(customer1);
            cr.Delete(customer1.Id);

            var customer = cr.Get(1);
            Assert.IsNull(customer, "Could not delete customer");
          
        }
       
        [TestMethod]
        public void can_select_all_customers()
        {
            CustomerRepository<Custommer<int>, int> cr = new CustomerRepository<Custommer<int>, int>();
            Custommer<int> customer1 = new Custommer<int>();
            customer1.Id = 1;
            cr.Save(customer1);

            Custommer<int> customer2 = new Custommer<int>();
            customer2.Id = 2;
            cr.Save(customer2);

            Custommer<int> customer3 = new Custommer<int>();
            customer3.Id = 3;
            cr.Save(customer3);

            int count = 0;
            foreach (var item in cr.GetAll())
            {
                count++;
            }
            Assert.IsTrue(count == 3, "The respository does not return all customers");
        }
    }
}
