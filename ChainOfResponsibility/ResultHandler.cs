
namespace ChainOfResponsibility
{
    public class ResultHandler : BaseHandler //Handler odpowiedzialny za zwrócenie odpowiedniego rezultatu do klienta
    {
        public ResultHandler(IHandler next) : base(next)
        {
        }

        public override void Handle(RequestContext requestContext)
        {
            System.Console.WriteLine("ResultHandler");
            requestContext.Response.IsSuccessful = true; //na tym etapie jesteśmy pewni, że dany użytkownik ma dostęp do danego zasobu
                                                         //oraz zapytanie, które wysłał jest prawidłowe
            requestContext.Response.Data = "some value"; //ciało odpowiedzi
        }
    }
}
