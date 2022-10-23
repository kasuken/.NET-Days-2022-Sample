using Bogus;
using EmployeeDirectory.Models;

namespace EmployeeDirectory.Services
{
    public class EmployeeService
    {
        public async Task<EmployeeModel[]> GetEmployeeAsync()
        {
            var userFaker = new Faker<EmployeeModel>()
                .RuleFor(o => o.ID, f => f.Random.Uuid())
                .RuleFor(o => o.Joined, f => f.Date.Recent(100))
                .RuleFor(o => o.Name, f => $"{f.Name.FirstName()} {f.Name.LastName()}")
                .RuleFor(o => o.Image, f => f.Internet.Avatar())
                .RuleFor(o => o.Email, (f, u) => f.Internet.Email())
                .RuleFor(o => o.JotTitle, f => f.Name.JobTitle())
                .RuleFor(o => o.Department, f => f.Name.JobArea());

            var employees = userFaker.Generate(99);

            //await Task.Delay(3000);

            return employees.ToArray();
        }
    }
}
