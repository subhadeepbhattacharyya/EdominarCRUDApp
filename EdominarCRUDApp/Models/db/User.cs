using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdominarCRUDApp.Models.db
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Mobile { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;

        public int StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public State State { get; set; }

        public int HobbyId { get; set; }
        [ForeignKey(nameof(HobbyId))]
        public Hobby Hobby { get; set; }



    }
}
