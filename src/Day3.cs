using System.Text.RegularExpressions;

namespace advent_of_code_2024;

public class Day3
{
    private static Regex part1Regex = new Regex("mul\\((\\d{1,3}),(\\d{1,3})\\)", RegexOptions.Compiled);
    private static Regex part2Regex = new Regex("mul\\((\\d{1,3}),(\\d{1,3})\\)|do\\(\\)|don't\\(\\)", RegexOptions.Compiled);

    public static int ProcessPart1(ReadOnlySpan<char> input)
    {
        return Generic.RunForEachLine(input, Part1);
    }

    private static int Part1(ReadOnlySpan<char> line)
    {
        var matches = part1Regex.Matches(line.ToString());
        var result = 0;
        for (var i = 0; i < matches.Count; i++)
        {
            result += int.Parse(matches[i].Groups[1].Value) * int.Parse(matches[i].Groups[2].Value);
        }
        return result;
    }

    public static int ProcessPart2(ReadOnlySpan<char> input)
    {
        return Part2(input);
    }

    private static int Part2(ReadOnlySpan<char> line)
    {
        var matches = part2Regex.Matches(line.ToString());
        var result = 0;
        var enabled = true;
        for (var i = 0; i < matches.Count; i++)
        {
            switch (matches[i].Groups[0].Value)
            {
                case "do()":
                    enabled = true;
                    continue;
                case "don't()":
                    enabled = false;
                    continue;
                default:
                    if (enabled)
                    {
                        result += int.Parse(matches[i].Groups[1].Value) * int.Parse(matches[i].Groups[2].Value);
                    }
                    break;
            }
        }
        return result;
    }
}