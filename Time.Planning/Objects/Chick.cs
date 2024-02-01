using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time.Planning.Objects;

public class Chick
{
    public int ChickId { get; set; }
    public string Title { get; set; }
    public TimeSpan Length { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string ShowTime { get; set; }

    public void CalculateTime()
    {
        Length = EndTime - StartTime;
        ShowTime = $"{Length.Hours} : {Length.Minutes}";
    }

}
