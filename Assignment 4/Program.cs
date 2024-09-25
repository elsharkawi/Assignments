using Assignment_4.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetNorthwindProducts();

            // display a menu with the options : 1. display products 2. add a product 3.update a product with an id 4. delete a product with and id

            int choice;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display products");
                Console.WriteLine("2. Add a product");
                Console.WriteLine("3. Update a product with an id");
                Console.WriteLine("4. Delete a product with an id");
                Console.WriteLine("5. Exit");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            GetNorthwindProductsUsingEntityFramework();
                            break;
                        case 2:
                            AddProduct();
                            break;
                        case 3:
                            UpdateAProduct();
                            break;
                        case 4:
                           DeleteAProduct();
                            break;

                    }
                }
            } while (choice != 0);
        }

        private static void DeleteAProduct()
        {
            NorthwindContext context = new NorthwindContext();
            int productId;
            Console.WriteLine("Enter product id:");
            productId = int.Parse(Console.ReadLine());

            Product product = context.Products.Find(productId);
            context.Remove(product);
            context.SaveChanges();
        }

        private static void UpdateAProduct()
        {
            NorthwindContext context = new NorthwindContext();
            int productId;
            Console.WriteLine("Enter product id:");
            productId = int.Parse(Console.ReadLine());

            Product product = context.Products.Find(productId);

            Console.WriteLine(
                $"Before updating, the unit price of product with name '{product.ProductName}'" +
                $" with id {productId} is {product.UnitPrice}");

            Console.WriteLine(
                $"Enter new unit price for product with id {productId}:");
            decimal newUnitPrice;
            decimal.TryParse(Console.ReadLine(), out newUnitPrice);

            product.UnitPrice = newUnitPrice;

            context.Update(product);

            Console.WriteLine(
                $"After updating, the unit price of product with name '{product.ProductName}'" +
                $" with id {productId} is {newUnitPrice}");
            Console.WriteLine(
                $"The product with id {productId} was updated successfully");

            var entityAfter = context.Entry(product);
            Console.WriteLine(entityAfter.State);

            context.SaveChanges();

        }

        private static void AddProduct()
        {
            NorthwindContext context = new NorthwindContext();
            Product product = new Product();
            Console.WriteLine("Enter product name:");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter product unit price:");

            decimal unitPrice;
            decimal.TryParse(Console.ReadLine(), out unitPrice);
            product.UnitPrice = unitPrice;

            var entityBefore = context.Entry(product);
            Console.WriteLine(entityBefore.State);

            context.Products.Add(product);

            var entityAfter = context.Entry(product);
            Console.WriteLine(entityAfter.State);

            context.SaveChanges();
            //Console.WriteLine(context.Products.Count());

        }

        private static void GetNorthwindProductsUsingEntityFramework()
        {
            NorthwindContext context = new NorthwindContext();
            List<Product> products = context.Products.ToList();

            Console.WriteLine($"No. of products : {products.Count}");
            Console.WriteLine("--------------------------------------------------------------------------");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product Name: {product.ProductName}, Unit Price : {product.UnitPrice}");
            }

            //context.Products.ToList().ForEach(
            //	p =>
            //	{
            //		Console.WriteLine($" Product name :  {p.ProductName}, Unit Price :  {p.UnitPrice}");
            //	}
            //);

        }


        private static void GetNorthwindProducts()
        {
            // Old ADO.NET implementation

            try
            {
                // create a SqlConnection object that will connect to Northwind Database
                SqlConnection connection = new SqlConnection(
                        "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True;"
                    );
                connection.Open();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Connection to database northwind has been opened successfully");
                SqlCommand command = new SqlCommand("select * from Products", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Console.WriteLine($"No. of rows : {dt.Rows.Count}");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (DataRow dr in dt.Rows)
                {
                    //Console.WriteLine($"Product Name: {dr[1]}, Unit Price : {dr[5]}");
                    Console.WriteLine($"Product Name: {dr["ProductName"]}, Unit Price : {dr["UnitPrice"]}");
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }
    }
}

  
