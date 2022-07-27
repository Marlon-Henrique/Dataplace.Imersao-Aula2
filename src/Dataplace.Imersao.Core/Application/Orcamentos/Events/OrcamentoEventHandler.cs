using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    internal class OrcamentoEventHandler:
         INotificationHandler<OrcamentoAdicionadoEvent>,
         INotificationHandler<OrcamentoAtualizadoEvent>,
         INotificationHandler<OrcamentoCanceladoEvent>,
         INotificationHandler<OrcamentoExcluidoEvent>,
         INotificationHandler<OrcamentoFechadoEvent>,
         INotificationHandler<OrcamentoReabertoEvent>,
         INotificationHandler<OrcamentoItemAdicionadoEvent>,
         INotificationHandler<OrcamentoItemAtualizadoEvent>,
         INotificationHandler<OrcamentoItemExcluidoEvent>
    {
        public Task Handle(OrcamentoAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }

        public Task Handle(OrcamentoAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }

        public Task Handle(OrcamentoCanceladoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }
    
        public Task Handle(OrcamentoFechadoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }

        public Task Handle(OrcamentoExcluidoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }
   
        public Task Handle(OrcamentoReabertoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }
      
        public Task Handle(OrcamentoItemAdicionadoEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
            //notification.Item.Seq;
        }

        public Task Handle(OrcamentoItemAtualizadoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }

        public Task Handle(OrcamentoItemExcluidoEvent notification, CancellationToken cancellationToken)
        {
            // gerar log

            // mandar um email para o gerente
            return Task.CompletedTask;
        }

    }
}
