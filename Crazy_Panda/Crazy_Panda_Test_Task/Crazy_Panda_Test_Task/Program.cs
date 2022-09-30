// example
using Crazy_Panda_Test_Task;

List<uint> mockList = new()
{
    1, 4, 6, 1, 25, 13, 15
};

Function.FindElementsForSum(mockList, 11, out int start, out int end);
Console.WriteLine("\n\n\n\tstart is : " + start + "\n\tend is : " + end);