using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Services
{
    public class EmployeesManager : IEmployeesManager
    {
        private readonly UniformAccountingContext _db;

        public EmployeesManager(UniformAccountingContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllAsync(bool includeDismissed = false, CancellationToken cancellationToken = default)
        {
            var employees = includeDismissed ? 
                (await _db.Employees.ToListAsync(cancellationToken)) :
                (await _db.Employees.Where(e => e.State == Data.Entities.EmployeeState.Active).ToListAsync(cancellationToken));

            return employees.Select(e => Mapping.Map<Employee, EmployeeDto>(e));
        }

        public async Task<EmployeeDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var employee = await _db.Employees.FindAsync(new object[] { id }, cancellationToken: cancellationToken);

            if (employee == null)
                return null;

            return Mapping.Map<Employee, EmployeeDto>(employee);
        }

        public async Task<EmployeeDto?> UpdateInfoAsync(EmployeeDto employeeDto, CancellationToken cancellationToken = default)
        {
            var employee = await _db.Employees.FindAsync(new object[] { employeeDto.Id }, cancellationToken: cancellationToken);

            if (employee == null)
                return null;

            employee.FirstName = employeeDto.FirstName;
            employee.LastName = employeeDto.LastName;
            employee.Patronymic = employeeDto.Patronymic;
            employee.WorkPosition = employeeDto.WorkPosition;

            _db.Employees.Update(employee);
            await _db.SaveChangesAsync(cancellationToken);

            return Mapping.Map<Employee, EmployeeDto>(employee);
        }

        public async Task<EmployeeDto?> ChangeStateByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var employee = await _db.Employees.FindAsync(new object[] { id }, cancellationToken: cancellationToken);

            if (employee == null)
                return null;

            employee.State = (employee.State == Data.Entities.EmployeeState.Active) ?
                Data.Entities.EmployeeState.Inactive : 
                Data.Entities.EmployeeState.Active;

            _db.Employees.Update(employee);
            await _db.SaveChangesAsync(cancellationToken);

            return Mapping.Map<Employee, EmployeeDto>(employee);
        }
    }
}
