﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Generics
{
    public  interface InterfaceGneric<T> where T : class
    {
        Task Add(T objeto);
        Task Update(T objeto);
        Task Delete(T Obejeto);
        Task<T> GetEntityById(int Id);
        Task<List<T>> List();
    }
}
