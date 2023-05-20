using EFBloknot.Data.Context;
using EFBloknot.Data.Entities;

namespace EFBloknot.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BloknotDbContext context = new BloknotDbContext())
            {
                //var records = context.Records.Where(r => r.Level > 3); // deferred execution

                //foreach (var item in records)
                //{
                //    Console.WriteLine(item);
                //}

                Record record = new Record()
                {
                    Name = "Record with City",
                    Description = "Test description",
                    Level = 5,
                };

                record.City = new City()
                {
                    Name = "Yerevan"
                };

                context.Records.Add(record);

                context.SaveChanges();
            }
        }
    }
}