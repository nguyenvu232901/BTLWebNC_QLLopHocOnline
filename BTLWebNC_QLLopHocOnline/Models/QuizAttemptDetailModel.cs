using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLWebNC_QLLopHocOnline.Models
{
    [Table("QuizAttemptDetails")]
    [PrimaryKey(nameof(Id))]
    public class QuizAttemptDetailModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        public required int QuizAttemptId { get; set; }
        public required int QuestionId { get; set; }
        public required int Answered { get; set; }
        public required bool IsCorrect { get; set; }
    }
}
