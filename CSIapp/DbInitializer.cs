using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSIapp;

namespace CSIapp
{
    public static class DbInitializer
    {
        public static void Initialize(csidataContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.RequestMetrics.Any())
            {
                return;   // DB has been seeded
            }
        }
    }
}