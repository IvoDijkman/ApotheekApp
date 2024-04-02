This README contains multiple parts:
- Definition of Done
- Agreements we made concerning code and workflow
- Why we are doing this project

Definition of Done
- Unit tests succeed
- The application builds
- User story is completely viable


Code conventions:
We use Async in method names if applicable
UpdateMedicineAsync()
Methods with only one return are written with a lambda expression
GetAll() => _repo.GetAll()
Use DTOs for all appropriate models. Each developer handles their own DTOs that are used in the API.
Routes for WebAPI: None unless you are creating multiple of the same one eg. multiple GetById().
SaveChanges() bij Update() en Delete().
Comments are okay but only if they are required for clarity.
Keep methods small (eg. 10 lines of code)
Workflow: before you make a pull request, first pull dev into your branch, check it builds and fix if necessary.
Workflow for peer review: always test that it builds before approving. If it does not, alert original creator.
Exceptions are caught in the API/frontend, and thrown in the Repo.
Interfaces are in a separate folder.

Coding examples:
Extensions:
ValidatorExtensions.cs
Contains all extension methods concerning validation
Constructors:
Use 'old' constructors:
public ClientRepository(IClientService _clientService)
{
_clientService = clientService;
}
General methods:
public async Task UpdateMedicineAsync()
{
_dataContext.Medicines.Add()
}
Unit tests:
[Fact]
public void Should_Return_Medicine()
{
Assert.Equal("Aspirin", medicine.Name);
}

User Story:
As Max, apothecary, I want to be able to search prescriptions 
that are for the appropriate client so I can provide them the medicine.

As admin Julia, I want to add clients and medicine, 
so that I can have a full overview of clients and medicine.

Concept of Use:
User(Employee) logs in. The next page opens with a list of Prescriptions. 
The first item to be filled in is Date Of Birth. 
The list of prescriptions is filtered after typing 8 characters.
If needed, a Last Name can be filled in which further filters the list.
User then clicks the specified Client. A page is displayed with Client info and prescription info.
User can then click a button to verify that the prescription has been handled. 

Why we are doing this project 
We wanted to keep practicing our C# and we wanted to learn and experiment with React.
We also wanted to work on a project together to practice working in a team.
