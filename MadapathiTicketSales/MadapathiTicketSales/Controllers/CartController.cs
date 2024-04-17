using Microsoft.AspNetCore.Mvc;
using MadapathiTicketSales.Models;

namespace MadapathiTicketSales.Controllers
{
    public class CartController : Controller
    {
        /*
       * Created by Madapathi Srinija
       *88888888888888888888888888888
       */
        public IActionResult Buy(int id)
        {
            //gets the id of the event that the user wants to you ticket for and then,
            //using the EventsService, get an object representing the evnt.

            EventsService eventsService = new EventsService();
            Event selectedEvent = eventsService.GetEvent(id);

            //Start buying ticket by creating buyTicket object and setting name of the event and ticketprice. (constructor of Buy class).
            BuyTickets buyTickets = new BuyTickets(selectedEvent.Title, selectedEvent.TicketPrice);

            return View(buyTickets);
        }
        public IActionResult Confirmation(BuyTickets model)
        {
            if(ModelState.IsValid)
            {
                //call the buyTickets object's method to calculate sale price 
                model.CalculateAmountDue();
                //pass buytickets object as viewmodel to display  ticket information

                return View(model);
            }
            return View("Buy", model);//take the user back to the buy user's page.
        }
    }
}
