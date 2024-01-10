using CadastroClientes.Data;

Console.WriteLine("Iniciei");

Repository.AddCustomer("Alex",29,"alex_email@gmail.com");
Repository.AddCustomer("Joao",17,"Joao_email@gmail.com");
Repository.AddCustomer("Maria",18,"Maria_email@gmail.com");
Repository.AddCustomer("Jessica",30,"Jessica_email@gmail.com");
Repository.AddCustomer("Matheus",12,"Matheus_email@gmail.com");

var clientes = Repository.GetAllCustomer();

var maioresDeIdade = clientes.Where(x => x.Name.ToLower().Contains("j")).ToList();

foreach (var item in clientes)
{
    Console.WriteLine($"Nome: {item.Name}");
}