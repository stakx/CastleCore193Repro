using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test574
    {
        private readonly Mock<IClass574> aClass;

        public Test574()
        {
            this.aClass = new Mock<IClass574>();
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