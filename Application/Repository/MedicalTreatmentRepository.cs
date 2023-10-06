using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class MedicalTreatmentRepository : GenericRepository<MedicalTreatment>, IMedicalTreatmentRepository{
    public MedicalTreatmentRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<MedicalTreatment>> GetAll(Expression<Func<MedicalTreatment, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Dose)
                    .Include(x => x.AdminDate)
                    .Include(x => x.Observation)
                    .Include(x => x.Appointment)
                    .Include(x => x.Medicine)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Dose)
                .Include(x => x.AdminDate)
                .Include(x => x.Observation)
                .Include(x => x.Appointment)
                .Include(x => x.Medicine)
                .ToListAsync();
        }
}
