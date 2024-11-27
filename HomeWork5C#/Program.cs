using System.Text;

namespace HomeWork5C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //Task 1
            /*Journal journal1 = new Journal("Journal1", 2010, "About journal1", "0975731486", "adress@gmail.com", 12);
            Journal journal2 = new Journal("Journal2", 2000, "About journal2", "0674148573", "adress@gmail.com", 15);
            journal1.DisplayData();

            journal1 += 5; 
            journal1.DisplayData();

            journal1 -= 2; 
            journal1.DisplayData();

            Console.WriteLine(journal1 == journal2 ? "\nКількість працівників однакова" : "\nКількість працівників різна");
            Console.WriteLine(journal1 > journal2 ? "Journal1 має більше працівників" : "Journal1 має менше або стільки ж працівників");*/

            //Task 2
            /*Store store1 = new Store("Store 1", "123 Main St", "Grocery Store", "+123456789", "store1@example.com", 150);
            Store store2 = new Store("Store 2", "456 Market St", "Electronics Store", "+987654321", "store2@example.com", 200);

            store1.DisplayStoreData();
            Console.WriteLine();
            store2.DisplayStoreData();
            Console.WriteLine();

            store1 += 50;
            Console.WriteLine("Після збільшення площі:");
            store1.DisplayStoreData();
            Console.WriteLine();

            store2 -= 30;
            Console.WriteLine("Після звуження площі:");
            store2.DisplayStoreData();
            Console.WriteLine();

            Console.WriteLine($"Чи площі магазинів рівні? {store1 == store2}");

            Console.WriteLine($"Чи store1 менше за store2 {store1 < store2}");
            Console.WriteLine($"Чи store1 більше за store2? {store1 > store2}");*/
        }
    }
}
