using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test282
    {
        private readonly Mock<IClass282> aClass;

        public Test282()
        {
            this.aClass = new Mock<IClass282>();
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