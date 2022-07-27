using Dataplace.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    public class OrcamentoCanceladoEvent : Event
    {
        public OrcamentoCanceladoEvent(int numOcamento)
        {
            NumOcamento = numOcamento;
        }
        public int NumOcamento { get; set; }
    }
}
