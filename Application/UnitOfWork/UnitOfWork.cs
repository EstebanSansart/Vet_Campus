/*using Application.Repository;
using Application.Repository.Utilities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public sealed class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly PharmacyContext _Context;
    //-Repositories
    private IAddressRepository _Address;
    private IBuyRepository _Buy;
    private ICategoryRepository _Category;
    private ICityRepository _City;
    private IContact_typeRepository _Contact_Type;
    private IPositionRepository _Position;
    private IContactRepository _Contact;
    private ICountryRepository _Country;
    private IContact_categoryRepository _Contact_category;
    private IDepartmentRepository _Department;
    private IDocument_typeRepository _Document_type;
    private IEmployeeRepository _Employee;
    private IEpsRepository _Eps;
    private IInventoryRepository _Inventory;
    private IMedicine_brandRepository _Medicine_brand;
    private IMedicine_infoRepository _Medicine_Info;
    private IMedicineRepository _Medicine;
    private IOrderRepository _Order;
    private IPersonRepository _Person;
    private IProviderRepository _Provider;
    private IPresentationRepository _Presentation;
    private IRoleRepository _Role;
    private ISaleRepository _Sale;
    private IStateRepository _State;
    private IType_epsRepository _Type_eps;
    private IType_personRepository _Type_person;
    private IType_providerRepository _Type_provider;
    private IUserRepository _User;
    private ICustomQueriesManager _Custom;

    public UnitOfWork(PharmacyContext context)=>_Context = context;

    //-Singletons


    public ICustomQueriesManager CustomQueries => _Custom ??= new CustomQueriesManager(_Context);
    public IPositionRepository Positions => _Position ??= new PositionRepository(_Context);
    public IAddressRepository Addresses => _Address ??= new AddressRepository(_Context);
    public IBuyRepository Buys => _Buy ??=  new BuyRepository(_Context);
    public ICityRepository Cities => _City ??= new CityRepository(_Context);
    public ICategoryRepository Categories => _Category ??= new CategoryRepository(_Context);
    public IContact_categoryRepository Contact_Categories => _Contact_category ??=  new Contact_categoryRepository(_Context);
    public IContact_typeRepository Contact_Types => _Contact_Type ??=  new Contact_typeRepository(_Context);
    public IContactRepository Contacts => _Contact ??= new ContactRepository(_Context);
    public ICountryRepository Countries => _Country ??= new CountryRepository(_Context);
    public IDepartmentRepository Departments  => _Department ??= new DepartmentRepository(_Context);
    public ISaleRepository Sales => _Sale ??= new SaleRepository(_Context);
    public IDocument_typeRepository Document_Types => _Document_type ??= new Document_typeRepository(_Context);
    public IEmployeeRepository Employees => _Employee ??= new EmployeeRepository(_Context);
    public IEpsRepository Epss => _Eps ??= new EpsRepository(_Context);
    public IInventoryRepository Inventories => _Inventory ??= new InventoryRepository(_Context);
    public IMedicine_brandRepository Medicine_Brands => _Medicine_brand ??= new Medicine_brandRepository(_Context);
    public IMedicine_infoRepository Medicine_Infos => _Medicine_Info ??=  new Medicine_infoRepository(_Context);
    public IMedicineRepository Medicines => _Medicine ??=  new MedicineRepository(_Context);
    public IOrderRepository Orders => _Order ??= new OrderRepository(_Context);
    public IPersonRepository Persons => _Person ??= new PersonRepository(_Context);
    public IProviderRepository Providers => _Provider ??= new ProviderRepository(_Context);
    public IPresentationRepository Presentations => _Presentation ??= new PresentationRepository(_Context);
    public IRoleRepository Roles => _Role ??= new RoleRepository(_Context);
    public IStateRepository States => _State ??=  new StateRepository(_Context);
    public IType_epsRepository Type_Epss => _Type_eps ??= new Type_epsRepository(_Context);
    public IType_personRepository Type_Persons => _Type_person ??= new Type_PersonRepository(_Context);
    public IType_providerRepository Type_Providers => _Type_provider ??= new Type_providerRepository(_Context);
    public IUserRepository Users => _User ??= new UserRepository(_Context);

    //-Other Properties
    public void Dispose()=> _Context.Dispose();
    public async Task<int> SaveChanges()=> await _Context.SaveChangesAsync();
}
*/