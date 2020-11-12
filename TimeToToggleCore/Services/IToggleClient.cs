using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeToToggleCore.Models;

namespace TimeToToggleCore.Services
{
    public interface IToggleClient
    {
        Task<ToggleMe> GetMe();
        Task<IEnumerable<ToggleTimeEntries>> GetTimeEntries();
    }
}
