using SkillMatcher;

namespace SkillTests
{
    public class UnitTest1
    {
        [Fact]
        public void MatchOneCandidateWithOneSkill()
        {
            // arrange
            IJob job = new TestJob();
            ICandidate candidate = new TestCandidate();
            // act
            var result = SkillMatcher.SkillMatcher.PercentageOfMatch(job, candidate);
            // assert
            Assert.True(result > 99.99f);
        }

        [Fact]
        public void MatchOneCandidateWithJobNoSkillsRequired()
        {

        }
    }
}