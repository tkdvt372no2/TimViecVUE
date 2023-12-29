using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities.NguoiTimViec;
using TimViec.Domain.Repositories;
using TimViec.Infrastructure.Context;

namespace TimViec.Infrastructure.Repositories
{
    public class HocVanRepo : Repo<HocVan>, IHocVanRepo
    {
        public HocVanRepo(TimViecContext context) : base(context)
        {
        }
    }
}
