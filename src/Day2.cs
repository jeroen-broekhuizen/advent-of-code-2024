using System.Reflection.Emit;

namespace advent_of_code_2024;

public static class Day2
{
    public static int ProcessPart1(ReadOnlySpan<char> input)
    {
        return RunForEachLine(input, Part1);
    }
    
    public static int ProcessPart1V2(ReadOnlySpan<char> input)
    {
        return RunForEachLine(input, Part1V2);
    }

    private static int RunForEachLine(ReadOnlySpan<char> input, Func<ReadOnlySpan<char>, int> method)
    {
        var result = 0;
        var split = input.Split('\n');
        foreach (var range in split)
        {
            var line = input[range];

            result += method(line);
        }

        return result;
    }

    private static int Part1(ReadOnlySpan<char> line)
    {
        var items = line.Split(' ');

        int last = -1;
        var direction = Direction.Unknown;
        foreach (var item in items)
        {
            if (last == -1)
            {
                last = int.Parse(line[item]);
            }
            else
            {
                var current = int.Parse(line[item]);
                var diff = Math.Abs(current - last);
                if (diff is < 1 or > 3)
                {
                    return 0;
                }

                if (direction == Direction.Up && last < current)
                {
                    last = current;
                    continue;
                }
                if (direction == Direction.Up && last >= current)
                {
                    return 0;
                }
                if (direction == Direction.Down && last > current)
                {
                    last = current;
                    continue;
                }
                if (direction == Direction.Down && last <= current)
                {
                    return 0;
                }
                if (direction == Direction.Unknown)
                {
                    if (current > last)
                    {
                        direction = Direction.Up;
                    }
                    else if (current < last)
                    {
                        direction = Direction.Down;
                    }
                    else
                    {
                        return 0;
                    }
                    last = current;
                }
            }

                
        }

        return 1;
    }

    private static int Part1V2(ReadOnlySpan<char> line)
    {
        var items = line.Split(' ');
        List<int> values = [];
        foreach (var item in items)
        {
            values.Add(int.Parse(line[item]));
        }
        
        return IsValidNumbers(values) ? 1 : 0;
    }

    private static int Part2(ReadOnlySpan<char> line)
    {
        var items = line.Split(' ');
        List<int> values = [];
        foreach (var item in items)
        {
            values.Add(int.Parse(line[item]));
        }
        
        if (IsValidNumbers(values)) return 1;
        for (var i = 0; i < values.Count - 1; i++)
        {
            if (IsValidNumbers(values[0..i].Concat(values[(i+1)..]).ToList()))
            {
                return 1;
            }
        }

        return IsValidNumbers(values[0..^1])? 1 : 0;
    }

    private static bool IsValidNumbers(List<int> values)
    {
        var direction = Direction.Unknown;
        for (var i = 0; i < values.Count - 1; i++)
        {
            var current = values[i];
            var next = values[i + 1];
            var diff = Math.Abs(current - next);
            if (diff is < 1 or > 3)
            {
                return false;
            }
            if (i == 0)
            {
                if (current < next)
                {
                    direction = Direction.Up;
                }
                if (current > next)
                {
                    direction = Direction.Down;
                }
            }
            else
            {
                if (direction == Direction.Up && current > next)
                {
                    return false;
                }

                if (direction == Direction.Down && current < next)
                {
                    return false;
                }
            }
            
        }

        return true;
    }

    private enum Direction
    {
        Up,
        Down,
        Unknown,
    }

    public static int ProcessPart2(ReadOnlySpan<char> input)
    {
        return RunForEachLine(input, Part2);
    }
}