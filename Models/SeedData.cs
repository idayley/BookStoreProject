using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();
        
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(

                    // add a bunch of default data if none exists

                    new Project
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction, Classic",
                        Price = 9.95f,
                        BookPages = 1488

                    },

                    new Project
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction, Biography",
                        Price = 14.58f,
                        BookPages = 944

                    },


                    new Project
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction, Biography",
                        Price = 21.54f,
                        BookPages = 832

                    },

                    new Project
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction, Biography",
                        Price = 11.61f,
                        BookPages = 864

                    },

                    new Project
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction, Historical",
                        Price = 13.33f,
                        BookPages = 528

                    },

                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction, Historical Fiction",
                        Price = 15.95f,
                        BookPages = 288

                    },
                    
                    new Project
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 14.99f,
                        BookPages = 304

                    },

                    new Project
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 21.66f,
                        BookPages = 240

                    },

                    new Project
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction, Business",
                        Price = 29.16f,
                        BookPages = 400

                    },

                    new Project
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction, Thrillers",
                        Price = 15.03f,
                        BookPages = 642

                    },

                    new Project
                    {
                        Title = "That Hideous Strength",
                        Author = "C. S. Lewis",
                        Publisher = "Scribner",
                        ISBN = "978-0743234924",
                        Classification = "Science Fiction",
                        Price = 15.39f,
                        BookPages = 384
                    },

                    new Project
                    {
                        Title = "Dracula",
                        Author = "Bram Stoker",
                        Publisher = "Wordsworth Editions Ltd",
                        ISBN = "978-1853260865",
                        Classification = "Fiction",
                        Price = 11.69f,
                        BookPages = 352
                    },

                    new Project
                    {
                        Title = "The Pilgrim's Regress",
                        Author = "C. S. Lewis",
                        Publisher = "Eerdmans",
                        ISBN = "978-0802872173",
                        Classification = "Classic",
                        Price = 16.00f,
                        BookPages = 256
                    }



                    );



                // save changes to database after entering them in
                context.SaveChanges();
            }
        
        }
    }
}
