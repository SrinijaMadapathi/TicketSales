namespace MadapathiTicketSales.Models
{
    /*
       * Created by Madapathi Srinija
       * 222222222222222222222222222
       * This class creates a type for Events
       * Each event has an event name (Title property), description for theevent, the categoryu of the event, and has an image to display
       */
    public class Event
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int CategoryID { get; set; }
        public double TicketPrice { get; set; }
        public string? Description { get; set; }
        public string? ImageID { get; set; }
     
        
    }//event class
}//namespace MadapathiTicketSales.Models
