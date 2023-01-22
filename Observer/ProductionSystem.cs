using System;
namespace Observer {
    /// <summary>
    /// Tracking subject
    /// </summary>
    public class ProductionSystem : IProductionSystem {
        public List<IObserver> Observers;
        public string SystemName;
        public int UsingResources;
        public bool isSecure;

        public bool IsSecure {
            get { return isSecure; }
            set {
                if (value == false) {
                    Notify();
                }
                isSecure = value;
            }
        }

        /// <summary>
        /// ProductionSystem ctor
        /// </summary>
        public ProductionSystem() {
            this.Observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer) {
            Observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer) {
            Observers.Remove(observer);
        }

        public void Notify() {
            Observers.ForEach(observer => {
                observer.Update(isSecure.ToString());
            });
        }
    }
}

