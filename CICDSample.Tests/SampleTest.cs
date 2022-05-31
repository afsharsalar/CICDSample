namespace CICDSample.Tests
{
    public class SampleTest
    {
        [Fact]
        public void Sample()
        {
            //arrange
            var mytest = "test";

            //act
            bool result= (mytest=="test");

            //assert

            Assert.True(result);
        }
    }
}