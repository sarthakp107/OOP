using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Clock
{
	public class Clock
	{
		Counter _second  = new Counter("second");
        Counter _minute = new Counter("minute");
        Counter _hour = new Counter("hour");

        public Clock()
		{
			

		}
		public void Tick()
		{
			// if the method is called increase by one second
			_second.Increment();
			if(_second.Ticks>59)
			{
				_minute.Increment();
				_second.Reset();
				if(_minute.Ticks>59)
				{
					_hour.Increment();
					_minute.Reset();
					_second.Reset();
					 
					if(_hour.Ticks>23)
					{
                        _hour.Reset();
					}
				}
			}
		}
		public void Reset()
		{
			_second.Reset();
            _minute.Reset();
            _hour.Reset();
        }
		public string CurrentTime()
		{
			return $"{_hour.Ticks:D2}:{_minute.Ticks:D2}:{_second.Ticks:D2}";
		}
	}
}

