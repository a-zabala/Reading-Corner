using Microsoft.EntityFrameworkCore;
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


                if (!context.Teachers.Any())
                {

                    context.Teachers.AddRange(
                        new Teacher
                        {
                            FName = "Charlee",
                            LName = "Dixon",
                            
                            Students = new List<Student>()
                            {
                                new Student
                                {
                                FirstName = "Celina",
                                LastName = "Zabala",
                                // Teacher = "Dixon",


                                ReadingRecords = new List<ReadingRecord>()
                                 {
                                  new ReadingRecord
                                   {

                                     Name = "Harry Potter",
                                     Pages = 45,
                                     Minutes = 30,
                                     LogDate = Convert.ToDateTime("12/25/2017")

                                   },
                                   new ReadingRecord
                                   {

                                     Name = "Harry Potter",
                                     Pages = 45,
                                     Minutes = 30,
                                     LogDate = Convert.ToDateTime("12/29/2017")
                                   }

                                }

                                }
                            }

                            },

                            new Teacher
                            {
                                FName = "Jennifer",
                                LName = "Finck",
                                
                                Students = new List<Student>()
                                {
                                 new Student
                                 {
                                  FirstName = "Molly",
                                  LastName = "Matheny",
                                  //Teacher = "Dixon",
                                  ReadingRecords = new List<ReadingRecord>()
                                    {
                                      new ReadingRecord
                                         {

                                          Name = "Geronimo Stilton",
                                          Minutes = 30,
                                          Pages = 40,
                                          LogDate = Convert.ToDateTime("12/26/2017")
                                         }

                                     }
                                   },
                                   new Student
                                   {
                                    FirstName = "Elysia",
                                    LastName = "Zabala",
                                    //Teacher = "Finck",
                                    ReadingRecords = new List<ReadingRecord>()
                                     {
                                        new ReadingRecord
                                         {
                                           Name = "Harry Potter",
                                           Minutes = 40,
                                           Pages = 30,
                                           LogDate = Convert.ToDateTime("12/27/2017")
                                         }

                                     }
                                   }
                             }
                            } 
                     );
                }

                context.SaveChanges();

            }   
            
        }
    }
}