using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SkillAssessmentAdmin.Models
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }= string.Empty;

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set;}
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int NumberOfTopics { get; set; }
        public int NumberOfQuestions { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }
        public string Description { get; set; }=string.Empty;

    }
}
