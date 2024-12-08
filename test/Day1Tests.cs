using advent_of_code_2024.Day1;
using FluentAssertions;

namespace test;

public class Day1Tests
{

    [Fact]
    public void Example1()
    {
        Day1.ProcessPart1(
"""
3   4
4   3
2   5
1   3
3   9
3   3
""".AsSpan())
            .Should()
            .Be(11);
    }

    [Fact]
    public void Input1()
    {
        Day1.ProcessPart1(File.ReadAllText("Day1/input.txt"))
            .Should().Be(3508942);
    }

    [Fact]
    public void Example2()
    {
        Day1.ProcessPart2(
"""
3   4
4   3
2   5
1   3
3   9
3   3
""".AsSpan())
            .Should()
            .Be(31);
    }

    [Fact]
    public void Input2()
    {
        Day1.ProcessPart2(File.ReadAllText("Day1/input.txt"))
            .Should().Be(26593248);
    }
}