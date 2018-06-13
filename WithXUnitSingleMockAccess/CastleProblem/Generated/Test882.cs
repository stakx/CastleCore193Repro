using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test882
    {
        private readonly Mock<IClass882> aClass;

        public Test882()
        {
            this.aClass = new Mock<IClass882>();
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