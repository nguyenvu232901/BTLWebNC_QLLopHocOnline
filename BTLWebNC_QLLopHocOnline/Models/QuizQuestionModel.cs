using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLWebNC_QLLopHocOnline.Models
{
    [Table("QuizQuestions")]
    [PrimaryKey(nameof(Id))]
    public class QuizQuestionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        [ForeignKey(nameof(Quiz))]
        public required int QuizId { get; set; }
        public required QuizModel Quiz { get; set; }
        public required string Question { get; set; }
        public required string Answer1 { get; set; }
        public required string Answer2 { get; set; }
        public required string Answer3 { get; set; }
        public required string Answer4 { get; set; }

        [Range(1, 4, ErrorMessage = "Answer must be between 1 and 4")]
        public int Answer { get; set; }
    }
}
