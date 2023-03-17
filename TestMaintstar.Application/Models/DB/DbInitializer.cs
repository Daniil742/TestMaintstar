using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaintstar.Application.Models.Entities;

namespace TestMaintstar.Application.Models.DB
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Pictures.AddRange(new List<Picture>
            {
                new Picture
                {
                    Name = "Название 1",
                    Description = "Описание 1",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 2",
                    Description = "Описание 2",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 3",
                    Description = "Описание 3",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 4",
                    Description = "Описание 4",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 5",
                    Description = "Описание 5",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 6",
                    Description = "Описание 6",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 7",
                    Description = "Описание 7",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 8",
                    Description = "Описание 8",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 9",
                    Description = "Описание 9",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 10",
                    Description = "Описание 10",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 11",
                    Description = "Описание 11",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 12",
                    Description = "Описание 12",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 13",
                    Description = "Описание 13",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 14",
                    Description = "Описание 14",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 15",
                    Description = "Описание 15",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 16",
                    Description = "Описание 16",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 17",
                    Description = "Описание 17",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 18",
                    Description = "Описание 18",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 19",
                    Description = "Описание 19",
                    PublicationDate = DateTime.Now
                },
                new Picture
                {
                    Name = "Название 20",
                    Description = "Описание 20",
                    PublicationDate = DateTime.Now
                }
            });

            context.SaveChanges();
        }
    }
}
