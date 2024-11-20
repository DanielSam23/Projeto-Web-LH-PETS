using LH_PETS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto web - LH pets versao 1");

Banco banco = new Banco();
app.MapGet("/listaClientes", (HttpContext context) => {
    context.Response.WriteAsync(banco.GetListaString());
});

app.UseStaticFiles();

app.Run();
