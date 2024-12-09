using System.Reflection.Emit;

namespace advent_of_code_2024;

public static class Day2
{
    public static int ProcessPart1(ReadOnlySpan<char> input)
    {
        var result = 0;
        var split = input.Split('\n');
        foreach (var range in split)
        {
            var line = input[range];

            var items = line.Split(' ');

            int last = -1;
            var direction = Direction.Unknown;
            foreach (var item in items)
            {
                if(last == -1)
                {
                    last = int.Parse(line[item]);
                }else
                {
                    var current = int.Parse(line[item]);
                    if(direction == Direction.Unknown)
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
                            goto next;
                        }
                    }

                    last = current;
                }
            }
            next:;


        }

        return result;
    }
    private enum Direction
    {
        Up,
        Down,
        Unknown,
    }
}

