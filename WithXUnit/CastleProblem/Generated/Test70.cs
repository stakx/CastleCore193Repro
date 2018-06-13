using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test70
    {
        private readonly Mock<IClass70> aClass;

        public Test70()
        {
            this.aClass = new Mock<IClass70>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}