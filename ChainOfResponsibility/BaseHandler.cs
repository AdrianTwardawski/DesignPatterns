
namespace ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler //bazowa klasa abstrakcyjna, po której będą dziedziczyły wszystkie 3 konkretne klasy
                                        //lub więcej, jeżeli chcemy uzyskać konkretny przepływ zapytania
    {
        protected IHandler _next;
        protected BaseHandler(IHandler next)
        {
            _next = next;
        }

        public abstract void Handle(RequestContext requestContext); //metoda abstrakcyjna po to aby klasy dziedziczące po niej musiały ją zaimplementować
        
    }
}
