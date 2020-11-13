using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeToToggleCore.Models;

namespace TimeToToggleCore.Services
{
    public interface IToggleService
    {
        IEnumerable<ToggleTimeEntry> GetTimeEntriesToday();
        ToggleReport GetProject(string projectId);
    }
}
