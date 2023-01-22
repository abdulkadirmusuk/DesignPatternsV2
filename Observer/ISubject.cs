using System;
namespace Observer {
    /// <summary>
    /// object to track
    /// </summary>
    public interface ISubject {
        /// <summary>
        /// Subscribe
        /// </summary>
        /// <param name="observer"></param>
        public void Subscribe(IObserver observer);
        /// <summary>
        /// Unsubscribe
        /// </summary>
        /// <param name="observer"></param>
        public void UnSubscribe(IObserver observer);
        /// <summary>
        /// Notify message to subsribers
        /// </summary>
        public void Notify();
    }
}

