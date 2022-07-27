using Dataplace.Imersao.Core.Tests.Fixtures;
using Xunit;

namespace Dataplace.Imersao.Core.Tests.Domain.Orcamentos
{

    [Collection(nameof(OrcamentoCollection))]
    public class OrcamentoTest
    {
        private readonly OrcamentoFixture _fixture;

        public OrcamentoTest(OrcamentoFixture fixture)
        {
            _fixture = fixture;
        }


        //[Fact]
        //[Trait("Orcamento", "Novo")]
        //public void NovoOrcamentoDevePossuirValoresValidos()
        //{

        //    // arrange act
        //    var orcamento = _fixture.NovoOrcamento();

        //    // assert
        //    Assert.True(orcamento.CdEmpresa == _fixture.CdEmpresa);
        //    Assert.True(orcamento.CdFilial == _fixture.CdFilial);
        //    Assert.True(orcamento.Cliente.Codigo == _fixture.Cliente.Codigo);
        //    Assert.True(orcamento.Usuario.UserName == _fixture.Usuario.UserName);
        //    Assert.True(orcamento.Vendedor.Codigo == _fixture.Vendedor.Codigo);
        //    Assert.True(orcamento.Situacao == Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Aberto);
        //    Assert.Null(orcamento.Validade);
        //    Assert.NotNull(orcamento.TabelaPreco);
        //    Assert.Equal(_fixture.TavelaPreco.CdTabela, orcamento.TabelaPreco.CdTabela);
        //    Assert.Equal(_fixture.TavelaPreco.SqTabela, orcamento.TabelaPreco.SqTabela);
        //}


        //[Fact]
        //[Trait("Orcamento", "Fechar")]
        //public void TentarFecharOrcamentoRetornarStatusFechado()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    // act
        //    orcamento.FecharOrcamento();

        //    // assert
        //    Assert.Equal(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Fechado, orcamento.Situacao);
        //    Assert.NotNull(orcamento.DtFechamento);
        //}

        //[Fact]
        //[Trait("Orcamento", "Fechar")]
        //public void TentarFecharOrcamentoJaFechadoRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.FecharOrcamento();

        //    // act & assert
        //    Assert.Throws<DomainException>(() => orcamento.FecharOrcamento());
        //}

        //[Fact]
        //[Trait("Orcamento", "Fechar")]
        //public void TentarFecharOrcamentoCanceladoRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.CancelarOrcamento();

        //    // act & assert
        //    Assert.Throws<DomainException>(() => orcamento.FecharOrcamento());
        //}

        //[Fact]
        //[Trait("Orcamento", "Reabrir")]
        //public void TentarReabrirOrcamentoRetornarStatusAberto()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.FecharOrcamento();

        //    // act
        //    orcamento.ReabrirOrcamento();

        //    // assert
        //    Assert.Equal(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Aberto, orcamento.Situacao);
        //    Assert.Null(orcamento.DtFechamento);
        //}

        //[Fact]
        //[Trait("Orcamento", "Reabrir")]
        //public void TentarReabrirOrcamentoCanceladoRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.CancelarOrcamento();

        //    // act & assert
        //    Assert.Throws<DomainException>(() => orcamento.ReabrirOrcamento());
        //}

        //[Fact]
        //[Trait("Orcamento", "Reabrir")]
        //public void TentarReabrirOrcamentoAbertoRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    //orcamento.FecharOrcamento();

        //    // act & assert
        //    Assert.Throws<DomainException>(() => orcamento.ReabrirOrcamento());
        //}


        //[Fact]
        //[Trait("Orcamento", "Cancelar")]
        //public void TentarCancelarOrcamentoRetornarStatusCancelado()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();

        //    // act
        //    orcamento.CancelarOrcamento();

        //    // assert
        //    Assert.Equal(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado, orcamento.Situacao);
        //    Assert.Null(orcamento.DtFechamento);
        //}

        //[Fact]
        //[Trait("Orcamento", "Cancelar")]
        //public void TentarCancelarOrcamentoFechadoRetornarException()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.FecharOrcamento();

        //    // act & assert
        //    Assert.Throws<DomainException>(() => orcamento.CancelarOrcamento());
        //}

        //[Fact]
        //[Trait("Orcamento", "Cancelar")]
        //public void TentarCancelarOrcamentoReabertoRetornarStatusCancelado()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    orcamento.FecharOrcamento();
        //    orcamento.ReabrirOrcamento();

        //    // act
        //    orcamento.CancelarOrcamento();

        //    // assert
        //    Assert.Equal(Core.Domain.Orcamentos.Enums.OrcamentoStatusEnum.Cancelado, orcamento.Situacao);
        //    Assert.Null(orcamento.DtFechamento);
        //}




        //[Fact]
        //[Trait("Orcamento", "Atribior Validade")]
        //public void OrcamentoAtribuirValidaDeveRetornarDataEnumDiasValidos()
        //{

        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var validade = 10;

        //    // act
        //    orcamento.DefinirValidade(validade);

        //    // assert
        //    Assert.NotNull(orcamento.Validade);
        //    Assert.Equal(validade, orcamento.Validade.Dias);
        //    Assert.Equal(orcamento.DtOrcamento.AddDays(validade).Date, orcamento.Validade.Data);

        //}

        //[Fact]
        //[Trait("Orcamento", "Atribuir Validade")]
        //public void OrcamentoAtribuirValidaNegativaDeveRetornarException()
        //{

        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    var validade = -1;

        //    // act assert
        //    Assert.Throws<ValueLowerThanZeroDomainException>(() => orcamento.DefinirValidade(validade));

        //}




        //[Fact]
        //[Trait("Orcamento", "IsValid")]
        //public void OrcamentoIsValidRetornarStatusValido()
        //{
        //    // arrange
        //    var orcamento = _fixture.NovoOrcamento();
        //    // act
        //    orcamento.FecharOrcamento();

        //    // assert
        //    Assert.True(orcamento.IsValid());
        //}
    }
}
