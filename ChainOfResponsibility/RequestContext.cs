
namespace ChainOfResponsibility
{
    public class Request //klasa odpowiedzialna za zapytanie od klienta
    {
        public string UserRole { get; set; } 
        public int UserId { get; set; } 
        public int EntityId { get; set; } //reprezentuje jaki zasób użytkownik chce pobrać z serwera
    }

    public class Response //klasa odpowiedzialna za odpowiedź
    {
        public bool IsSuccessful { get; set; } //informacja o tym czy zapytanie przebiegło prawidłowo
        public string Message { get; set; } //wiadomość zapytania
        public object Data { get; set; } //dane, które chcemy zwrócić do użytkownika
    }




    public class RequestContext  //klasa ta agreguje zapytania od klienta jak i odpowiedź, która zostanie do niego zwrócona
    {
        public Request Request { get; set; } //zapytanie które wysyła klient
        public Response Response { get; set; } //odpowiedź zwracana do klienta
    }
}
