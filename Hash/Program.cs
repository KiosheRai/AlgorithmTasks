using System;

namespace Hash
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var directory = new Directory();

            directory.Add(new Contact
            {
                Name = "Adler",
                Phone = "+375291234532"
            });
            directory.Add(new Contact
            {
                Name = "Asus",
                Phone = "+375291234432"
            });
            directory.Add(new Contact
            {
                Name = "Gause",
                Phone = "+375291212353"
            });

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Select an action: ");
                Console.WriteLine("1: Show list");
                Console.WriteLine("2: Search by name");
                Console.WriteLine("3: Add");
                Console.WriteLine("4: Remove by name");
                Console.WriteLine("5: Update by name");
                Console.WriteLine("6: Close");

                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        foreach (var x in directory.Get())
                            Console.WriteLine($"{x.Name} | {x.Phone}");
                        break;
                    case 2:
                        Console.WriteLine("Enter a name: ");
                        string search = Console.ReadLine();
                        foreach (var x in directory.GetByName(search))
                            Console.WriteLine($"{x.Name} | {x.Phone}");
                        break;
                    case 3:
                        Console.WriteLine("Enter a name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter a phone: ");
                        string phone = Console.ReadLine();

                        directory.Add(
                            new Contact
                            {
                                Name = name,
                                Phone = phone
                            });
                        break;
                    case 4:
                        Console.WriteLine("Enter a name: ");
                        string remove = Console.ReadLine();
                        directory.Remove(remove);
                        break;
                    case 5:
                        Console.WriteLine("Enter a name: ");
                        string update = Console.ReadLine();
                        foreach (var x in directory.GetByName(update))
                            Console.WriteLine($"{x.Name} | {x.Phone}");

                        Console.WriteLine("Enter a new name: ");
                        string updateName = Console.ReadLine();
                        Console.WriteLine("Enter a new phone: ");
                        string updatePhone = Console.ReadLine();

                        directory.Update(update, new Contact
                        {
                            Name = updateName,
                            Phone = updatePhone
                        });
                        break;
                    case 6:
                        isRunning = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            
        }
    }
}
