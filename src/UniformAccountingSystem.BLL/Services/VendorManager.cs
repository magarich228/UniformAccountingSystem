using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.BLL.Abstractions;
using UniformAccountingSystem.BLL.Dtos;
using UniformAccountingSystem.Data;
using UniformAccountingSystem.Data.Entities;

namespace UniformAccountingSystem.BLL.Services
{
    public class VendorManager : IVendorManager
    {
        private readonly UniformAccountingContext _db;

        public VendorManager(UniformAccountingContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<VendorDto>> GetAllAsync(CancellationToken cancellationToken = default) =>
            await _db.Vendors.Select(v => Mapping.Map<UniformVendor, VendorDto>(v)).ToListAsync(cancellationToken);

        public async Task<VendorDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var vendor = await _db.Vendors.FindAsync(new object[] { id }, cancellationToken: cancellationToken);

            if (vendor == null)
                return null;

            return Mapping.Map<UniformVendor, VendorDto>(vendor);
        }

        public async Task<Guid?> AddAsync(VendorDto entity, CancellationToken cancellationToken = default)
        {
            var vendor = Mapping.Map<VendorDto, UniformVendor>(entity);

            if (vendor == null)
                return null;

            await _db.Vendors.AddAsync(vendor, cancellationToken);
            var result = await _db.SaveChangesAsync(cancellationToken);

            return (result > 0) ? vendor.Id : null;
        }

        public async Task<VendorDto?> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var vendor = await _db.Vendors.FindAsync(new object[] { id }, cancellationToken: cancellationToken);

            if (vendor == null) 
                return null;

            _db.Vendors.Remove(vendor);

            return (await _db.SaveChangesAsync(cancellationToken)) > 0;
        }

        public async Task<VendorDto?> UpdateAsync(VendorDto vendorDto, CancellationToken cancellationToken = default)
        {
            var vendor = await _db.Vendors.FindAsync(new object[] { vendorDto.Id }, cancellationToken: cancellationToken);

            if (vendor == null) 
                return null;

            vendor.Name = vendorDto.Name;
            vendor.Phone = vendorDto.Phone;
            vendor.Email = vendorDto.Email;
            vendor.Description = vendorDto.Description;
            
            _db.Vendors.Update(vendor);
            await _db.SaveChangesAsync(cancellationToken);

            return Mapping.Map<UniformVendor, VendorDto>(vendor);
        }
    }
}
