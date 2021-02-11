using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMusic.Data;
using System;
using System.Linq;

namespace MvcMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMusicContext>>()))
            {
                // Look for any Musics.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                    new Music
                    {
                        Title = "Random Access Memories",
                        ReleaseDate = DateTime.Parse("2013-07-01"),
                        Genre = "Dance",
                        Price = 7.99M,
                        Rating = "P",
                        Token = "r.a.m-1",
                        isValid = true,
                    },

                    new Music
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "Q",
                        Token = "ghostbusters-1",
                        isValid = false,


                    },

                    new Music
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R",
                        Token = "ghostbusters-2",
                        isValid = false,

                    },

                    new Music
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Token = "rio-bravo-1",
                        isValid = false,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}