using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDogApp.API.Models
{
    public class Like
    {
        [Key]
        [Column(Order = 1)]
        public int LikerId { get; set; }
        [ForeignKey("LikerId")]
        public User Liker { get; set; }

        [Key]
        [Column(Order = 2)]
        public int LikeeId { get; set; }
        [ForeignKey("LikeeId")]
        public User Likee { get; set; }
    }
}