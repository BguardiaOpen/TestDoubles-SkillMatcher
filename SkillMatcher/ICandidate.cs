using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatcher
{
    public interface ICandidate
    {
        string Name { get; set;  }
        List<string> Experience { get; set; }
        List<string> Education { get; set; }
        List<ISkill> Skill { get; set; }
    }
}
