using Microsoft.EntityFrameworkCore;
using Soltree.Api.Data;
using Soltree.Api.Data.Repositories;
using Soltree.Api.Graphql.Mutations;
using Soltree.Api.Graphql.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AppDbContext>()
    .AddQueryType(d => d.Name("Query"))
        .AddTypeExtension<BrandQuery>()
        .AddTypeExtension<ModelQuery>()
        .AddTypeExtension<DeviceTypeQuery>()
        .AddTypeExtension<SolutionQuery>()
        .AddTypeExtension<SymptomQuery>()
        .AddTypeExtension<SymptomCategoryQuery>()
    .AddMutationType(d => d.Name("Mutation"))
        .AddTypeExtension<BrandMutation>()
        .AddTypeExtension<ModelMutation>()
        .AddTypeExtension<SolutionMutation>()
        .AddTypeExtension<SymptomMutation>()
        .AddTypeExtension<SymptomCategoryMutation>()
        .AddTypeExtension<DeviceTypeMutation>()
    .AddFiltering()
    .AddSorting();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin();
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
        });
});

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("SoltreeConnectionString"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();



// Seed Database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        context.Database.Migrate();
        context.Database.EnsureCreated();
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

app.Run();
