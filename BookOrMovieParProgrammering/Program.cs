namespace BookOrMovieParProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Book\n2. Movie\n3. Exit program");
                string choice = Console.ReadLine();

                if (choice == "1" || choice == "2")
                {
                    ProductChoices(choice == "1");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting the program");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }

        static void ProductChoices(bool isBook)
        {
            string productType = isBook ? "book" : "movie";
            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine($"1. Add a new {productType} \n2. Display all {productType}s \n3. Delete product \n4. Go Back");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        AddProduct();
                        break;
                    case "2":
                        Console.Clear();
                        DisplayAllProduct();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Delete product");
                        DeleteProduct();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        static List<Product> products = new List<Product>();

        static void AddProduct()
        {
            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Release year:");
            int releaseYear;
            while (!int.TryParse(Console.ReadLine(), out releaseYear))
            {
                Console.WriteLine("Invalid input, enter a number for the release year.");
            }

            Console.WriteLine("Enter a short description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter director/writer name:");
            string director = Console.ReadLine();

            Console.Write("Enter actors (separeted with comma):");
            List<string> actors = new List<string>(Console.ReadLine().Split(", "));

            Product product = new Product
            {
                Title = title,
                ReleaseYear = releaseYear,
                Director = director,
                Description = description,
                Actors = actors,
            };
            products.Add(product);
            Console.WriteLine($"\n{title} ({releaseYear}) has been added as a product");
        }
        static void DisplayAllProduct()
        {
            Console.Clear();
            foreach (Product product in products)
            {
                product.DisplayInfo();
            }
        }
        static void DeleteProduct()
        {
            Console.Clear();

            if (products.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            Console.WriteLine("List of movies and books:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Title}");
            }

            Console.WriteLine("Enter the number for the movie/movie you want to delete:");

            int index;
            Console.WriteLine("Enter index you want to delete");
            while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > products.Count)
            {
                Console.WriteLine("Invalid input");
            }

            index--;

            Product deletedProduct = products[index];
            products.RemoveAt(index);

            Console.WriteLine($" You deleted {deletedProduct.Title}");
        }
    }
}