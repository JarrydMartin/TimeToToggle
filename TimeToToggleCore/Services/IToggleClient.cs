using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimeToToggleCore.Models;

namespace TimeToToggleCore.Services
{
    public interface IToggleClient
    {
        Task<ToggleMeTransport> GetMe();
        Task<IEnumerable<ToggleTimeEntry>> GetTimeEntries();
        Task<ToggleReportTransport> GetProject(string projectId);
    }
}
