using Microsoft.EntityFrameworkCore;
using OutsourceTrackingWorkerService;
using OutsourceTrackingWorkerService.Facade;
using OutsourceTrackingWorkerService.Models;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        IConfiguration builder = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .Build();
        var workMode = builder.GetValue<string>("WorkMode");
        var workerModel = new WorkerModel()
        {
            WorkMode = workMode,
            Conn = builder.GetValue<string>(workMode + ":Conn"),
            PeriodSeconds = builder.GetValue<int>(workMode + ":PeriodSeconds"),
            BaseAddress = builder.GetValue<string>(workMode + ":BaseAddress"),
            UserName = builder.GetValue<string>(workMode + ":UserName"),
            Password = builder.GetValue<string>(workMode + ":Password")
        };
        services.AddSingleton(workerModel);
        services.AddSingleton(new HttpClient());
        services.AddSingleton<IFacade, Facade>();
        /*services.AddSingleton(new GenericEFRepository<AddressesW, ApplicationContext>());
        services.AddSingleton(new GenericEFRepository<AlkWorkOrdersW, ApplicationContext>());
        services.AddSingleton(new GenericEFRepository<OutsourcesW, ApplicationContext>());
        services.AddSingleton(new GenericEFRepository<OutsourceWorkOrdersW, ApplicationContext>());
        services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseSqlServer(workerModel.Conn);
        });*/
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();