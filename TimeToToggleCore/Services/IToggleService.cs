using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeToToggleCore.Models;

namespace TimeToToggleCore.Services
{
    public interface IToggleService
    {
        IEnumerable<ToggleTimeEntries> GetTimeEntriesToday();
    }
}
