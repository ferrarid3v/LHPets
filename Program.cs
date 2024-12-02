using LH_PETS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto Web - LH Pets Versão 1");

Banco banco = new Banco();
app.MapGet("/listaCliente", (HttpContext context) =>
{
    context.Response.WriteAsync(banco.GetListaString());
});

app.UseStaticFiles();

app.Run();
