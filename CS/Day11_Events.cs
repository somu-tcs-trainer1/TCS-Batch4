//Events - user actions ex: key press, click, hovering
/*
1. Events has publisher-subscriber model
Publisher - obj. that contains the def. of event and the delegate
Subscriber - obj. that accepts the event, and provides and event handler

*/

//public delegate string LogHandler(string str);
//event LogHandler eventLoghandler;


public delegate string Del1(string str);
public class EventsDemo
{
    event Del1 MyEvent;

    public EventsDemo()
    {
        MyEvent += new Del1(WelcomeUser);
    }
    public string WelcomeUser(string username)
    {
        return "Welcome "+username;
    }

    static void Main(String[] args)
    {
        EventsDemo eventsDemo = new EventsDemo();
        string resultAfterLogin = eventsDemo.MyEvent("John Doe");
        Console.WriteLine(resultAfterLogin);
    }
}