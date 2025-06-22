using System.ComponentModel.DataAnnotations;

namespace CVProfileAPI.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ExperienceYears { get; set; }

        public string SkillLevel { get; set; }
    }
}
