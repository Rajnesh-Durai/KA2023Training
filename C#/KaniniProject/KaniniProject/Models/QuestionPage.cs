using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class QuestionPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("AddQuestion")]
        public string Question { get; set; } = string.Empty;
        [ForeignKey("Assessment")]
        public int AssessmentId { get; set; }

    }
}
