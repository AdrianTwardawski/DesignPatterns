
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler //klasa pierwsza w procesie przepływu zapytania
    {
        private Dictionary<int, int> entityOwners = new Dictionary<int, int>() //słownik, który reprezentuje jaki zasób jest dostępny dla jakiego użytkownika
        {
            {100, 13}, //Id encji oraz Id użytkownika
            {101, 14},
        };
        public AuthorizationHandler(IHandler next) : base(next) //ten konstruktor oddeleguje swoje wykonanie do konstruktora bazowego 
        {

        }

        public override void Handle(RequestContext requestContext) //Handler autoryzacji, chcemy dopuścić użytkowników, którzy są w roli administratora
                                                                   //lub którzy są przypisani do konkretnego obiektu
        {
            System.Console.WriteLine("AuthorizationHandler");
            if(requestContext.Request.UserRole == "Admin") //jeżeli ten warunek jest spełniony to oddelegowujemy obsługę tego zapytania do następnego Handlera
            {
                _next.Handle(requestContext);
                return;
            }

            if(entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId)) //sprawdzenie czy użytkownik, który nie jest "Admin" ma dostęp do konkretnej encji
            {
                if(ownerId == requestContext.Request.UserId)
                {
                    _next.Handle(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false; //jeśli zapytanie sie nie powiedzie formatujemy odpowiedź do klienta
            requestContext.Response.Message = "User is not authorized";

        }
    }
}
