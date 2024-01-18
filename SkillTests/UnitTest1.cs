using SkillMatcher;
using NSubstitute;

namespace SkillTests
{
    public class UnitTest1
    {
        [Fact]
        public void MatchOneCandidateWithOneSkill()
        {
            // arrange

            // We create mocks for every interface we need within PercentageOfMatch.
            // But the next 10 linkes substitute 3 classes: TestCandidate, TestJob and TestSkill
            IJob job = Substitute.For<IJob>();
            ICandidate candidate = Substitute.For<ICandidate>();
            ISkill jobSkill = Substitute.For<ISkill>();
            jobSkill.Name.Returns("C#");
            jobSkill.Years.Returns(3);
            ISkill candidateSkill1 = Substitute.For<ISkill>();
            candidateSkill1.Name.Returns("C#");
            candidateSkill1.Years.Returns(5);
            ISkill candidateSkill2 = Substitute.For<ISkill>();
            candidateSkill2.Name.Returns("XUnit");
            candidateSkill2.Years.Returns(3);

            List<ISkill> jobSkills = new List<ISkill> { jobSkill };
            List<ISkill> candidateSkills = new List<ISkill> { candidateSkill1, candidateSkill2 };

            job.MandatorySkills.Returns(jobSkills);
            candidate.Skill.Returns(candidateSkills);
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