using Dataplace.Core.Domain.Commands;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{
    public class CancelarOrcamentoCommand : Command
    {
        public int NumOrcamento { get; set; }
    }
}
