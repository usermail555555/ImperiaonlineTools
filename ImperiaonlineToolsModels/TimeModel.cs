using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsModels
{
    public class TimeModel
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }

        public TimeModel() { }
        public TimeModel(string timeModel)
        {
            this.Hour = int.Parse(timeModel.Substring(0, 2));
            this.Min = int.Parse(timeModel.Substring(3, 2));
            this.Sec = int.Parse(timeModel.Substring(6, 2));
        }

        public TimeModel(int number)
        {
            this.Hour = number / 3600;
            this.Min = (number % 3600) / 60;
            this.Sec = (number % 3600) % 60;
        }

        public TimeModel Substract(TimeModel time)
        {
            TimeModel Result = new TimeModel();
            {
                Result.Hour = this.Hour - time.Hour;
                Result.Min = this.Min - time.Min;
                Result.Sec = this.Sec - time.Sec;

                if (Result.Hour < 0)
                {
                    Result.Hour = Result.Hour + 24;
                }
                if (Result.Min < 0)
                {
                    Result.Min = Result.Min + 60;
                    Result.Hour = Result.Hour - 1;
                }
                if (Result.Sec < 0)
                {
                    Result.Sec = Result.Sec + 60;
                    Result.Min = Result.Min - 1;
                }
                return Result;
            }
        }

        public TimeModel Add(TimeModel time)
        {
            TimeModel Result = new TimeModel();
            {
                Result.Hour = this.Hour + time.Hour;
                Result.Min = this.Min + time.Min;
                Result.Sec = this.Sec + time.Sec;

                if (Result.Hour > 23)
                {
                    Result.Hour = Result.Hour - 24;
                }
                if (Result.Min > 59)
                {
                    Result.Min = Result.Min - 60;
                    Result.Hour = Result.Hour + 1;
                }
                if (Result.Sec > 59)
                {
                    Result.Sec = Result.Sec - 60;
                    Result.Min = Result.Min + 1;
                }
            }
            return Result;
        }

        public override string ToString()
        {
            string hour, min, sec;
            if (this.Hour < 10)
            {
                hour = "0" + this.Hour + ":";
            }
            else
            {
                hour = this.Hour + ":";
            }
            if (this.Min < 10)
            {
                min = "0" + this.Min + ":";
            }
            else
            {
                min = this.Min + ":";
            }
            if (this.Sec < 10)
            {
                sec = "0" + this.Sec + ":";
            }
            else
            {
                sec = this.Sec.ToString();
            }

            return hour + min + sec;
        }
    }
}
