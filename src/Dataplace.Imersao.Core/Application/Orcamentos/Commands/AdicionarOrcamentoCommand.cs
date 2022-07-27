using Dataplace.Core.Domain.Commands;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{
    public class AdicionarOrcamentoCommand : RegisterCommand<OrcamentoViewModel>
    {
        public AdicionarOrcamentoCommand(OrcamentoViewModel item) : base(item)
        {
        }
    }
}
