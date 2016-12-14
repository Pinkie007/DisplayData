using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordData.ApplicationLogic.Interfaces
{
    public interface IValueService
    {
        IEnumerable<int> GetValues();

        int? GetValue(Guid id);

        string AddValue(int value);
    }
}
