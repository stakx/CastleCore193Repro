using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test112
    {
        private readonly Mock<IClass112> aClass;

        public Test112()
        {
            this.aClass = new Mock<IClass112>();
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