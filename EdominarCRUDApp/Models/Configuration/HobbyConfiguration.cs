using EdominarCRUDApp.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EdominarCRUDApp.Models.Configuration
{
    public class HobbyConfiguration : IEntityTypeConfiguration<Hobby>
    {
        public void Configure(EntityTypeBuilder<Hobby> builder)
        {
            var hobbyData = new String[] {
                "Football" , "Movie Binge" , "Reading" ,
                "Music" , "Photography" , "Cooking" , "Painting"
            };

            var hobbies = new List<Hobby>();
            int count = 1;
            foreach (var hobby in hobbyData)
            {
                var st = new Hobby()
                {
                    Id = count++,
                    Name = hobby
                };
                hobbies.Add(st);
            }
            builder.HasData(hobbies);
        }
    }
}
