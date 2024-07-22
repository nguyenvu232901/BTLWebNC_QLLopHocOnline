using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLWebNC_QLLopHocOnline.Models
{
    [Table("Quiz")]
    [PrimaryKey(nameof(Id))]
    public class QuizModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Passing grade must be greater than 0")]
        public required double PassingGrade { get; set; }
    }
}
