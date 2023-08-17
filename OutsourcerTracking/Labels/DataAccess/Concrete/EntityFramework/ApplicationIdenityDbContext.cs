using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OutsourcerTracking.Labels.DataAccess.Entities;
using System.Reflection;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    //2 farklı kullanıcı olduğundan ve kendilerinin farklı alanları olduğu için ıtentitydbcontext ile yapıldı , normalde dbcontex ve itentitydb contex yapısı olması gerekir.
    public class ApplicationIdenityDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UsersRoles, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationIdenityDbContext()
        {

        }
        public ApplicationIdenityDbContext(DbContextOptions<ApplicationIdenityDbContext> options) : base(options)
        {

        }
        /**** MIGRATION işlemi yapılırken aşağıdaki method kapatılmalıdır. Uygulama çalıştırılırken açılmalıdır. ****/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(builder.GetValue<string>($"{builder.GetValue<string>("WorkMode")}:Conn"));
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Receive>(options =>
            {
                options.HasOne(a => a.EmployeeUser).WithMany(e => e.Receives);
                options.HasOne(a => a.OutsourceWorkOrder).WithMany(owo =>  owo.Receives);
                options.ToTable("Receives");
            });
            builder.Entity<AlkWorkOrder>(options =>
            {
                options.HasMany(awo => awo.OutsourceWorkOrders).WithOne(owo => owo.AlkWorkOrder);
                options.ToTable("AlkWorkOrders");
            });
            builder.Entity<Department>(options =>
            {
                options.HasMany(d => d.EmployeeUsers).WithOne(e => e.Department);
                options.ToTable("Departments");
            });
            builder.Entity<EmployeeUser>(options =>
            {
                options.HasOne(e => e.Department).WithMany(d => d.EmployeeUsers);
                options.HasOne(e => e.Title).WithMany(t => t.EmployeeUsers);
                options.HasMany(e => e.Receives).WithOne(a => a.EmployeeUser);
                options.ToTable("EmployeeUsers");
            });
            builder.Entity<Outsource>(options =>
            {
                options.HasMany(o => o.OutsourceWorkOrders).WithOne(owo => owo.Outsource);
                options.ToTable("Outsources");
            });
            builder.Entity<OutsourcesOutsourceUsers>(options =>
            {
                options.HasOne(u => u.OutsourceUser).WithMany(u => u.Outsources).HasForeignKey(u => u.OutsourceUserId);
                options.HasOne(u => u.Outsource).WithMany(u => u.OutsourcesOutsourceUsers).HasForeignKey(u => u.OutsourceId);
            });
            builder.Entity<OutsourceUser>(options =>
            {
                options.ToTable("OutsourceUsers");
            });
            builder.Entity<OutsourceWorkOrder>(options =>
            {
                options.HasMany(owo => owo.Receives).WithOne(a => a.OutsourceWorkOrder);
                options.HasMany(owo => owo.Trackings).WithOne(t => t.OutsourceWorkOrder);
                options.HasOne(owo => owo.Situation).WithMany(s => s.OutsourceWorkOrders);
                options.HasOne(owo => owo.Operation).WithMany(s => s.OutsourceWorkOrders);
                options.HasOne(owo => owo.Outsource).WithMany(o => o.OutsourceWorkOrders);
                options.HasOne(owo => owo.AlkWorkOrder).WithMany(awo => awo.OutsourceWorkOrders);
                options.HasOne(o => o.IntegrationStatus).WithMany(i => i.OutsourceWorkOrders).OnDelete(DeleteBehavior.Restrict);
                options.ToTable("OutsourceWorkOrders");
            });
            builder.Entity<Situation>(options =>
            {
                options.HasMany(s => s.OutsourceWorkOrders).WithOne(o => o.Situation);
                options.ToTable("Situations");
            });
            builder.Entity<Operation>(options =>
            {
                options.HasMany(s => s.OutsourceWorkOrders).WithOne(o => o.Operation);
                options.ToTable("Operations");
            });
            builder.Entity<Title>(options =>
            {
                options.HasMany(t => t.EmployeeUsers).WithOne(e => e.Title);
                options.ToTable("Titles");
            });
            builder.Entity<Tracking>(options =>
            {
                options.HasOne(t => t.OutsourceWorkOrder).WithMany(owo => owo.Trackings);
                options.ToTable("Trackings");
            });
            builder.Entity<User>(options =>
            {
                options.HasOne(u => u.OutsourceUser).WithOne(o => o.User).HasForeignKey<OutsourceUser>(o => o.Id);
                options.HasOne(u => u.EmployeeUser).WithOne(e => e.User).HasForeignKey<EmployeeUser>(o => o.Id);
                options.ToTable("Users");
            });
            builder.Entity<UsersRoles>(options =>
            {
                options.HasKey(ur => ur.Id);
                options.ToTable("UsersRoles");
            });
            builder.Entity<Role>(options =>
            {
                options.ToTable("Roles");
            });
            builder.Entity<Table>(options =>
            {
                options.ToTable("Tables");
            });
            builder.Entity<IntegrationStatus>(options =>
            {
                options.HasMany(i => i.OutsourceWorkOrders).WithOne(o => o.IntegrationStatus).OnDelete(DeleteBehavior.Restrict);
                options.ToTable("IntegrationStatuses");
            });
            SeedDatas(builder);
        }
        private void SeedDatas(ModelBuilder builder)
        {
            builder.Entity<Department>().HasData(new Department { Id = 1, Name = "Bilgi İşlem", Description = "Bilgi İşlem" }, new Department { Id = 2, Name = "Lojistik", Description = "Lojistik" });
            builder.Entity<Title>().HasData(new Title { Id = 1, Name = "Yazılım Uzmanı", Description = "Yazılım Uzamanı" }, new Title { Id = 2, Name = "Yazılım Uzman Yardımcı", Description = "Yazılım Uzman Yardımcısı" }, new Title { Id = 3, Name = "Ulaştırmacı", Description = "Ulaştırmacı" });
            #region User
            User user = new User()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Kullanıcı",
                UserName = "Admin Kullanıcı",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "orkun123");
            builder.Entity<User>().HasData(user);
            User user2 = new User()
            {
                Id = 2,
                FirstName = "Çalışan1",
                LastName = "Kullanıcı",
                UserName = "Çalışan1 Kullanıcı",
                Email = "employee1@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher2 = new PasswordHasher<User>();
            user2.PasswordHash = passwordHasher2.HashPassword(user2, "orkun123");
            builder.Entity<User>().HasData(user2);
            User user3 = new User()
            {
                Id = 3,
                FirstName = "Fason1",
                LastName = "Kullanıcı",
                UserName = "Fason1 Kullanıcı",
                Email = "fason1@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher3 = new PasswordHasher<User>();
            user3.PasswordHash = passwordHasher3.HashPassword(user3, "orkun123");
            builder.Entity<User>().HasData(user3);
            User user4 = new User()
            {
                Id = 4,
                FirstName = "Fason2",
                LastName = "Kullanıcı",
                UserName = "Fason2 Kullanıcı",
                Email = "fason2@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher4 = new PasswordHasher<User>();
            user4.PasswordHash = passwordHasher4.HashPassword(user4, "orkun123");
            builder.Entity<User>().HasData(user4);
            User user5 = new User()
            {
                Id = 5,
                FirstName = "Çalışan2",
                LastName = "Kullanıcı",
                UserName = "Çalışan2 Kullanıcı",
                Email = "employee2@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher5 = new PasswordHasher<User>();
            user5.PasswordHash = passwordHasher5.HashPassword(user5, "orkun123");
            builder.Entity<User>().HasData(user5);
            User user6 = new User()
            {
                Id = 6,
                FirstName = "Server",
                LastName = "Kullanıcı",
                UserName = "Server Kullanıcı",
                Email = "server@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsFirst = false,
                IsActive = true,
            };
            PasswordHasher<User> passwordHasher6 = new PasswordHasher<User>();
            user6.PasswordHash = passwordHasher6.HashPassword(user6, "orkun123");
            builder.Entity<User>().HasData(user6);
            #endregion

            builder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new Role() { Id = 2, Name = "Employee User", NormalizedName = "EMPLOYEE USER" },
                new Role() { Id = 3, Name = "Outsource User", NormalizedName = "OUTSOURCE USER" },
                new Role() { Id = 4, Name = "API User", NormalizedName = "API USER" }
                );
            builder.Entity<UsersRoles>().HasData(
                new UsersRoles() { Id = 1, RoleId = 1, UserId = 1 },
                new UsersRoles() { Id = 2, RoleId = 2, UserId = 2 },
                new UsersRoles() { Id = 3, RoleId = 3, UserId = 3 },
                new UsersRoles() { Id = 4, RoleId = 3, UserId = 4 },
                new UsersRoles() { Id = 5, RoleId = 2, UserId = 5 },
                new UsersRoles() { Id = 6, RoleId = 4, UserId = 6 }
                );
            builder.Entity<EmployeeUser>().HasData(new EmployeeUser { Id = 1, TitleId = 2, DepartmentId = 1 }, new EmployeeUser { Id = 2, TitleId = 3, DepartmentId = 2 });
            builder.Entity<OutsourceUser>().HasData(new OutsourceUser { Id = 3 }, new OutsourceUser { Id = 4 });
            builder.Entity<Outsource>().HasData(
                new Outsource { Id = 1, CurrentCode = "32000100857", WarehouseCode = "22005", MachineNo = 37, MachineCode = "0042-003", MachineName = "Güney Triko", Phone="1123456789", Email="ornek@ornek.com", Address = "Address" },
                new Outsource { Id = 2, CurrentCode = "32000100049", WarehouseCode = "22001", MachineNo = 38, MachineCode = "0044-005", MachineName = "Miraç - Elişi", Phone = "1123456789", Email = "ornek@ornek.com", Address = "Address" },
                new Outsource { Id = 3, CurrentCode = "32000100792", WarehouseCode = "22003", MachineNo = 39, MachineCode = "0042-004", MachineName = "Erdal Karakuş", Phone = "1123456789", Email = "ornek@ornek.com", Address = "Address" },
                new Outsource { Id = 4, CurrentCode = "32000100878", WarehouseCode = "22016", MachineNo = 40, MachineCode = "0042-006", MachineName = "Taner Örme", Phone = "1123456789", Email = "ornek@ornek.com", Address = "Address" },
                new Outsource { Id = 5, CurrentCode = "32000100874", WarehouseCode = "22011", MachineNo = 41, MachineCode = "0042-007", MachineName = "Onur Triko - Zaza", Phone = "1123456789", Email = "ornek@ornek.com", Address = "Address" },
                new Outsource { Id = 6, CurrentCode = "32000100223", WarehouseCode = "22004", MachineNo = 42, MachineCode = "0042-008", MachineName = "Fatih Yavuz", Phone = "1123456789", Email = "ornek@ornek.com", Address = "Address" }
                );
            builder.Entity<OutsourcesOutsourceUsers>().HasData(
                new OutsourcesOutsourceUsers { Id = 1, OutsourceUserId = 3, OutsourceId = 1 },
                new OutsourcesOutsourceUsers { Id = 2, OutsourceUserId = 3, OutsourceId = 2 },
                new OutsourcesOutsourceUsers { Id = 3, OutsourceUserId = 3, OutsourceId = 3 },
                new OutsourcesOutsourceUsers { Id = 4, OutsourceUserId = 4, OutsourceId = 1 },
                new OutsourcesOutsourceUsers { Id = 5, OutsourceUserId = 4, OutsourceId = 2 }
                );
            builder.Entity<Operation>().HasData(
                new Operation { Id = 1, No = "No 1", Code = "Code 1", Name = "Kesim Atölye" },
                new Operation { Id = 2, No = "No 2", Code = "Code 2", Name = "Pres Atölye" },
                new Operation { Id = 3, No = "No 3", Code = "Code 3", Name = "Grogren Atölye" },
                new Operation { Id = 4, No = "No 4", Code = "Code 4", Name = "Hasse Lamine Atölye" },
                new Operation { Id = 5, No = "No 5", Code = "Code 5", Name = "Eva Lamine Atölye" }
                );
            builder.Entity<AlkWorkOrder>().HasData(
                new AlkWorkOrder { Id = 1, ReferenceWorkOrderNo = "000000000002988", OrderGroup = "2-Takımlar+CVL", StockCode = "P-K23160-09", StockName = "StockName 1" },
                new AlkWorkOrder { Id = 2, ReferenceWorkOrderNo = "000000000006124", OrderGroup = "ZZZ-Yazlık Deneme", StockCode = "Y23270-11", StockName = "StockName 1" }
                );
            builder.Entity<Situation>().HasData(
                new Situation { Id = 1, Name = "Beklemede", Description = "Üretici tarafında bekleyen işler." },
                new Situation { Id = 2, Name = "Üretimde", Description = "Üretimi devam eden işler." },
                new Situation { Id = 3, Name = "Tamamlandı", Description = "Üretimi tamamlanmış işler." },
                new Situation { Id = 4, Name = "Biten", Description = "Üretimi ve teslimatı tamamlanmış işler." }
                );
            builder.Entity<OutsourceWorkOrder>().HasData(
                new OutsourceWorkOrder { Id = 1, AlkWorkOrderId = 1, OperationId = 1, OutsourceId = 1, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode="ColorCode", ColorName="Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000002988", Amount = 500, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now },
                new OutsourceWorkOrder { Id = 2, AlkWorkOrderId = 1, OperationId = 2, OutsourceId = 2, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode = "ColorCode", ColorName = "Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000002989", Amount = 700, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now },
                new OutsourceWorkOrder { Id = 3, AlkWorkOrderId = 1, OperationId = 3, OutsourceId = 3, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode = "ColorCode", ColorName = "Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000002990", Amount = 200, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now },
                new OutsourceWorkOrder { Id = 4, AlkWorkOrderId = 2, OperationId = 4, OutsourceId = 4, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode = "ColorCode", ColorName = "Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000006124", Amount = 350, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now },
                new OutsourceWorkOrder { Id = 5, AlkWorkOrderId = 2, OperationId = 5, OutsourceId = 5, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode = "ColorCode", ColorName = "Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000006125", Amount = 400, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now },
                new OutsourceWorkOrder { Id = 6, AlkWorkOrderId = 2, OperationId = 1, OutsourceId = 6, SituationId = 1, IntegrationStatusId = 1, Description = "Açıklama", ColorCode = "ColorCode", ColorName = "Color Name", RawMaterialsWarehouseCode = 1, ProductWarehouseCode = 1, WorkOrderNo = "000000000006126", Amount = 200, RecordDate = DateTime.Now, WorkOrderDate = DateTime.Now, Deadline = DateTime.Now, AlkUserName = "Or_De", AlkNormalizedUserName = "Orkun Demirci", CreatedOn = DateTime.Now }
                );;
            builder.Entity<Table>().HasData(
                new Table { Id = 1, IsChanged = false }
                );
            builder.Entity<IntegrationStatus>().HasData(
                new IntegrationStatus { Id = 1, Name = "Eşit" },
                new IntegrationStatus { Id = 2, Name = "Eklenecek" },
                new IntegrationStatus { Id = 3, Name = "Güncellenecek" },
                new IntegrationStatus { Id = 4, Name = "Silinecek" }
                );
        }
        public DbSet<Receive> Recieves { get; set; }
        public DbSet<AlkWorkOrder> AlkWorkOrders { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<Outsource> Outsources { get; set; }
        public DbSet<OutsourcesOutsourceUsers> OutsourcesOutsourceUsers { get; set; }
        public DbSet<OutsourceUser> OutsourceUsers { get; set; }
        public DbSet<OutsourceWorkOrder> OutsourceWorkOrders { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Table> Tables { get; set; }
        

    }


}
