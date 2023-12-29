using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities;
using TimViec.Domain.Repositories;
using TimViec.Infrastructure.Context;

namespace TimViec.Infrastructure.Repositories
{
    public class TaiKhoanRepo : Repo<TaiKhoan>, ITaiKhoanRepo
    {
        public TaiKhoanRepo(TimViecContext context) : base(context)
        {
        }
    }
}
