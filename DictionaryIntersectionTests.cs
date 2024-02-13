using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> firstDictionary = new();
        Dictionary<string, int> secondDictionary = new();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect
            (firstDictionary, secondDictionary);

        //Assert
        Assert.AreEqual(0, result.Count);
        Assert.That(result, Has.Count.EqualTo(0));
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // TODO: finish this test
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // TODO: finish this test
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // TODO: finish this test
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // TODO: finish this test
    }
}
