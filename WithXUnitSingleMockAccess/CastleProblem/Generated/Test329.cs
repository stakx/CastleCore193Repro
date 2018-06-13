using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test329
    {
        private readonly Mock<IClass329> aClass;

        public Test329()
        {
            this.aClass = new Mock<IClass329>();
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