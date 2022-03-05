using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestCotnext = new RequestContext() //kontekst zapytania
            {
                Request = new Request()
                {
                    EntityId = 101,
                    UserId = 13,
                    UserRole = "Admin"
                },
                Response = new Response()
            };

            /*utworzenie obiektów reprezentujących ogniwa w łańcuchu zobowiązań*/
            var resultHandler = new ResultHandler(null); //handler rezultatu, który nie przyjmuje żadnego handlera w konstruktorze
            var validationHandler = new ValidationHandler(resultHandler); //handler walidacji do którego przekazujemy resultHandler
            var authorizationHandler = new AuthorizationHandler(validationHandler); //handler autoryzacji do któego przekazujemy validationHandler

            authorizationHandler.Handle(requestCotnext);

            Console.WriteLine($"IsSuccessful: {requestCotnext.Response.IsSuccessful}");
            Console.WriteLine($"Message: {requestCotnext.Response.Message}");
            Console.WriteLine($"Data: {requestCotnext.Response.Data}");
        }
    }
}

/*W ten sposób używając łańcucha zobowiązań, jesteśmy w stanie utworzyć obiekty, które będą częścią łańcucha i każdy z nich będzie powiązany
z następnym z kolei obiektem, czy też ogniwem łańcucha, a zadaniem każdego z nich będzie przekazanie odpowiedzialności dalej lub przerwanie
procesowania zapytania. W kontekście SOLIDA spełnia on zasadę pojedynczej odpowiedzialności, ponieważ każde z ogniw ma tylko swoje zadanie
nie sprawdzamy całej logiki na raz i jednocześnie łańcuch jest rozszerzalny przez co w każdym momencie jesteśmy w stanie  utworzyć nowe ogniwo,
które wpasujemy w konkretne miejsce naszego łańcucha*/
