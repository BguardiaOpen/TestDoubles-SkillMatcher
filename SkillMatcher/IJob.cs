
namespace SkillMatcher
{
    /// <summary>
    /// Jobs are positions available in the job market, defined by its title, salary and desired skills,
    /// separated in mandatory and nice to have ("preferred")
    /// </summary>
    public interface IJob
    {
        string Title { get; set; }
        float Salary { get; set; }
        List<ISkill> MandatorySkills { get; set; }
        List<ISkill> PreferredSkills { get; set; }
    }
}
