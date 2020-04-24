using BNP.;
using System;

namespace BNP.DAL
{
    public class BaseDAO : IDisposable
    {
        protected Context Context = new Context();
        protected ContextIdentity ContextIdentity = new ContextIdentity();
        internal bool disposed;

        public BaseDAO()
        {
            Context.Configuration.ValidateOnSaveEnabled = false;
            Context.Configuration.LazyLoadingEnabled = false;

            ContextIdentity.Configuration.ValidateOnSaveEnabled = false;
            ContextIdentity.Configuration.LazyLoadingEnabled = false;
        }

        internal virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
                Context.Dispose();
            ContextIdentity.Dispose();
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
