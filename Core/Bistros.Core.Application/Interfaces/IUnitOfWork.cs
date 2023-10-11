﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}
