using Crazy_Panda_Test_Task;
namespace UnitTest
{
    public class Test
    {
        [Fact]
        public void MakeTest()
        {
            //test 1
            List<uint> list1 = new() { 5, 3, 9, 11 };
            
            Function.FindElementsForSum(list1, 8, out int start, out int end);
            Assert.True(start == 0 && end == 2);

            Function.FindElementsForSum(list1, 20, out start, out end);
            Assert.True(start == 2 && end == 4);

            Function.FindElementsForSum(list1, 28, out start, out end);
            Assert.True(start == 0 && end == 4);
        }
    }
}
