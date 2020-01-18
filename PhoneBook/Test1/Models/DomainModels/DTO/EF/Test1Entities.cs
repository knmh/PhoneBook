using System;

namespace Test1.Models.DomainModels.DTO.EF
{
    internal class Test1Entities : IDisposable
    {
        public object People { get; internal set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}