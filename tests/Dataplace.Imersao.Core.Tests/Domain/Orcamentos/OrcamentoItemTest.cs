using Dataplace.Imersao.Core.Tests.Fixtures;
using Xunit;

namespace Dataplace.Imersao.Core.Tests.Domain.Orcamentos
{

    [Collection(nameof(OrcamentoCollection))]
    public class OrcamentoItemTest
    {
        private readonly OrcamentoFixture _fixture;

        public OrcamentoItemTest(OrcamentoFixture fixture)
        {
            this._fixture = fixture;
        }



        //[Fact]
        //[Trait("Item", "Adicionar")]
        //public void AdicionarItemAoOrcamentoDeveRetornarSucesso()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var produto = new OrcamentoProduto(TpRegistroEnum.ProdutoFinal, "1");
        //    var quantidade = 4M;
        //    var precoTabela = 10M;



        //    // act
        //    var precoVenda = 10M;
        //    var PercAltPreco = 0;
        //    var total = quantidade * precoVenda;
        //    orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoTotal(precoTabela, precoVenda));

        //    var precoVenda2 = 12;
        //    var PercAltPreco2 = 20;
        //    var total2 = quantidade * precoVenda2;
        //    orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoTotal(precoTabela, precoVenda2));


        //    var precoVenda3 = 8;
        //    var PercAltPreco3 = -20;
        //    var total3 = quantidade * precoVenda3;
        //    orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoPercentual(precoTabela, PercAltPreco3));

        //    var precoVenda4 = 12;
        //    var PercAltPreco4 = 20;
        //    var total4 = quantidade * precoVenda4;
        //    orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoPercentual(precoTabela, PercAltPreco4));


        //    // assert
        //    Assert.NotNull(orcamento.Itens);
        //    Assert.Collection(orcamento.Itens,
        //        item => {
        //            Assert.Equal(quantidade, item.Quantidade);
        //            Assert.Equal(precoTabela, item.Preco.PrecoTabela);
        //            Assert.Equal(precoVenda, item.Preco.PrecoVenda);
        //            Assert.Equal(PercAltPreco, item.Preco.PercAltPreco);
        //            Assert.Equal(total, item.Total);
        //            Assert.Equal(produto.CdProduto, item.Produto.CdProduto);
        //            Assert.Equal(produto.TpProduto, item.Produto.TpProduto);
        //            Assert.Equal(OrcamentoItemStatusEnum.Aberto, item.Situacao);
        //        },
        //        item => {
        //            Assert.Equal(quantidade, item.Quantidade);
        //            Assert.Equal(precoTabela, item.Preco.PrecoTabela);
        //            Assert.Equal(precoVenda2, item.Preco.PrecoVenda);
        //            Assert.Equal(PercAltPreco2, item.Preco.PercAltPreco);
        //            Assert.Equal(total2, item.Total);
        //            Assert.Equal(produto.CdProduto, item.Produto.CdProduto);
        //            Assert.Equal(produto.TpProduto, item.Produto.TpProduto);
        //            Assert.Equal(OrcamentoItemStatusEnum.Aberto, item.Situacao);
        //        },
        //        item => {
        //            Assert.Equal(quantidade, item.Quantidade);
        //            Assert.Equal(precoTabela, item.Preco.PrecoTabela);
        //            Assert.Equal(precoVenda3, item.Preco.PrecoVenda);
        //            Assert.Equal(PercAltPreco3, item.Preco.PercAltPreco);
        //            Assert.Equal(total3, item.Total);
        //            Assert.Equal(produto.CdProduto, item.Produto.CdProduto);
        //            Assert.Equal(produto.TpProduto, item.Produto.TpProduto);
        //            Assert.Equal(OrcamentoItemStatusEnum.Aberto, item.Situacao);
        //        },
        //        item => {
        //            Assert.Equal(quantidade, item.Quantidade);
        //            Assert.Equal(precoTabela, item.Preco.PrecoTabela);
        //            Assert.Equal(precoVenda4, item.Preco.PrecoVenda);
        //            Assert.Equal(PercAltPreco4, item.Preco.PercAltPreco);
        //            Assert.Equal(total4, item.Total);
        //            Assert.Equal(produto.CdProduto, item.Produto.CdProduto);
        //            Assert.Equal(produto.TpProduto, item.Produto.TpProduto);
        //            Assert.Equal(OrcamentoItemStatusEnum.Aberto, item.Situacao);
        //        }

        //  );
        //}


        //[Fact]
        //[Trait("Item", "Adicionar")]
        //public void AdicionarItemValoresNegativoDeveRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var produto = new OrcamentoProduto(TpRegistroEnum.ProdutoFinal, "1");
        //    var quantidade = 1;


        //    // act assert
        //    Assert.Throws<ValueLowerThanZeroDomainException>(() => orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoTotal(0, 1)));
        //    Assert.Throws<ValueLowerThanZeroDomainException>(() => orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoTotal(1, 0)));


     
            
        //}


        //[Fact]
        //[Trait("Item", "Adicionar")]
        //public void AdicionarItemQuantidadeNegativoDeveRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var produto = new OrcamentoProduto(TpRegistroEnum.ProdutoFinal, "1");
  
        //    // act assert
        //    Assert.Throws<ValueLowerThanZeroDomainException>(() => orcamento.AdicionarItem(produto, -1, new OrcamentoItemPrecoTotal(1, 1)));
        //}


        //[Fact]
        //[Trait("Item", "Adicionar")]
        //public void AdicionarItemAoOrcamentoIsValidDeveRetornarSucesso()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var produto = new OrcamentoProduto(TpRegistroEnum.ProdutoFinal, "1");
        //    var quantidade = 4M;
        //    var precoTabela = 10M;
        //    var precoVenda = 10M;
        //    // act
        //    orcamento.AdicionarItem(produto, quantidade, new OrcamentoItemPrecoTotal(precoTabela, precoVenda));


        //    // assert
        //    Assert.NotNull(orcamento.Itens);
        //    Assert.Collection(orcamento.Itens,
        //        item => {
        //            Assert.True(item.IsValid());
        //        }
        //  );
        //}

    }
}
