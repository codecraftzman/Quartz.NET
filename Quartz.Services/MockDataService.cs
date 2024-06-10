using Quartz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Services
{
    public class MockDataService
    {
        private static List<Employee>? _employees = default!;
        private static List<ShiftSchedule>? _schedules = default!;
        private static List<Session>? _sessions = default!;

        public static List<Employee>? Emplyees
        {
            get
            {
                _employees = InitializeEmployees();
                return _employees;
            }
        }

        private static List<Employee>? InitializeEmployees()
        {
            var manager = new Employee
            {
                EmployeeId = 1,
                EmployeeType = EmployeeType.Manager,
                FirstName = "James",
                LastName = "West",
                Subordinates = new List<Employee> { }
            };
            var supervisor = new Employee
            {
                EmployeeId = 2,
                EmployeeType = EmployeeType.Supervisor,
                FirstName = "Ed",
                LastName = "John",
                Parent = manager,
                ParentId = 1,
                Subordinates = new List<Employee> { }
            };
            var agent1 = new Employee
            {
                EmployeeId = 3,
                EmployeeType = EmployeeType.Agent,
                FirstName = "Pete",
                LastName = "Anderson",
                ParentId = 2,
                Parent = supervisor
            };
            var agent2 = new Employee
            {
                EmployeeId = 4,
                EmployeeType = EmployeeType.Agent,
                FirstName = "Joe",
                LastName = "Nile",
                ParentId = 2,
                Parent = supervisor
            };
            manager.Subordinates.Add(supervisor);
            supervisor.Subordinates = [agent1, agent2];
            return [manager, supervisor, agent1, agent2];
        }

        public static List<ShiftSchedule>? Schedules
        {
            get
            {
                _schedules = InitializeSchedules();
                return _schedules;
            }
        }

        private static List<ShiftSchedule>? InitializeSchedules()
        {
            var schedule1 = new ShiftSchedule
            {
                ScheduleId = 1,
                Employee = _employees.Single(x => x.EmployeeId == 4),
                EmployeeId = 4,
                ShiftDate = DateOnly.FromDateTime(DateTime.Now),
                Region = new Region { Name = "US", OffsetHours = 12, TimeZoneId = "Eastern Standard Time", RegionId = 1 },

               

            };
            return [schedule1];
        }
    }
}
