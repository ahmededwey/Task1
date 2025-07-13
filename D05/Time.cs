namespace D05
{
    public class Time
    {

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public Time AddingTwoTimes(Time T2)
        {
            return new Time(
                (this.Hour + T2.Hour + (this.Minute + T2.Minute) / 60) % 24,
                (this.Minute + T2.Minute) % 60,
                (this.Second + T2.Second) % 60
            );
        }
        public void ResetTime()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public void Adding30MinToTheTime(Time T)
        {
            if (T.Minute + 30 >= 60)
            {
                T.Hour = (T.Hour + 1) % 24;
                T.Minute = (T.Minute + 30) % 60; 
            }
            else
            {
                T.Minute += 30;
            }
        }
        public void TotalNumberOfSeconds()
        {
            int TotalSeconds = 0;
            TotalSeconds=(this.Hour *3600)+ (this.Minute*60) + (this.Second);
            Console.WriteLine(TotalSeconds);
        }

        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    }

}
