namespace Clock;

public class CounterTest
{
    Counter _countertest;

    [SetUp]
    public void Setup()
    {
        _countertest = new Counter("Test");
    }

    [Test]
    public void CounterStartsAtZero()
    {
        Assert.That(_countertest.Ticks, Is.EqualTo(0));
    }



    //Incrementing the counter multiple times increases the count by the same amount
    [TestCase(10, 10)]
    public void IncrementMultipleTest(int ticks, int result)
    {
        for (int i = 0; i < ticks; i++)
        {
            _countertest.Increment();

        }
        Assert.That(_countertest.Ticks, Is.EqualTo(result));

    }
    //resetting the timer sets the count to 0
    [Test]
    public void ResetTest()
    {
        _countertest.Increment();
        _countertest.Reset();
        Assert.That(_countertest.Ticks, Is.EqualTo(0));
    }

    //Incrementing the counter adds one to the count
    [Test]
    public void IncrementTest()
    {
        int initialCount = _countertest.Ticks;
        _countertest.Increment();
        Assert.That(_countertest.Ticks, Is.EqualTo(initialCount + 1));
    }
}
