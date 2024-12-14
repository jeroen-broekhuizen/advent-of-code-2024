namespace advent_of_code_2024;

public static class Day4
{
    public static int ProcessPart1(string input)
    {
        var result = 0;
        var split = input.Split('\n');
        for (var i = 0; i < split.Length; i++)
        {
            for (var j = 0; j < split[i].Length; j++)
            {
                // horizontal 
                if (j <= split[i].Length - 4 &&
                    (
                        // xmas
                        split[i][j] == 'X' && split[i][j + 1] == 'M' && split[i][j + 2] == 'A' && split[i][j + 3] == 'S'|| 
                        // samx
                        split[i][j] == 'S' && split[i][j + 1] == 'A' && split[i][j + 2] == 'M' && split[i][j + 3] == 'X'
                     ))
                {
                    Console.WriteLine($"Horizontal position: {j}, {i}");
                    result++;
                }
                
                // vertical 
                if (i <= split.Length - 4 &&
                    (
                        // xmas
                        split[i][j] == 'X' && split[i+1][j] == 'M' && split[i+2][j] == 'A' && split[i+3][j] == 'S'|| 
                        // samx
                        split[i][j] == 'S' && split[i+1][j] == 'A' && split[i+2][j] == 'M' && split[i+3][j] == 'X'
                    ))
                {
                    Console.WriteLine($"Vertical position: {j}, {i}");
                    result++;
                }
                
                // diagonal \/> 
                if (i <= split.Length - 4 && j <= split[i].Length - 4 &&
                    (
                        // xmas
                        split[i][j] == 'X' && split[i+1][j+1] == 'M' && split[i+2][j+2] == 'A' && split[i+3][j+3] == 'S'|| 
                        // samx
                        split[i][j] == 'S' && split[i+1][j+1] == 'A' && split[i+2][j+2] == 'M' && split[i+3][j+3] == 'X'
                    ))
                {
                    Console.WriteLine($"Diagonal \\/> position: {j}, {i}");
                    result++;
                }
                
                // diagonal /\>
                if (i >= 3 && j <= split[i].Length - 4 &&
                    (
                        // xmas
                        split[i][j] == 'X' && split[i-1][j+1] == 'M' && split[i-2][j+2] == 'A' && split[i-3][j+3] == 'S'|| 
                        // samx
                        split[i][j] == 'S' && split[i-1][j+1] == 'A' && split[i-2][j+2] == 'M' && split[i-3][j+3] == 'X'
                    ))
                {
                    Console.WriteLine($"Diagonal /\\> position: {j}, {i}");
                    result++;
                }
                
            }
        }

        return result;
    }

    public static int ProcessPart2(string input)
    {
        var result = 0;
        var split = input.Split('\n');
        for (var i = 0; i < split.Length - 2; i++)
        {
            for (var j = 0; j < split[i].Length -2; j++)
            {
                if (split[i][j] == 'M' && split[i + 2][j] == 'M' && split[i + 1][j + 1] == 'A' &&
                    split[i][j + 2] == 'S' && split[i + 2][j + 2] == 'S' || 
                    split[i][j] == 'S' && split[i + 2][j] == 'S' && split[i + 1][j + 1] == 'A' &&
                    split[i][j + 2] == 'M' && split[i + 2][j + 2] == 'M'  ||
                    split[i][j] == 'M' && split[i + 2][j] == 'S' && split[i + 1][j + 1] == 'A' &&
                    split[i][j + 2] == 'M' && split[i + 2][j + 2] == 'S'  ||
                    split[i][j] == 'S' && split[i + 2][j] == 'M' && split[i + 1][j + 1] == 'A' &&
                    split[i][j + 2] == 'S' && split[i + 2][j + 2] == 'M' )
                {
                    result++;
                }
            }
        }
        return result;
    }
}