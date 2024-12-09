namespace advent_of_code_2024;

public static class Day1
{
    public static int ProcessPart1(ReadOnlySpan<char> input)
    {
        var (left, right) = GetLists(input);

        var orderedLeft = left.Order();
        var orderedRight = right.Order();
        var itemCount = orderedLeft.Count();
        var output = 0;
        for (var i = 0; i < itemCount; i++)
        {
            output += Math.Abs(orderedLeft.ElementAt(i) - orderedRight.ElementAt(i));
        }

        return output;
    }

    public static int ProcessPart2(ReadOnlySpan<char> input)
    {
        var (left, right) = GetLists(input);

        var itemCount = left.Count();
        var output = 0;
        for (var i = 0; i < itemCount; i++)
        {
            var number = left.ElementAt(i);
            output += number * right.Count(c => c == number);
        }

        return output;
    }

    public static (List<int> left, List<int> right) GetLists(ReadOnlySpan<char> input)
    {
        var left = new List<int>();
        var right = new List<int>();

        var split = input.Split('\n');
        foreach (var range in split)
        {
            var line = input[range];

            var lineIndex = 0;
            while (line[lineIndex] != ' ')
            {
                lineIndex++;
            }
            left.Add(int.Parse(line[0..lineIndex]));
            while (line[lineIndex] == ' ')
            {
                lineIndex++;
            }
            right.Add(int.Parse(line[lineIndex..]));
        }

        return (left, right);
    }
}