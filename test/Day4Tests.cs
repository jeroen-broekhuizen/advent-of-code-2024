namespace test;

public class Day4Tests
{
    [Fact]
    public void Example1()
    {
        Day4.ProcessPart1(
                """
                    MMMSXXMASM
                    MSAMXMSMSA
                    AMXSXMAAMM
                    MSAMASMSMX
                    XMASAMXAMM
                    XXAMMXXAMA
                    SMSMSASXSS
                    SAXAMASAAA
                    MAMMMXMMMM
                    MXMXAXMASX
                    """)
            .Should()
            .Be(18);
    }
    
    [Fact]
    public void Input1()
    {
        Day4.ProcessPart1(
                File.ReadAllText("inputs/day4.txt"))
            .Should()
            .Be(2593);
    }
    
    [Fact]
    public void Example2()
    {
        Day4.ProcessPart2(
                """
                MMMSXXMASM
                MSAMXMSMSA
                AMXSXMAAMM
                MSAMASMSMX
                XMASAMXAMM
                XXAMMXXAMA
                SMSMSASXSS
                SAXAMASAAA
                MAMMMXMMMM
                MXMXAXMASX
                """)
            .Should()
            .Be(9);
    }
    
    [Fact]
    public void Input2()
    {
        Day4.ProcessPart2(
                File.ReadAllText("inputs/day4.txt"))
            .Should()
            .Be(1950);
    }
}