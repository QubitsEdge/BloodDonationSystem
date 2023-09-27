/*using BloodDonationSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BloodDonationSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Inventory.Any())
            {
                return;   
            }

            var bloodGroups = new string[] { "A-", "A+", "B-", "B+", "AB-", "AB+", "O-", "O+" };

            foreach (var bloodGroup in bloodGroups)
            {
                var inventoryItem = new Inventory
                {
                    BloodGroup = bloodGroup,
                    Quantity = "0" 
                };

                context.Inventory.Add(inventoryItem);
            }

            context.SaveChanges();
        }
    }
}
*/