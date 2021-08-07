using System;

namespace survey_with_validation.Models
{
    public class IndexView_Name
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
    }

    public class IndexView_Names
    {
        public string[] names {get; set;}
    }

    public class IndexView_Numbers
    {
        public int[] numbers {get; set;}
    }

    public class IndexView_Message
    {
      public string SingleMessage {get; set;}
    }
}
