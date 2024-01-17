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
            Assert.Equal(100.0f, result, 0.1f);
        }

        [Fact]
        public void MatchOneCandidateWithJobNoSkillsRequired()
        {

        }
    }
}