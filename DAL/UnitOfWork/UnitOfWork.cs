using System.Threading.Tasks;
using DAL.FakeData;
using DAL.Models;

namespace DAL.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        protected readonly AirportContext context =new AirportContext();
        private Repository<Ticket> ticketRepository;

        //public UnitOfWork(AirportContext context)
        //{
        //    this.context = context;
        //}

        public Repository<Ticket> TicketRepository
        {
            get
            {

                if (this.ticketRepository == null)
                {
                    this.ticketRepository = new Repository<Ticket>(context);
                }
                return ticketRepository;
            }
        }
        public IRepository<TEntity> Set<TEntity>() where TEntity : Entity
        {
            //return new Repository<TEntity>(context);
            return new FakeTicketRepository<TEntity>();
        }

        public int SaveChages()
        {
            return context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}