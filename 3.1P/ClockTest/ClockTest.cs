
namespace Clock;

public class ClockTest
{
    Clock _clock;

    [SetUp]
    public void Setup()
    {
        _clock = new Clock();
    }

    [Test]
    public void InitialClock()
    {
        Assert.That(_clock.CurrentTime(), Is.EqualTo("00:00:00"));
    }

    [Test]
    public void ResetTest()
    {
        for (int i = 0; i <= 10; i++)
        {
            _clock.Tick();

        }
        _clock.Reset();
        Assert.That(_clock.CurrentTime(), Is.EqualTo("00:00:00"));

    }
    [TestCase(1, "00:00:01")]
    [TestCase (60 , "00:01:00")]
    [TestCase(86399, "23:59:59")]
    public void TestRun(int tick , string currentTime)
    {
        
        for( int i = 0; i < tick; i++)
        {
            _clock.Tick();
        }
        Assert.That(_clock.CurrentTime(), Is.EqualTo(currentTime));
    }
}
