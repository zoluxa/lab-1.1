﻿namespace Airport.UnitOfWork.Catalogs
{
    using System;
    using DAL;
    using DAL.DataContext;
    using DAL.Model.Entities;

    public class FlightPlaceUnit : IDisposable
    {
        AirlineDbContext context = new AirlineDbContext();
        GenericRepository<FlightPlace> flightPlaceRepository;

        public GenericRepository<FlightPlace> FlightPlaceRepository
        {
            get
            {
                if (flightPlaceRepository == null)
                    flightPlaceRepository = new GenericRepository<FlightPlace>(context);
                return flightPlaceRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~FlightPlacesUnit() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
