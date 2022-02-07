using System;

namespace ObserverPatternFinalCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver Observer1 = new Observer("Diwali", 20);
            IObserver Observer2 = new Observer("Christmas", 10);
            IObserver Observer3 = new Observer("New Year", 190);

            NotificationService notificationService = new NotificationService();

            notificationService.AddSubscriber(Observer1);
            notificationService.AddSubscriber(Observer2);
            notificationService.AddSubscriber(Observer3);
            
            notificationService.RemoveSubscriber(Observer3);

            Console.ReadKey();
        }
    }
}
