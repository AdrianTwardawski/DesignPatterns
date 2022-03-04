using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Component
    {
        protected IMediator _mediator; //ustawienie referencji do mediatora

        public void SetMediator(IMediator mediator) 
        {
            _mediator = mediator;
        }
    }
}
