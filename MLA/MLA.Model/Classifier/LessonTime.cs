using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLA.Model.Classifier
{
  public class LessonTime : Classifier
  {

    private int _hourBegin;
    private int _hourEnd;

    private int _minuteBegin;
    private int _minuteEnd;


    public LessonTime()
    {
      _hourBegin = 8;
      _minuteBegin = 15;
      _hourEnd = 9;
      _minuteEnd = 0;
    }

    public LessonTime(TimeSpan timeBegin, TimeSpan timeEnd)
    {
      HourBegin = timeBegin.Hours;
      MinuteBegin = timeBegin.Minutes;
      HourEnd = timeEnd.Hours;
      MinuteEnd = timeEnd.Minutes;
    }


    public int HourBegin {
      get => _hourBegin;
      set {
        if (value < 0) _hourBegin = 0;
        else _hourBegin = value % 24;
      }
    }

    public int HourEnd {
      get => _hourEnd;
      set {
        if (value < 0) _hourEnd = 0;
        else _hourEnd = value % 24;
      }
    }


    public int MinuteBegin {
      get => _minuteBegin;
      set {
        if (value < 0) _minuteBegin = 0;
        else _minuteBegin = value % 60;
      }
    }

    public int MinuteEnd {
      get => _minuteEnd;
      set {
        if (value < 0) _minuteEnd = 0;
        else _minuteEnd = value % 60;
      }
    }


    public override string ToString()
    {
      return $"{_hourBegin:00}:{_minuteBegin:00} - {_hourEnd:00}:{_minuteEnd:00}";
    }
  }
}
