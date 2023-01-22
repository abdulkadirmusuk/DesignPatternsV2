using System;
namespace Observer {
    public interface IProductionSystem : ISubject {
        public bool IsSecure { get; set; }
    }
}

