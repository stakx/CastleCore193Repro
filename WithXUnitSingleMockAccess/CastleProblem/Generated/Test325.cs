using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test325
    {
        private readonly Mock<IClass325> aClass;

        public Test325()
        {
            this.aClass = new Mock<IClass325>();
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