using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DAL.Models;
using DAL.UnitOfWork;

namespace DAL.FakeData
{
    class FakeTicketRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
        //public class Repository<TEntity> : IRepository<TEntity> where TEntity: Entity
    {
        private IEnumerable<Entity> tikets = new List<Entity>
        {
            new Ticket
            {
                Id =0,
                FlightNumber = "AAA",
                Price = 34.44M
            },
            new Ticket
            {
            Id=1,
            FlightNumber = "BBB",
            Price = 67.49M
            },
            new Ticket
            {
                Id=2,
                FlightNumber = "AAA",
                Price = 25.58M
            }

        };

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return new List<TEntity>
            {
            };
        }

        public void Create(TEntity entity, string createdBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity, string modifiedBy = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
