using Dataplace.Core.Domain.Commands;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{
    public class ReabrirOrcamentoCommand : Command
    {
        public int NumOcamento { get; set; }
    }
}
