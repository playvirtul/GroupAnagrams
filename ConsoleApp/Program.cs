var array = new[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };

var result = GroupAnagramService.GroupAnagrams(array);

foreach (var list in result)
{
    foreach (var t in list)
    {
        Console.Write(t + " ");
    }

    Console.WriteLine();
}

public static class GroupAnagramService
{
    public static List<List<string>> GroupAnagrams(IEnumerable<string> words)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var word in words)
        {
            char[] arr = word.ToLower().ToCharArray();
            Array.Sort(arr);

            var sorted = new string(arr);
            if (dictionary.TryGetValue(sorted, out var value))
            {
                value.Add(word);
            }
            else
            {
                dictionary.Add(sorted, new List<string> { word });
            }
        }

        var groupAnagrams = dictionary.Values.ToList();
        return groupAnagrams;
    }
}
