using System.Collections.Generic;
using ConsoleLog4Net.Interfaces;
using ConsoleLog4Net.Model;

namespace ConsoleLog4Net.Requests
{
    public class SearchDevicesRequest : BaseRequest, ICriteria, IListDevices, IPagination
    {
        public IEnumerable<DeviceIdDto> Devices { get; set; }
        public CriteriasListDto Criteria { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
