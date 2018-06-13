using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test18
    {
        private readonly Mock<IClass18> aClass;

        public Test18()
        {
            this.aClass = new Mock<IClass18>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}