namespace test;

public class Day2Tests
{
    [Fact]
    public void Example1()
    {
        Day2.ProcessPart1(
"""
7 6 4 2 1
1 2 7 8 9
9 7 6 2 1
1 3 2 4 5
8 6 4 4 1
1 3 6 7 9
""".AsSpan())
            .Should()
            .Be(2);
    }
    
    [Fact]
    public void Example1V2()
    {
        Day2.ProcessPart1V2(
                """
                    24 25 28 31 28
                    """.AsSpan())
            .Should()
            .Be(0);
    }
    
    [Fact]
    public void Input1()
    {
        Day2.ProcessPart1(File.ReadAllText("inputs/day2.txt"))
            .Should()
            .Be(379);
    }
    
    [Fact]
    public void Input2()
    {
        Day2.ProcessPart2(File.ReadAllText("inputs/day2.txt"))
            .Should()
            .Be(430);
    }
    
    

    [Fact]
    public void Example2()
    {
        Day2.ProcessPart2(
                """
                    7 6 4 2 1
                    1 2 7 8 9
                    9 7 6 2 1
                    1 3 2 4 5
                    8 6 4 4 1
                    1 3 6 7 9
                    1 3 5 8 4
                    9 1 2 3 4
                    """.AsSpan())
            .Should()
            .Be(6);
    }
}