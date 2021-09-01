const string MENSAGEM_NOME_DUAS_PALAVRAS = "Campo NOME_CLIENTE deve possuir, no mínimo, 2 palavras.";
const string MENSAGEM_DATA_ASSINATURA = "A Data de Assinatura deve ser menor ou igual à Data Atual.";
const string MENSAGEM_DATA_NASCIMENTO = "A Data de Nascimento deve ser menor ou igual à Data de Assinatura.";
const string MENSAGEM_ENDERECO = "É necessário informar TODOS os campos do Endereço ou deixar TODOS em branco.";
const string MENSAGEM_VALOR_IMOVEL = "O valor informado para o imóvel deve ser maior que zero.";

//////////////////////////////

#region Métodos de teste de sucesso.
public void IncluirComSucessoPessoaFisica()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "02321557044";
    toBoletoBanrisul.tiposacado = física;
    base.TestarIncluir(toBoletoBanrisul);
}

public void IncluirComSucessoPessoaJuridica()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "70817279000186";
    toBoletoBanrisul.tiposacado = juridica;
    base.TestarIncluir(toBoletoBanrisul);
}

public void ExcluirComSucessoPessoaFisica()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    base.TestarExcluir(toIdioma);
}

public void ExcluirComSucessoPessoaJuridica()
{
    this.IncluirComSucessoPessoaJuridica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    base.TestarExcluir(toIdioma);
}

[Test(Description="Testa o método Alterar(TOIdioma).", Author="B36635")]
public void AlterarComSucessoTest()
{
    this.IncluirComSucessoPessoaFisica();

    TOIdioma toIdioma = this.PopularCamposObrigatorios();

    //Campo que será alterado
    toIdioma.DescIdioma = "Teste Automatizado Alterado";

    base.TestarAlterar(toIdioma);

    TOIdioma toIdiomaAlterado = this.ObterRegistro();
    //Confirma que o campo foi alterado
    MMAssert.AreEqual("Teste Automatizado Alterado", toIdiomaAlterado.DescIdioma);
}


#endregion

//////////////////////////////

#region Métodos acessórios
private TOBoletoBanrisul PopularCamposObrigatorios()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();

    toBoletoBanrisul.cod_nosso_nro = ???;
    toBoletoBanrisul.nomeValido = "Matheus Reis";
    toBoletoBanrisul.datacriacao = DateTime.Now.Date;
    toBoletoBanrisul.valor = 1000;
    toBoletoBanrisul.cod_operador = 100;    

    return toBoletoBanrisul;
}

#endregion
