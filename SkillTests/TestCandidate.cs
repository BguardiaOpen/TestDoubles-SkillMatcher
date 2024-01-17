using SkillMatcher;

namespace SkillTests
{
    public class TestCandidate : ICandidate
    {
        string ICandidate.Name { get => "Bruno"; set => throw new NotImplementedException(); }
        List<string> ICandidate.Experience {
            get {
                List<string> result = new List<string>
                {
                    "Microsoft",
                    "Amazon",
                    "Starbucks"
                };
                return result;
            }
            set => throw new NotImplementedException(); }
        List<string> ICandidate.Education { 
        get {
                List<string> result = new List<string>
                {
                    "SeattleU"
                };
                return result;
            }
            set => throw new NotImplementedException();
        }
        List<ISkill> ICandidate.Skill
        {
            get {
                List<ISkill> result = new List<ISkill>
                {
                    new TestSkill("C#", 3)
                };
                return result;
            }

            set => throw new NotImplementedException(); }

        }
    }
