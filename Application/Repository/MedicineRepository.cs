using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MedicineRepository : GenericRepository<Medicine>, IMedicineRepository{
    public MedicineRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Medicine>> GetAll(Expression<Func<Medicine, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Name)
                    .Include(x => x.Stock)
                    .Include(x => x.Price)
                    .Include(x => x.Lab)
                    .Include(x => x.Suppliers)
                    .Include(x => x.SupplierMedicines)
                    .Include(x => x.MedicalTreatments)
                    .Include(x => x.MedicineMovements)
                    .Include(x => x.MovementDetails)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Name)
                .Include(x => x.Stock)
                .Include(x => x.Price)
                .Include(x => x.Lab)
                .Include(x => x.Suppliers)
                .Include(x => x.SupplierMedicines)
                .Include(x => x.MedicalTreatments)
                .Include(x => x.MedicineMovements)
                .Include(x => x.MovementDetails)
                .ToListAsync();
        }
}
