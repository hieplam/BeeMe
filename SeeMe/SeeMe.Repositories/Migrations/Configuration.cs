using SeeMe.Repositories.DomainModels;

namespace SeeMe.Repositories.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SeeMe.Repositories.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SeeMe.Repositories.DataContext context)
        {
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

            if (!context.Artists.Any())
            {
                context.Artists.AddOrUpdate(a => a.Id, new Artist { Id = 1, AvatarUrl = "sourcehinh/ArtistAvatar/2.jpg", JobTitle = "Senior 2D Concept ArtistModel", Name = "Lam Hiep" });
            }
            #region Add Artwork
            if (!context.Artworks.Any())
            {
                context.Artworks.AddOrUpdate(a => a.Id,
                    new Artwork { Id = 1, ArtistId = 1, Description = "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much", Title = "March", ArtworkUrl = "sourcehinh/1.jpg" },
                    new Artwork { Id = 2, ArtistId = 1, Description = "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much", Title = "March", ArtworkUrl = "sourcehinh/2.jpg" },
                    new Artwork
                    {
                        Id = 3,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/3.jpg"
                    },
                    new Artwork
                    {
                        Id = 4,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/4.jpg"
                    },
                    new Artwork
                    {
                        Id = 5,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/5.jpg"
                    },
                    new Artwork
                    {
                        Id = 6,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/6.jpg"
                    },
                    new Artwork
                    {
                        Id = 7,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/7.jpg"
                    },
                    new Artwork
                    {
                        Id = 8,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/8.jpg"
                    },
                    new Artwork
                    {
                        Id = 9,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/9.jpg"
                    },
                    new Artwork
                    {
                        Id = 10,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/10.jpg"
                    },
                    new Artwork
                    {
                        Id = 11,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/11.jpg"
                    },
                    new Artwork
                    {
                        Id = 12,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/12.jpg"
                    },
                    new Artwork
                    {
                        Id = 13,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/13.jpg"
                    },
                    new Artwork
                    {
                        Id = 14,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/14.jpg"
                    },
                    new Artwork
                    {
                        Id = 15,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/15.jpg"
                    },
                    new Artwork
                    {
                        Id = 16,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/16.jpg"
                    },
                    new Artwork
                    {
                        Id = 17,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/17.jpg"
                    },
                    new Artwork
                    {
                        Id = 18,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/18.jpg"
                    },
                    new Artwork
                    {
                        Id = 19,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/19.jpg"
                    },
                    new Artwork
                    {
                        Id = 20,
                        ArtistId = 1,
                        Description =
                            "Collaborative project I did along with Kieran Mckay as part of our sharing knowledge. We wanted to join forces and teach each other knowledge about our techniques. We started with traditional exploration sketches and after brainstorm we went with his sketch. I started modelling and we continued work back and forth till the final piece. Was so much",
                        Title = "March",
                        ArtworkUrl = "sourcehinh/20.jpg"
                    });
                #endregion
            }
        }
    }
}
