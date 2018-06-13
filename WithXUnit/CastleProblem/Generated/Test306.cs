using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test306
    {
        private readonly Mock<IClass306> aClass;

        public Test306()
        {
            this.aClass = new Mock<IClass306>();
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