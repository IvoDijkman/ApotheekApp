This README contains multiple parts:
- Definition of Done
- FrontEnd installs
- Agreements we made concerning code and workflow
- Why we are doing this project

Definition of Done
- Unit tests succeed
- The application builds
- User story is completely viable

Are you new to this project? Did you just join the group and are you looking to work on the frontend?

Here's a guide for what to install to make it work:

Check if you have the correct version of <a href="Nodejs.org/en">Node.js</a> (with long term support, ^20)

npm install next@latest react@latest react-dom@latest -> Installs <a href="https://react.dev/learn/installation">React</a>

npm install -D tailwindcss
npx tailwindcss init -> Installs <a href="https://tailwindcss.com/docs/installation">Tailwind</a>

In VS Code, in Extensions, install Prettier - Code formatter - extension

Then, npm install -D prettier prettier-plugin-tailwindcss -> Installs <a href="https://github.com/tailwindlabs/prettier-plugin-tailwindcss">Tailwind Prettier</a>

npm install axios -> Installs <a href="https://www.npmjs.com/package/axios#package-manager">Axios</a>

Code conventions:
We use Async in method names if applicable

UpdateMedicineAsync()
Methods with only one return are written with a lambda expression

GetAll() => _repo.GetAll()
Use DTOs for all appropriate models. Each developer handles their own DTOs that are used in the API.

Routes for WebAPI: None unless you are creating multiple of the same one eg. multiple GetById().

SaveChanges() in Update() and Delete().

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
Max is a 25 year old intern apothecary who has been playing video games for a lot of his life, owns a laptop and the latest iPhone. 
In addition, he likes using apps on his phone for certain appliances in the house.
He drinks his coffee with 25 ml of oatmilk. 
As Max I want to search prescriptions, clients and find the medicine they need and if it's advisable or another medicine is needed. 

Julia is a 45 year old experienced apothecary who likes shopping online and using her phone. 
She has a daughter who is very tech savvy, so she has picked up a thing or two. 
She has a lot of patience with technology, as she has grown up with older technology. She drinks coffee on the daily. 
As Julia I want to be able to search prescriptions, clients and find the medicine they need and if it's advisable or another medicine is needed. 

Lex is 65, nearing retirement and is not a big fan of technology. 
He has very little patience for it and finds it difficult to understand so gets easily frustrated. 
He doesn't own a computer. 
As Lex I want to be able to easily search prescriptions, clients and find the medicine they need and if it's advisable or another medicine is needed. 

Robin is a 37 year old admin, very fond of spreadsheets and schedules. They even make spreadsheets for their cats.
They like solving problems for friends by offering advice. 
As admin Robin, I want to add clients and medicine, so that I can have a full overview of clients and medicine.

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
