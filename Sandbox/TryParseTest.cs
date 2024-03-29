namespace Sandbox;

public class Tests
{
    List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
    {
        countOfNonPositive = 0;
        var result = new List<int>();

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                result.Add(number);
            }
            else
            {
                countOfNonPositive++;
            }
        }

        return result;
    }

    [Test]
    public void Out_Test()
    {
        var numbers = new[] { 10, -8, 2, 12, -17 };
        var countOfNonPositive = 0;
        var onlyPositive = GetOnlyPositive(numbers, out countOfNonPositive);
        var expected = new[] { 10, 2, 12 };

        Assert.That(onlyPositive, Is.EquivalentTo(expected));
        Assert.That(countOfNonPositive, Is.EqualTo(2));
    }

    [Test]
    public void TryParse_Test()
    {
        int.TryParse("5", out int five);
        int.TryParse("hello", out int notFive);
        Assert.That(five, Is.EqualTo(5));
        Assert.That(notFive, Is.EqualTo(0));
    }
}