using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test531
    {
        private readonly Mock<IClass531> aClass;

        public Test531()
        {
            this.aClass = new Mock<IClass531>();
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