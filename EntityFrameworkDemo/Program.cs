namespace EntityFrameworkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework -- Bir ORM - object relational mapping
            //NHibernate - another option
            //Dapper - easier ADO.NET

            //GetAll();
            GetProductsByCategory(2);
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthWindContext context = new NorthWindContext();
            ;
            var result = context.Products.Where(p=>p.CategoryId == categoryId);

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        private static void GetAll()
        {
            NorthWindContext northwindContext = new NorthWindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
