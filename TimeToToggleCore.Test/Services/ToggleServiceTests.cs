using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using TimeToToggleCore.Models;
using TimeToToggleCore.Services;
using Xunit;

namespace TimeToToggleCore.Test.Services
{
    public class ToggleServiceTests
    {
        [Fact]
        public void GetTodaysTimeEntries_shuouldReturn_TimeEntriesFromToday(){

            // Arrange
            // var mockToggleServiceLogger = new Mock<ILogger<ToggleService>>();

            // ToggleClient toggleClient = new Mock<ILogger<IToggleClient>>();

            // ToggleService toggleService = new  ToggleService(mockToggleServiceLogger.Object, toggleClient.Object);

            // // Act
            // List<ToggleTimeEntries> expected = new List<ToggleTimeEntries>();
            // List<ToggleTimeEntries> actual = toggleService.GetTimeEntriesToday().Result.ToList(); 

            // // Assert
            // Assert.Equal(expected, actual);
        }


    }
}
