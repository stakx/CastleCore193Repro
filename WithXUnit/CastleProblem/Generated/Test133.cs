using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test133
    {
        private readonly Mock<IClass133> aClass;

        public Test133()
        {
            this.aClass = new Mock<IClass133>();
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