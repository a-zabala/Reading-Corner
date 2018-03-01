﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Reading_Corner.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reading_Corner.Entities
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any books.
                if (!context.Books.Any())
                {



                    context.Books.AddRange(
                         new Book
                         {
                             Name = "Holes",
                             Genre = "Science Fiction",
                             Author = "Louis "
                         },

                         new Book
                         {
                             Name = "Flush",
                             Genre = "Young Adult Fiction",
                             Author = "Carl Hiassan"
                         },
                         new Book
                         {
                             Name = "Harry Potter",
                             Genre = "Fiction",
                             Author = "Jk Rowlings"
                         }

                    );

                }


                if (!context.Students.Any())
                {

                    context.Students.AddRange(
                     new Student
                     {
                         FirstName = "Celina",
                         LastName = "Zabala",
                         Teacher = "Dixon",
                         CurrentBook = "Harry Potter"
                     },

                     new Student
                     {
                         FirstName = "Molly",
                         LastName = "Matheny",
                         Teacher = "Dixon",
                         CurrentBook = "Sisters"
                     },
                     new Student
                     {
                         FirstName = "Elysia",
                         LastName = "Zabala",
                         Teacher = "Finck",
                         CurrentBook = "Holes"
                     }

                );
                }

                if (!context.ReadingRecords.Any())
                {

                    context.ReadingRecords.AddRange(
                     new ReadingRecord
                     {
                         Name = "Harry Potter",
                         Pages = 45,
                         Minutes = 30,

                     },

                     new ReadingRecord
                     {
                         Name = "Geronimo Stilton",
                         Minutes = 30,
                         Pages = 40,
                     },
                     new ReadingRecord
                     {
                         Name = "Harry Potter",
                         Minutes = 40,
                         Pages = 30,
                     }

                );
                }
                context.SaveChanges();

            }
        } 
    }
}