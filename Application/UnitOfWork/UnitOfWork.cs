using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly APIContext _Context;
    //-Repositories
    private IAppointmentRepository _Appointment;
    private IBreedRepository _Breed;
    private ILabRepository _Lab;
    private IMedicalTreatmentRepository _MedicalTreatment;
    private IMedicineRepository _Medicine;
    private IMedicineMovementRepository _MedicineMovement;
    private IMovementDetailRepository _MovementDetail;
    private IMovementTypeRepository _MovementType;
    private IOwnerRepository _Owner;
    private IPetRepository _Pet;
    private IRoleRepository _Roles;
    private ISpeciesRepository _Species;
    private ISupplierRepository _Supplier;
    private IUserRepository _User;
    private IVetRepository _Vet;

    public UnitOfWork(APIContext context)=>_Context = context;

    public IAppointmentRepository Appointments => throw new NotImplementedException();

    public IBreedRepository Breeds => throw new NotImplementedException();

    public ILabRepository Labs => throw new NotImplementedException();

    public IMedicalTreatmentRepository MedicalTreatments => throw new NotImplementedException();

    public IMedicineRepository Medicines => throw new NotImplementedException();

    public IMedicineMovementRepository MedicineMovements => throw new NotImplementedException();

    public IMovementDetailRepository MovementDetails => throw new NotImplementedException();

    public IMovementTypeRepository MovementTypes => throw new NotImplementedException();

    public IOwnerRepository Owners => throw new NotImplementedException();

    public IPetRepository Pets => throw new NotImplementedException();

    public IRoleRepository Roles => throw new NotImplementedException();

    public ISpeciesRepository Speciess => throw new NotImplementedException();

    public ISupplierRepository Suppliers => throw new NotImplementedException();

    public IUserRepository Users => throw new NotImplementedException();

    public IVetRepository Vets => throw new NotImplementedException();

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}