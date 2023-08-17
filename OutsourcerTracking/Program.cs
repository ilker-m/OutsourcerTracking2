using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework;
using OutsourcerTracking.Labels.Business.Concrete;
using OutsourcerTracking.Labels.DataAccess.Entities;
using Business.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationIdenityDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetValue<string>($"{builder.Configuration.GetValue<string>("WorkMode")}:Conn"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<ApplicationIdenityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/UserAuthentication/Login");

builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationManager>();
builder.Services.AddScoped<IEmployeeUserService, EmployeeUserManager>();
builder.Services.AddScoped<IEmployeeUserDal, EfEmployeeUserDal>();
builder.Services.AddScoped<IOutsourceUserService, OutsourceUserManager>();
builder.Services.AddScoped<IOutsourceUserDal, EfOutsourceUserDal>();
builder.Services.AddScoped<IOutsourceService, OutsourceManager>();
builder.Services.AddScoped<IOutsourceDal, EfOutsourceDal>();
builder.Services.AddScoped<IOutsourcesOutsourceUsersService, OutsourcesOutsourceUsersManager>();
builder.Services.AddScoped<IOutsourcesOutsourceUsersDal, EfOutsourcesOutsourceUsersDal>();
builder.Services.AddScoped<IUsersRolesService, UsersRolesManager>();
builder.Services.AddScoped<IUsersRolesDal, EfUsersRolesDal>();
builder.Services.AddScoped<IRoleService, RoleManager>();
builder.Services.AddScoped<IRoleDal, EfRoleDal>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();
builder.Services.AddScoped<IDepartmentDal, EfDepartmentDal>();
builder.Services.AddScoped<ITitleService, TitleManager>();
builder.Services.AddScoped<ITitleDal, EfTitleDal>();
builder.Services.AddScoped<IOutsourceWorkOrderService, OutsourceWorkOrderManager>();
builder.Services.AddScoped<IOutsourceWorkOrderDal, EfOutsourceWorkOrderDal>();
builder.Services.AddScoped<ITrackingService, TrackingManager>();
builder.Services.AddScoped<ITrackingDal, EfTrackingDal>();
builder.Services.AddScoped<IReceiveService, ReceiveManager>();
builder.Services.AddScoped<IReceiveDal, EfReceiveDal>();
builder.Services.AddScoped<IAlkWorkOrderService, AlkWorkOrderManager>();
builder.Services.AddScoped<IAlkWorkOrderDal, EfAlkWorkOrderDal>();
builder.Services.AddScoped<ISituationService, SituationManager>();
builder.Services.AddScoped<ISituationDal, EfSituationDal>();
builder.Services.AddScoped<ITableService, TableManager>();
builder.Services.AddScoped<ITableDal, EfTableDal>();
builder.Services.AddScoped<IOperationService, OperationManager>();
builder.Services.AddScoped<IOperationDal, EfOperationDal>();
builder.Services.AddScoped<IEmailService, EmailManager>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=UserAuthentication}/{action=Login}/{id?}");

app.Run();
