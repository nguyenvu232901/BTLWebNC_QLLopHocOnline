using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLWebNC_QLLopHocOnline.Models
{
    [Table("QuizAttempts")]
    [PrimaryKey(nameof(Id))]
    public class QuizAttemptModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        [ForeignKey(nameof(Quiz))]
        public required int QuizId { get; set; }
        public required QuizModel Quiz { get; set; }
        [ForeignKey(nameof(User))]
        public required int UserId { get; set; }
        public required UserModel User { get; set; }
        public int Correct { get; set; }
        public int Wrong { get; set; }
        public double Result { get; set; }
    }
}
