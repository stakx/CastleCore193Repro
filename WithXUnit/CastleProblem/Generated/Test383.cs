using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test383
    {
        private readonly Mock<IClass383> aClass;

        public Test383()
        {
            this.aClass = new Mock<IClass383>();
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