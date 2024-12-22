namespace test;

public class Day5Tests
{
    [Fact]
    public void Example1()
    {
        Day5.ProcessPart1(
                """
                47|53
                97|13
                97|61
                97|47
                75|29
                61|13
                75|53
                29|13
                97|29
                53|29
                61|53
                97|53
                61|29
                47|13
                75|47
                97|75
                47|61
                75|61
                47|29
                75|13
                53|13
                
                75,47,61,53,29
                97,61,53,29,13
                75,29,13
                75,97,47,61,53
                61,13,29
                97,13,75,29,47
                """)
            .Should()
            .Be(143);
    }
    
    [Fact]
    public void Input1()
    {
        Day5.ProcessPart1(
                File.ReadAllText("inputs/day5.txt"))
            .Should()
            .Be(6949);
    }
    
    [Fact]
    public void Example2()
    {
        Day5.ProcessPart2(
                """
                47|53
                97|13
                97|61
                97|47
                75|29
                61|13
                75|53
                29|13
                97|29
                53|29
                61|53
                97|53
                61|29
                47|13
                75|47
                97|75
                47|61
                75|61
                47|29
                75|13
                53|13
                
                75,47,61,53,29
                97,61,53,29,13
                75,29,13
                75,97,47,61,53
                61,13,29
                97,13,75,29,47
                """)
            .Should()
            .Be(123);
    }
    
    [Fact]
    public void Input2()
    {
        Day5.ProcessPart2(
                File.ReadAllText("inputs/day5.txt"))
            .Should()
            .Be(4145);
        
    }
}