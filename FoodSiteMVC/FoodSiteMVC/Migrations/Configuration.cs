namespace FoodSiteMVC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodSiteMVC.Models.FoodSiteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FoodSiteMVC.Models.FoodSiteDBContext context)
        {
            context.Foods.AddOrUpdate(
                p => p.foodName,
                new Models.Foods
                {
                    foodName = "Dark Meat Chicken",
                    foodTag = "Chicken",
                    foodType = "Dark",
                    foodSize = "",
                    foodPrice = "",
                },
                new Models.Foods
                {
                    foodName = "Dark Meat Chicken Combo",
                    foodTag = "Chicken",
                    foodType = "Dark",
                    foodSize = "",
                    foodPrice = "",
                },
              new Models.Foods
              {
                  foodName = "White Meat Chicken",
                  foodTag = "Chicken",
                  foodType = "White",
                  foodSize = "",
                  foodPrice = "",
              },
                new Models.Foods
                {
                    foodName = "White Meat Chicken Combo",
                    foodTag = "Chicken",
                    foodType = "White",
                    foodSize = "",
                    foodPrice = "",
                },
                new Models.Foods
                {
                    foodName = "Dark and White Meat Chicken",
                    foodTag = "Chicken",
                    foodType = "Mix",
                    foodSize = "",
                    foodPrice = "",
                },
                new Models.Foods
                {
                    foodName = "Dark and White Meat Chicken Combo",
                    foodTag = "Chicken",
                    foodType = "Mix",
                    foodSize = "",
                    foodPrice = "",
                },
                new Models.Foods
                {
                    foodName = "Chicken Tenders",
                    foodTag = "Chicken",
                    foodType = "Tenders",
                    foodSize = "",
                    foodPrice = "",
                },
                new Models.Foods
                {
                    foodName = "Chicken Tenders Combo",
                    foodTag = "Chicken",
                    foodType = "Tenders",
                    foodSize = "",
                    foodPrice = "",
                },
              new Models.Foods
              {
                  foodName = "Small Breakfast Plate",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "Small",
                  foodPrice = "1.99",
              },
              new Models.Foods
              {
                  foodName = "Large Breakfast Plate",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "Large",
                  foodPrice = "3.99",
              },
              new Models.Foods
              {
                  foodName = "Pork Link Egg and Cheese",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "Smoked Sausage Egg and Cheese",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "Hot Sausage Egg and Cheese",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "Bacon Egg and Cheese",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "Sausage Patty Egg and Cheese",
                  foodTag = "Breakfast",
                  foodType = "Breakfast",
                  foodSize = "",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "6-Inch Roast Beef Po-Boy",
                  foodTag = "Po-Boy",
                  foodType = "Po-Boy",
                  foodSize = "6-Inch",
                  foodPrice = "3.00",
              },
               new Models.Foods
               {
                   foodName = "12-Inch Roast Beef Po-Boy",
                   foodTag = "Po-Boy",
                   foodType = "Po-Boy",
                   foodSize = "12-Inch",
                   foodPrice = "5.00",
               },
                new Models.Foods
                {
                    foodName = "6-Inch Hot Sausage Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "3.00",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Hot Sausage Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "5.00",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Hamburger Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "3.00",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Hamburger Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "5.00",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Shirmp Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "4.99",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Shirmp Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "7.99",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Fish Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "4.99",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Shirmp Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "7.99",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Turkey Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "3.00",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Turkey Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "5.00",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Ham Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "3.00",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Ham Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "5.00",
                },
                new Models.Foods
                {
                    foodName = "6-Inch Chicken Tender Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "3.00",
                },
                new Models.Foods
                {
                    foodName = "12-Inch Chicken Tender Po-Boy",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "12-Inch",
                    foodPrice = "5.00",
                },
                new Models.Foods
                {
                    foodName = "Ham Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                    foodName = "Hot Sausage Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                    foodName = "Ham Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                    foodName = "Hot Sausage Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                    foodName = "Turkey Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                    foodName = "Hamburger Po-Boy Combo",
                    foodTag = "Po-Boy",
                    foodType = "Po-Boy",
                    foodSize = "6-Inch",
                    foodPrice = "5.99",
                },
                new Models.Foods
                {
                foodName = "Small Fries",
                foodTag = "Side",
                foodType = "Side",
                foodSize = "Small",
                foodPrice = "1.99",
                },
                new Models.Foods
                {
                    foodName = "Large Fries",
                    foodTag = "Side",
                    foodType = "Side",
                    foodSize = "Large",
                    foodPrice = "2.99",
                },
              new Models.Foods
              {
                  foodName = "Small Red Beans and Rice",
                  foodTag = "Side",
                  foodType = "Side",
                  foodSize = "Small",
                  foodPrice = "1.99",
              },
                new Models.Foods
                {
                    foodName = "Large Red Beans and Rice",
                    foodTag = "Side",
                    foodType = "Side",
                    foodSize = "Large",
                    foodPrice = "2.99",
                },
              new Models.Foods
              {
                  foodName = "Small Jambalaya",
                  foodTag = "Side",
                  foodType = "Side",
                  foodSize = "Small",
                  foodPrice = "1.99",
              },
                new Models.Foods
                {
                    foodName = "Large Jambalaya",
                    foodTag = "Side",
                    foodType = "Side",
                    foodSize = "Large",
                    foodPrice = "2.99",
                },
               new Models.Foods
               {
                   foodName = "Small Potato Salad",
                   foodTag = "Side",
                   foodType = "Side",
                   foodSize = "Small",
                   foodPrice = "1.99",
               },
                new Models.Foods
                {
                    foodName = "Large Potato Salad",
                    foodTag = "Side",
                    foodType = "Side",
                    foodSize = "Large",
                    foodPrice = "2.99",
                },
              new Models.Foods
              {
                  foodName = "Small Jalapeno Poppers",
                  foodTag = "Side",
                  foodType = "Side",
                  foodSize = "Small",
                  foodPrice = "2.99",
              },
              new Models.Foods
              {
                  foodName = "Large Jalapeno Poppers",
                  foodTag = "Side",
                  foodType = "Side",
                  foodSize = "Large",
                  foodPrice = "5.99",
              },
                new Models.Foods
                {
                    foodName = "Meat Pie",
                    foodTag = "Side",
                    foodType = "Side",
                    foodSize = "Small",
                    foodPrice = "1.99",
                }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            );
        }
    }
}