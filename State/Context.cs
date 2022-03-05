using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context // kontekst agregujący stany i zarządzający nimi, jedynym zadaniem tej klasy jest oddelegowanie konkretnej implementacji
                         // do poszczególnego stanu
    {
        private State _currentState; // zmienna zawierająca aktualny stan
        public int AvailableCash { get; set; } = 1000;
        public Context()
        {
            _currentState = new NoCard(this); // do zmiennej _currentState przypisujemy domyślnie wartość NoCard
        }

        public void ChangeState(State newState) // metoda, który zmienia stan na jakiś inny
        {
            _currentState = newState;
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void InsertPin(int pin)
        {
            _currentState.InsertPin(pin);
        }

        public void WithdrawCash(int amount)
        {
            _currentState.WithdrawCash(amount);
        }
    }
}
