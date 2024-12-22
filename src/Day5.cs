namespace advent_of_code_2024;

public static class Day5
{
    public static int ProcessPart1(string input)
    {
        var lines = input.Split('\n');
        var result = 0;
        var rules = new List<(string before, string other)>();

        var i = 0;
        while (lines[i].Trim() != string.Empty)
        {
            var s = lines[i].Split('|');
            rules.Add((s[0], s[1]));
            i++;
        }

        Console.WriteLine($"Rules: {rules.Count}");
        i++;
        while (i < lines.Length)
        {
            var pages = lines[i].Split(',');
            for (var j = 0; j < pages.Length; j++)
            {
                var page = pages[j];
                var relatedRules = rules.Where(x => x.before == page).Select(c => c.other);
                var pagesBefore = pages.Take(j);
                if (pagesBefore.Intersect(relatedRules).Count() > 0)
                {
                    goto nextPage;
                }
            }

            Console.WriteLine($"Correct page order: {lines[i]}");
            Console.WriteLine($"Adding {pages[pages.Length / 2]}");
            result += int.Parse(pages[pages.Length / 2]);

            nextPage:
            i++;
        }

        return result;
    }

    public static int ProcessPart2(string input)
    {
        var lines = input.Split('\n');
        var result = 0;
        var rules = new List<(string before, string other)>();

        var i = 0;
        while (lines[i].Trim() != string.Empty)
        {
            var s = lines[i].Split('|');
            rules.Add((s[0], s[1]));
            i++;
        }

        Console.WriteLine($"Rules: {rules.Count}");
        i++;
        while (i < lines.Length)
        {
            var pages = lines[i].Split(',').ToList();
            i++;

            if (pages.IsOrdered(rules))
            {
                continue;
            }

            pages = pages.Order(rules);

            result += int.Parse(pages[pages.Count / 2]);
        }

        return result;
    }

    private static List<string> Order(this List<string> pages, List<(string before, string other)> rules)
    {
        while (!pages.IsOrdered(rules))
        {
            for (var j = 0; j < pages.Count; j++)
            {
                var page = pages[j];
                var relatedRules = rules.Where(x => x.before == page);
                var pagesBefore = pages.Take(j);
                var intersect = pagesBefore.Intersect(relatedRules.Select(c => c.other)).ToList();
                if (intersect.Any())
                {
                    var firstConflictingIndex = intersect.Select(c => pages.IndexOf(c)).Min();
                    pages[j] = pages[firstConflictingIndex];
                    pages[firstConflictingIndex] = page;
                    goto breakFor;
                }
            }
            breakFor: ;
        }

        return pages;
    }

    private static bool IsOrdered(this List<string> pages, List<(string before, string other)> rules)
    {
        for (var j = 0; j < pages.Count; j++)
        {
            var page = pages[j];
            var relatedRules = rules.Where(x => x.before == page);
            var pagesBefore = pages.Take(j);
            var intersect = pagesBefore.Intersect(relatedRules.Select(c => c.other)).ToList();
            if (intersect.Any())
            {
                return false;
            }
        }

        return true;
    }
}