using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test37
    {
        private readonly Mock<IClass37> aClass;

        public Test37()
        {
            this.aClass = new Mock<IClass37>();
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