using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test267
    {
        private readonly Mock<IClass267> aClass;

        public Test267()
        {
            this.aClass = new Mock<IClass267>();
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