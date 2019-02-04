namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //using (NorthwindDbContext db = new NorthwindDbContext())
            //{
            //    var data = db.Categories;
            //    foreach (Category item in data)
            //    {
            //        Console.WriteLine(item.CategoryId + " " + item.CategoryName);
            //    }
            //    Console.WriteLine();

            //    var history = db.ProcedureCustomerOrderHistory("ALFKI");
            //    foreach (ProcedureCustomerOrderHistoryReturnModel item in history)
            //    {
            //        Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
            //    }

            //    Console.WriteLine();

            //    OrderDetail orderDetail = db.OrderDetails.First();
            //    Console.WriteLine(orderDetail.Product.ProductName);
            //    Console.WriteLine();
            //    var csvToInt = db.ProcedureCsvToInt("2,4,6,8").Select(x => x.IntValue);
            //    foreach (var item in csvToInt)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //    Engineer engineer = new Engineer
            //    {
            //        Forename = "Simon",
            //        Surname = "Hughes"
            //    };
            //    db.Engineers.Add(engineer);
            //    db.SaveChanges();
            //    EngineerOrder order = new EngineerOrder
            //    {
            //        OrderPlaced = DateTime.Now,
            //        Engineer = engineer
            //    };
            //    db.EngineerOrders.Add(order);
            //    db.SaveChanges();
            //    Console.ReadLine();
            //}
        }
    }
}
