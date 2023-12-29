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
    public class CongViecRepo : Repo<CongViec>, ICongViecRepo
    {
        public CongViecRepo(TimViecContext context) : base(context)
        {
        }
    }
}
