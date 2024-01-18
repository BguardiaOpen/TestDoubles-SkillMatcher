namespace SkillMatcher
{
    /// <summary>
    /// Skills are desired knowledge attributes, identified by its common name and years of experience
    /// </summary>
    public interface ISkill
    {
        public string Name { get; set; }
        public int Years { get; set; }
    }
}
