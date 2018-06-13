using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test934
    {
        private readonly Mock<IClass934> aClass;

        public Test934()
        {
            this.aClass = new Mock<IClass934>();
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