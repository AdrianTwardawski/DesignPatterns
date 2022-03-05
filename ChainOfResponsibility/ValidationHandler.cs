
namespace ChainOfResponsibility
{
    public class ValidationHandler : BaseHandler //klasa która waliduje dane zapytanie
    {
        public ValidationHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext) 
        {
            System.Console.WriteLine("ValidationHandler");
            if(requestContext.Request.EntityId > 100) //sprawdzamy czy zapytanie jest poprawne
            {
                _next.Handle(requestContext); //przekazujemy dalej procesowanie zapytania
                return;
            }
            requestContext.Response.IsSuccessful = false; //jeśli zapytanie sie nie powiedzie formatujemy odpowiedź do klienta
            requestContext.Response.Message = "Validation error: EntityId must be greater than 100";
        }
    }
}
