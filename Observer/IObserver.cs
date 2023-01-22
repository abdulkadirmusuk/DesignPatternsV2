using System;
namespace Observer {
    /// <summary>
    /// Observer class. interface or abstract class
    /// </summary>
    public interface IObserver {
        /// <summary>
        /// observer state changer
        /// </summary>
        public void Update(string message);
    }
}

