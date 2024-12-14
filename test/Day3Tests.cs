namespace test;

public class Day3Tests
{
    [Fact]
    public void Example1()
    {
        Day3.ProcessPart1(
                """
                    xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
                    """.AsSpan())
            .Should()
            .Be(161);
    }
    
    [Fact]
    public void Input1()
    {
        Day3.ProcessPart1(
                File.ReadAllText("inputs/day3.txt"))
            .Should()
            .Be(159833790);
    }
    
    [Fact]
    public void Example2()
    {
        Day3.ProcessPart2(
                """
                    xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))
                    """.AsSpan())
            .Should()
            .Be(48);
    }
    
    [Fact]
    public void Input2()
    {
        Day3.ProcessPart2(
                File.ReadAllText("inputs/day3.txt"))
            .Should()
            .Be(89349241);
    }
}