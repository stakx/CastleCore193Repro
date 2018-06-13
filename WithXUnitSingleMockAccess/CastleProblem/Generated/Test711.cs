using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test711
    {
        private readonly Mock<IClass711> aClass;

        public Test711()
        {
            this.aClass = new Mock<IClass711>();
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