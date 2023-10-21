using Domain.Interfaces.Generics;
using Infra.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio.Generics
{
    public class RepositoryGeneric<T> : InterfaceGneric<T> , IDisposable where T : class
    {
        private readonly DbContextOptions _dbContext;
        public RepositoryGeneric()
        {
            _dbContext = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T objeto)
        {
            using (var context = new ContextBase(_dbContext)) 
            {
                context.Set<T>().Add(objeto);
                await context.SaveChangesAsync();  
            }
        }

        public async Task Delete(T Obejeto)
        {
            using (var context = new DbContext(_dbContext)) 
            {
                context.Set<T>().Remove(Obejeto);
                await context.SaveChangesAsync();           
            }
        }

        public async Task<T> GetEntityById(int Id)
        {
            using (var context = new DbContext(_dbContext)) 
            {
               return await context.Set<T>().FindAsync(Id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var context = new DbContext(_dbContext)) 
            {
              return await context.Set<T>().ToListAsync();  
            }
        }

        public async Task Update(T objeto)
        {
            using (var context = new DbContext(_dbContext)) 
            {
                context.Set<T>().Update(objeto);
                await context.SaveChangesAsync();
            }
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion

    }
}
