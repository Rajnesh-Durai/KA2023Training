using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessmentAdmin.Models
{
    public class AddQuestion
    {
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("QuestionType")]
        public int QuestionTypeId { get; set; }
        public string Question { get; set; }=string.Empty;
        public string Option1 { get; set; } = string.Empty;
        public string Option2 { get; set; } = string.Empty;
        public string Option3 { get; set; } = string.Empty;
        public string Option4 { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;

    }
}
