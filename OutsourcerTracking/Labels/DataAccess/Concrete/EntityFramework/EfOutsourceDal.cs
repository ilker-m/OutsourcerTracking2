using OutsourcerTracking.Labels.Core.DataAccess.EntityFramework;
using OutsourcerTracking.Labels.DataAccess.Abstract;
using OutsourcerTracking.Labels.DataAccess.Entities;

namespace OutsourcerTracking.Labels.DataAccess.Concrete.EntityFramework
{
    public class EfOutsourceDal : EfEntityRepositoryBase<Outsource, ApplicationIdenityDbContext>, IOutsourceDal
    {
        private readonly ApplicationIdenityDbContext _context;
        public EfOutsourceDal() { }
        public EfOutsourceDal(ApplicationIdenityDbContext context)
        {
            _context = context;
        }
        public List<Outsource> GetAllByOutsourceUserId(int id)
        {
            return (from o in _context.Outsources
                    join oou in _context.OutsourcesOutsourceUsers on o.Id equals oou.OutsourceId
                    join ou in _context.OutsourceUsers on oou.OutsourceUserId equals ou.Id
                    where !o.IsDeleted && ou.Id == id
                    select new Outsource
                    {
                        Id = o.Id,
                        MachineCode = o.MachineCode,
                        MachineName = o.MachineName,
                        Email = o.Email,
                        CreatedBy = o.CreatedBy,
                        CreatedOn = o.CreatedOn,
                        UpdatedBy = o.UpdatedBy,
                        UpdatedOn = o.UpdatedOn,
                    }).ToList();
        }
        public int GetLastId()
        {
            return ( from o in _context.Outsources
                     where !o.IsDeleted
                     orderby o.Id
                     select o ).Last().Id;
        }

        /*public List<Outsource> GetWithAddress()
        {
            return ( from o in _context.Outsources
                     join a in _context.Addresses on o.AddressId equals a.Id
                     where !o.IsDeleted
                     select new Outsource
                     {
                         Id = o.Id,
                         CurrentCode = o.CurrentCode,
                         WarehouseCode = o.WarehouseCode,
                         MachineCode = o.MachineCode,
                         MachineName = o.MachineName,
                         Email = o.Email,
                         AddressId = o.AddressId,
                         OutsourcePhone = o.OutsourcePhone,
                         Address = a
                     } ).ToList();
        }*/

        /*public Outsource GetWithAddressById(int id)
        {
            return (from o in _context.Outsources
                    join a in _context.Addresses on o.AddressId equals a.Id
                    where o.Id == id
                    select new Outsource
                    {
                        Id = o.Id,
                        CurrentCode = o.CurrentCode,
                        WarehouseCode = o.WarehouseCode,
                        MachineCode = o.MachineCode,
                        MachineName= o.MachineName,
                        Email = o.Email,
                        AddressId = o.AddressId,
                        OutsourcePhone = o.OutsourcePhone,
                        Address = a
                    }).First();
        }*/
    }
}
