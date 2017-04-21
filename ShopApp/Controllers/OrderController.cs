using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;
using Microsoft.AspNetCore.Authorization;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopApp.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;



        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;

        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some games first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                

                try
                {
                    
                    if (ModelState.IsValid)
                    {
                        var emailMessage = new MimeMessage();
                        decimal ordertot = 0;
                        emailMessage.From.Add(new MailboxAddress("Game Shop", "randomemailaspnet@gmail.com"));
                        emailMessage.To.Add(new MailboxAddress("", order.Email));
                        emailMessage.Subject = "Your recent order from GameShop";
                        string Text = "Hello, " + order.FirstName + "." + " You recently placed an order on " + String.Format("{0:MM/dd/yyyy}", order.OrderPlaced.Date) + ". Your items will soon be shipped and delivered.\n\n" + "Items bought:\n\n";
                        foreach (var game in order.OrderLines)
                        {
                            Text = Text + game.Game.Name + " x " + game.Amount+ "\n";
                            ordertot = ordertot + game.Game.Price;
                        }
                        Text = Text + "\nTotal Cost: $" + ordertot + "\n\nThank you for shopping at GameShop!";
                        emailMessage.Body = new TextPart("plain") { Text = Text};


                        using (var client = new SmtpClient())
                        {
                            client.Connect("smtp.gmail.com", 465);
                            client.AuthenticationMechanisms.Remove("XOAUTH2"); // Must be removed for Gmail SMTP
                            client.Authenticate("randomemailaspnet@gmail.com","P@ssw0rd!" );
                            client.Send(emailMessage);
                            client.Disconnect(true);
                        }


                        ModelState.Clear();
                        ViewBag.UserMessage = "Message Sent";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.UserMessage = "Unable to Send Message:";
                }


                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            
            return View(order);

        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! An email has been sent to your address with your order information.";
            return View();
        }
    }
}
