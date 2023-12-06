using CollectionApp.Model;
using System.Collections;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();


            CaesStudy2();
        }

        private static void CaesStudy2()
        {
            var item1 = new OrderItem
            {
                Id = 1,
                Name = "Milk A",
                UnitPrice = 2,
                Quantity = 3
            };
            var item2 = new OrderItem
            {
                Id = 2,
                Name = "Biscuit ABC",
                UnitPrice = 2,
                Quantity = 2
            };
            var item3 = new OrderItem
            {
                Id = 3,
                Name = "Biscuit PQR",
                UnitPrice = 10,
                Quantity = 1
            };

            var shoppingList = new List<OrderItem>();
            shoppingList.Add(item1);
            shoppingList.Add(item2);
            shoppingList.Add(item3);
            //shoppingList.Add("ehllo");

            //shoppingList.Add("Nolwethu");
            //shoppingList.Add(100);

            Console.WriteLine(shoppingList.Count);

            double costToBePaid = 0;

            foreach (OrderItem element in shoppingList)
            {
                               
                Console.WriteLine(" name is " + element.Name);
                Console.WriteLine("cost is :" + element.CostOfOrderItem());
                costToBePaid += element.CostOfOrderItem();
            }

            Console.WriteLine("cost to be paid is "+costToBePaid);

        }

        private static void CaseStudy1()
        {
            var item1 = new OrderItem { Id = 1,
                Name = "Milk A", UnitPrice = 2, Quantity = 3 };
            var item2 = new OrderItem
            {
                Id = 2,
                Name = "Biscuit ABC",
                UnitPrice = 2,
                Quantity = 2
            };
            var item3 = new OrderItem
            {
                Id = 3,
                Name = "Biscuit PQR",
                UnitPrice = 10,
                Quantity = 1
            };

            var shoppingList = new ArrayList();
            shoppingList.Add(item1);
            shoppingList.Add(item2);
            shoppingList.Add(item3);

            //shoppingList.Add("Nolwethu");
            shoppingList.Add(100);

            Console.WriteLine(shoppingList.Count);

            double costToBePaid = 0;

            foreach (Object element in shoppingList) {

                Console.WriteLine(element);
                 var orderitem = (OrderItem) element;
                Console.WriteLine(" name is "+orderitem.Name);
                Console.WriteLine("cost is :"+orderitem.CostOfOrderItem());
            }

        }
    }
}