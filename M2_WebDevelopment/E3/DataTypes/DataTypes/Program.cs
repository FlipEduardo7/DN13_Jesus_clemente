using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer("Juan", DateTime.Now);
            Customer customer2 = new Customer("Ernesto", DateTime.Now);
            Customer customer3 = new Customer("Teresa", DateTime.Now);
            Customer customer4 = new Customer("Tony", DateTime.Now);
            Customer customer5 = new Customer("Carlo", DateTime.Now);
            Customer customer6 = new Customer("Gustavo", DateTime.Now);
            Customer customer7 = new Customer("Gonzalo", DateTime.Now);
            Customer customer8 = new Customer("Lexi", DateTime.Now);
            Customer customer9 = new Customer("Kylie", DateTime.Now);
            Customer customer10 = new Customer("Dayana", DateTime.Now);

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);
            customers.Add(customer6);
            customers.Add(customer7);
            customers.Add(customer8);
            customers.Add(customer9);
            customers.Add(customer10);

            //Ciclo For
            Console.WriteLine("CICLO FOR");
            for (int i = 0; i < customers.Count; i++) {
                Console.WriteLine(customers[i].Name + " " + customers[i].RegisterDate);
            }
            Console.WriteLine("\n");

            //ciclo For Each
            Console.WriteLine("CICLO FOR EACH");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.RegisterDate);
            }
            Console.WriteLine("\n");

            //ciclo While
            int j = 0;
            Console.WriteLine("CICLO WHILE");
            while(j < customers.Count)
            {
                Console.WriteLine(customers[j].Name + " " + customers[j].RegisterDate);
                j++;
            }
            Console.WriteLine("\n");
            
            //ciclo do while
            int k = 0;
            Console.WriteLine("CICLO DO WHILE");
            do
            {
                Console.WriteLine(customers[k].Name + " " + customers[k].RegisterDate);
                k++;
            } while (k < customers.Count);

            Console.ReadKey();
        }
    }
}
