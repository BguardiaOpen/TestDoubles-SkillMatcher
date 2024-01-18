namespace SkillMatcher
{
    public class SkillMatcher
    {
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

        public static List<float> PercentageMatchPerSkill(IJob job, ICandidate candidate)
        {
            return new List<float>();
        }
    }
}