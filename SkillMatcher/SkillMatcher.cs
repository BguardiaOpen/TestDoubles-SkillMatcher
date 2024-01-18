namespace SkillMatcher
{
    /// <summary>
    /// The SkillsMatcher module will provide methods to analyze how well a
    /// Candidate matches the requirements of the Job
    /// </summary>
    public class SkillMatcher
    {
        // Calculating a percentage(0-100+) of match between a job and a candidate
        public static float PercentageOfMatch(IJob job, ICandidate candidate)
        {
            int skillsCount = 0;
            float percentageSum = 0;
            foreach (var jobskill in job.MandatorySkills)
            {
                skillsCount++;
                foreach (var candidateSkill in candidate.Skill)
                {
                    if ( jobskill.Name == candidateSkill.Name )
                    {
                        float skillMatch = (float)candidateSkill.Years / (float)jobskill.Years;
                        percentageSum += skillMatch;
                    }
                }
            }
            if (skillsCount > 0) { return 100.0f * percentageSum / skillsCount; }
            return 0.0f;
        }

        //Calculating a list of percentages(0-100+) of match between each skill defined in a job and in a candidate
        public static List<float> PercentageMatchPerSkill(IJob job, ICandidate candidate)
        {
            return new List<float>();
        }
    }
}