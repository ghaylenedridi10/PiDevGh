using Data.Infrastructure;
using Domain.Entities;
using Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PubliciteService : Service<Publicite>, IPubliciteService
    {

        static IDatabaseFactory factory = new DatabaseFactory();
        static IUnitOfWork utk = new UnitOfWork(factory);

        public PubliciteService() : base(utk)
        {

        }
    }
}
