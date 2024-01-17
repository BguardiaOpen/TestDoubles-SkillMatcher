using SkillMatcher;

namespace SkillTests
{
    public class TestSkill:ISkill
    {
        string _name;
        int _years;
        public TestSkill(string name, int yearsOfExperience)
        {
            _name = name;
            _years = yearsOfExperience;
        }

        public string Name { get => _name; set => throw new NotImplementedException(); }
        public int Years { get => _years;set => throw new NotImplementedException(); }

    }
}
