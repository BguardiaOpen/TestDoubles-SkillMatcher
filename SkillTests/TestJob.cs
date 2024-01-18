using SkillMatcher;

namespace SkillTests
{
    public class TestJob : IJob
    {
        string IJob.Title { get => "Sr SDE" ; set => throw new NotImplementedException(); }
        float IJob.Salary { get => 100000.0f; set => throw new NotImplementedException(); }
        List<ISkill> IJob.MandatorySkills {
            get
            {
                List<ISkill> skills = new List<ISkill>{
                    new TestSkill("C#", 3)
                };
                return skills;
            }
            
            set => throw new NotImplementedException(); }
        List<ISkill> IJob.PreferredSkills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
