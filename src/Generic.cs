namespace advent_of_code_2024;

public static class Generic
{
    public static int RunForEachLine(ReadOnlySpan<char> input, Func<ReadOnlySpan<char>, int> method)
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
}