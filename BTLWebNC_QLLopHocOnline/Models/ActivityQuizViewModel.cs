using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLWebNC_QLLopHocOnline.Models
{
    public class ActivityQuizViewModel
    {
      public required ActivityModel Activity { get; set; }
      public required MeetingModel Meeting { get; set; }
    }
}