using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test121
    {
        private readonly Mock<IClass121> aClass;

        public Test121()
        {
            this.aClass = new Mock<IClass121>();
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