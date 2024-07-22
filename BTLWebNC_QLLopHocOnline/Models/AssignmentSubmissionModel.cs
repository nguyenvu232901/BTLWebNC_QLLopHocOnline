using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTLWebNC_QLLopHocOnline.Models
{
    [Table("AssignmentSubmission")]
    [PrimaryKey(nameof(Id))]
    public class AssignmentSubmissionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Primary key

        [ForeignKey(nameof(Assignment))]

        public required int AssignmentId { get; set; }
        public required AssignmentModel Assignment { get; set; } // Navigation property for the Assignment

        [ForeignKey(nameof(User))]
        public required int UserId { get; set; }

        public required UserModel User { get; set; } // Navigation property for the Assignment


        public string? UploadedFile { get; set; }
        public double? Grade { get; set; }
    }
}
