using System;
namespace Observer {
    public class Manager : IObserver {
        public void Update(string message) {
            Console.WriteLine($"System vulnerability has been reported to the manager. IsSecure {message}");
        }
    }
}

