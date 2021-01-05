using System.Collections.Generic;

namespace ConsoleAppThirdPartFirstLecture.Models
{
    public class PageViewModel
    {
        public string Header { get; set; }

        public Dictionary<int, string> Menu { get; set; }

        public string Footer { get; set; }
    }
}
