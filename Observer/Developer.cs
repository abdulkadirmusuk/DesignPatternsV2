namespace Observer {
    public class Developer : IObserver {
        public void Update(string message) {
            Console.WriteLine($"System vulnerability has been reported to the software developer. IsSecure {message}");
        }
    }
}

