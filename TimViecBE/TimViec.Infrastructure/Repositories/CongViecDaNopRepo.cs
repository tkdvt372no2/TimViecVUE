using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities.NhaTuyenDung;
using TimViec.Domain.Repositories;
using TimViec.Infrastructure.Context;

namespace TimViec.Infrastructure.Repositories
{
    public class CongViecDaNopRepo : Repo<CongViecDaNop>, ICongViecDaNopRepo
    {
        public CongViecDaNopRepo(TimViecContext context) : base(context)
        {
        }
    }
}
