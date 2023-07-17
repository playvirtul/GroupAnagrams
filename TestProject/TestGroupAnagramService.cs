namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void GroupAnagrams_ShouldGroupArrayFirst()
    {
        // Arrange
        var array = new[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };

        // Act
        var resultList = GroupAnagramService.GroupAnagrams(array);

        // Assert
        var successResult = new List<List<string>>()
        {
            new() { "ток", "кот", "Кто" },
            new() { "рост", "торс" },
            new() { "фывап" },
            new() { "рок" }
        };

        Assert.Equal(resultList, successResult);
    }

    [Fact]
    public void GroupAnagrams_ShouldGroupArraySecond()
    {
        // Arrange
        var array = new[] { "111", "111", "ко1111", "11ко11", "0", "0", "", "" };

        // Act
        var resultList = GroupAnagramService.GroupAnagrams(array);

        // Assert
        var successResult = new List<List<string>>()
        {
            new() { "111", "111" },
            new() { "ко1111", "11ко11" },
            new() { "0", "0" },
            new() { "", "" }
        };

        Assert.Equal(resultList, successResult);
    }
    
    [Fact]
    public void GroupAnagrams_ShouldReturnOneElement()
    {
        // Arrange
        var array = new[] { "кот" };

        // Act
        var resultList = GroupAnagramService.GroupAnagrams(array);

        // Assert
        var successResult = new List<List<string>>()
        {
            new() { "кот"}
        };

        Assert.Equal(resultList, successResult);
    }
}