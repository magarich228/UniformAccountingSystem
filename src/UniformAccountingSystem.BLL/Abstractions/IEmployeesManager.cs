using UniformAccountingSystem.BLL.Dtos;

namespace UniformAccountingSystem.BLL.Abstractions
{
    public interface IEmployeesManager
    {
        Task<IEnumerable<EmployeeDto>>GetAllAsync(bool includeDismissed = false, CancellationToken cancellationToken = default);
        Task<EmployeeDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Уволить или принять обратно сотрудника.
        /// </summary>
        /// <param name="id">Id сотрудника.</param>
        Task<EmployeeDto?> ChangeStateByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<EmployeeDto?> UpdateInfoAsync(EmployeeDto employee, CancellationToken cancellationToken = default);
    }
}
