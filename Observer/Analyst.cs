namespace Observer {
    public class Analyst : IObserver {
        public void Update(string message) {
            Console.WriteLine($"System vulnerability has been reported to the analyst. IsSecure {message}");
        }
    }
}

