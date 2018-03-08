using System.Collections.Generic;

namespace YkAbp.Application.Logging.Dto
{
    public class GetLatestWebLogsOutput
    {
        public List<string> LatestWebLogLines { get; set; }
    }
}
