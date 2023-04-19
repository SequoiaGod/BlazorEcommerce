namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Title = "Iron Man",
                    Description = "Iron Man is a superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense #39 (cover dated March 1963), and received his own title in Iron Man #1 (May 1968). In 1963, the character founded the Avengers superhero team with Thor, Ant-Man, Wasp and the Hulk.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/47/Iron_Man_%28circa_2018%29.png",
                    Price = 8.8m
                },
            new Product
            {
                ID = 2,
                Title = "Spider-Man",
                Description = "Spider-Man is a superhero appearing in American comic books published by Marvel Comics. Created by writer-editor Stan Lee and artist Steve Ditko, he first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books. He has been featured in comic books, television shows, films, video games, novels, and plays.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png",
                Price = 12.66m
            },
            new Product
            {
                ID = 3,
                Title = "Bat man",
                Description = "Batman[a] is a superhero appearing in American comic books published by DC Comics. The character was created by artist Bob Kane and writer Bill Finger, and debuted in the 27th issue of the comic book Detective Comics on March 30, 1939. In the DC Universe continuity, Batman is the alias of Bruce Wayne, a wealthy American playboy, philanthropist, and industrialist who resides in Gotham City. Batman's origin story features him swearing vengeance against criminals after witnessing the murder of his parents Thomas and Martha as a child, a vendetta tempered with the ideal of justice. He trains himself physically and intellectually, crafts a bat-inspired persona, and monitors the Gotham streets at night. Kane, Finger, and other creators accompanied Batman with supporting characters, including his sidekicks Robin and Batgirl; allies Alfred Pennyworth, James Gordon, and Catwoman; and foes such as the Penguin, the Riddler, Two-Face, and his archenemy, the Joker.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c7/Batman_Infobox.jpg",
                Price = 6.66m
            },
            new Product
            {
                ID = 4,
                Title = "The Flash",
                Description = "The Flash is an upcoming American superhero film based on the DC Comics character of the same name. Produced by DC Studios, Double Dream, and the Disco Factory, and set for distribution by Warner Bros. Pictures, it is intended to be the 13th installment in the DC Extended Universe (DCEU). The film is directed by Andy Muschietti from a screenplay by Christina Hodson and stars Ezra Miller as Barry Allen / The Flash alongside Sasha Calle, Michael Shannon, Ron Livingston, Maribel Verdú, Kiersey Clemons, Antje Traue, and Michael Keaton. In the film, Barry travels back in time to prevent his mother's murder, which brings unintended consequences.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/ed/The_Flash_%28film%29_poster.jpg",
                Price = 2.22m
            }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
