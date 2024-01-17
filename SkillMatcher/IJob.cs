
namespace SkillMatcher
{
    public interface IJob
    {
        string Title { get; set; }
        float Salary { get; set; }
        List<ISkill> MandatorySkills { get; set; }
        List<ISkill> PreferredSkills { get; set; }
    }
}
