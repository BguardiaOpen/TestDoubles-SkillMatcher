namespace SkillMatcher
{
    /// <summary>
    /// A Candidate represent a person available in the job market, defined by their name 
    /// experience, education and qualifications (represented as skills)
    /// </summary>

    public interface ICandidate
    {
        string Name { get; set;  }
        List<string> Experience { get; set; }
        List<string> Education { get; set; }
        List<ISkill> Skill { get; set; }
    }
}
