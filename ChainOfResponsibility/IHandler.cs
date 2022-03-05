
namespace ChainOfResponsibility
{
    public interface IHandler //zadaniem tego interfejsu jest deklaracja metody do obsługi zapytania dla konkretnego ogniwa
    {
        void Handle(RequestContext requestContext);
    }
}
