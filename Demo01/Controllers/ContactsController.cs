using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers
{
    public class ContactsController : Controller
    {
        // /Contacts/       => possible grâce au app.MapControllerRoute("default",...) de program.cs
        // /Contacts/Index
        public string Index()
        {
            return "Je suis la page pour afficher les contacts";
        }

        // /Contacts/Details/5
        public string Details(int id)
        {
            return $"Je suis la page pour afficher le contact n°{id} en détail...";
        }

        public string Add()
        {
            return "Je suis la page pour ajouter un contact";
        }
    }
}
