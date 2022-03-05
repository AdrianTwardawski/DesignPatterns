using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        private IPizza _pizza; //prywatne pole pod, którym przechowywana jest pizza, którą chcemy udekorować

        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual double CalculatePrice() //metoda wirtualna, po to aby każda implementacja dekoratora była w stanie wprowadzić
                                               //własną implementację tej metody
        {
            return _pizza.CalculatePrice();
        }
    }
}
