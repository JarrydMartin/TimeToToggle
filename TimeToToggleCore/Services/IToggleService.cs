using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeToToggleCore.Models;

namespace TimeToToggleCore.Services
{
    public interface IToggleService
    {
        Task<ToggleMe> GetMe();
        Task<IEnumerable<ToggleTimeEntries>> GetTimeEntries();
        Task<IEnumerable<ToggleTimeEntries>> GetTimeEntriesToday();
    }
}
