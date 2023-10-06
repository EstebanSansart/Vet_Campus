using System.Linq.Expressions;
using Application.Repository.Generics;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository{
    public AppointmentRepository(APIContext context) : base(context){}

    protected override async Task<IEnumerable<Appointment>> GetAll(Expression<Func<Appointment, bool>> expression = null)
        {
            if (expression is not null)
            {
                return await _Entities
                    .Include(x => x.Date)
                    .Include(x => x.Hour)
                    .Include(x => x.Reason)
                    .Include(x => x.Pet)
                    .Include(x => x.Vet)
                    .Include(x => x.MedicalTreatments)
                    .Where(expression).ToListAsync();
            }
            return await _Entities
                .Include(x => x.Date)
                .Include(x => x.Hour)
                .Include(x => x.Reason)
                .Include(x => x.Pet)
                .Include(x => x.Vet)
                .Include(x => x.MedicalTreatments)
                .ToListAsync();
        }
}
