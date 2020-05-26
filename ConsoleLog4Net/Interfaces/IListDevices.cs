using System.Collections.Generic;
using ConsoleLog4Net.Model;

namespace ConsoleLog4Net.Interfaces
{
    public interface IListDevices
    {
        IEnumerable<DeviceIdDto> Devices { get; set; }
    }
}
