using Dataplace.Core.Domain.Entities;
using Dataplace.Core.Domain.Localization.Messages.Extensions;
using Dataplace.Imersao.Core.Domain.Exections;
using Dataplace.Imersao.Core.Domain.Orcamentos.Enums;
using Dataplace.Imersao.Core.Domain.Orcamentos.ValueObjects;
using System;

namespace Dataplace.Imersao.Core.Domain.Orcamentos
{
    public class OrcamentoItem : Entity<OrcamentoItem>
    {

        // uso orm
        protected OrcamentoItem() { }
        public OrcamentoItem(string cdEmpresa, string cdFilial, int numOrcamento, OrcamentoProduto produto, decimal quantidade, OrcamentoItemPreco preco)
        {
            CdEmpresa = cdEmpresa;
            CdFilial = cdFilial;
            NumOrcamento = numOrcamento;
            Produto = produto;
            Quantidade = quantidade;
            AtrubuirPreco(preco);

            // defaults
            Situacao = OrcamentoItemStatusEnum.Aberto;

        }

        public int Seq { get; private set; }
        public string CdEmpresa { get; private set; }
        public string CdFilial { get; private set; }
        public int NumOrcamento { get; private set; }
        public OrcamentoProduto Produto { get; private set; }
        public decimal Quantidade { get; private set; }
        public OrcamentoItemPreco Preco { get; private set; }
        public decimal Total { get; private set; }
        public OrcamentoItemStatusEnum Situacao { get; private set; }

        #region alteração de status
        public void DefinirStiaucao(OrcamentoItemStatusEnum situacao)
        {
            this.Situacao = situacao;
        }

        internal void DefinirProduto(OrcamentoProduto produto)
        {
            this.Produto = produto.IsValid() ? produto : default;
        }

        internal void DefinirPreco(OrcamentoItemPreco preco)
        {
            this.Preco = preco.IsValid() ? preco : default;
        }


        //public void FecharOrcamentoItem()
        //{
        //    if (Situacao == OrcamentoItemStatusEnum.Cancelado)
        //        throw new DomainException("Não é permitido fechar o item do orçamento cancelado!");

        //    if (Situacao == OrcamentoItemStatusEnum.Fechado)
        //        throw new DomainException("O item do orçamento já está fechado!");

        //    Situacao = OrcamentoItemStatusEnum.Fechado;
        //}

        //public void ReabrirOrcamentoItem()
        //{

        //    if (Situacao == OrcamentoItemStatusEnum.Cancelado)
        //        throw new DomainException("Não é permitido reabrir o item do orçamento cancelado!");

        //    if (Situacao == OrcamentoItemStatusEnum.Aberto)
        //        throw new DomainException("O item do orçamento já está Aberto!");

        //    Situacao = OrcamentoItemStatusEnum.Aberto;
        //}

        //public void CancelarOrcamentoItem()
        //{
        //    if (Situacao == OrcamentoItemStatusEnum.Fechado)
        //        throw new DomainException("Não é permitido cancelar o item do orçamento fechado!");

        //    if (Situacao == OrcamentoItemStatusEnum.Cancelado)
        //        throw new DomainException("O item do orçamento já está cancelado!");

        //    Situacao = OrcamentoItemStatusEnum.Cancelado;
        //}

        #endregion
        #region cálculos

        private void AtrubuirPreco(OrcamentoItemPreco preco)
        {
            Preco = preco;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (Quantidade < 0)
                throw new ValueLowerThanZeroDomainException(nameof(Quantidade));

            //if(PrecoVenda < 0)
            //    new ValueLowerThanZeroDomainException(nameof(PrecoVenda));

            Total = Quantidade * Preco.PrecoVenda;
        }
        #endregion

        #region validations
        public override bool IsValid()
        {
            Validation.Requires()
                .IsNotNullOrEmpty(this.CdEmpresa, nameof(CdEmpresa), 18398.ToMessage())
                .IsNotNullOrEmpty(this.CdFilial, nameof(CdFilial), 13065.ToMessage())
                .IsNotNull(this.Produto, nameof(Produto), "O Produto do item é requirido!")
                .IsGreaterThan(this.Quantidade,0M, nameof(Quantidade), "A quantidade do item precisa ser maior que zero!")
                .IsNotNull(this.Preco, nameof(Preco), "O preço do item é requirido!");

            return Validation.Valid;
        }


        #endregion

    }
}
