namespace Domain.Interfaces;
public interface IUnitOfWork{
    IAppointmentRepository Appointments { get; }
    IBreedRepository Breeds {get;}
    ILabRepository Labs {get;}
    IMedicalTreatmentRepository MedicalTreatments {get;}
    IMedicineRepository Medicines { get; }
    IMedicineMovementRepository MedicineMovements { get; }
    IMovementDetailRepository MovementDetails {get;}
    IMovementTypeRepository MovementTypes {get;}
    IOwnerRepository Owners {get;}
    IPetRepository Pets {get;}
    IRoleRepository Roles {get;}
    ISpeciesRepository Speciess {get;}
    ISupplierRepository Suppliers {get;}
    IUserRepository Users {get;}
    IVetRepository Vets { get; }  
    Task<int> SaveChanges();
}