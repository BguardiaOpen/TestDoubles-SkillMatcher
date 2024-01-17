using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMatcher
{
    public interface ISkill
    {
        public string Name { get; set; }
        public int Years { get; set; }
    }
}
