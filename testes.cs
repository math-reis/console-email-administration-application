// Apagar métodos de preparação!!!

const string MENSAGEM_CPF_INVALIDO = "A Data de Nascimento deve ser menor ou igual à Data de Assinatura.";
const string MENSAGEM_CNPJ_INVALIDO = "A Data de Nascimento deve ser menor ou igual à Data de Assinatura.";
const string MENSAGEM_NOME_DUAS_PALAVRAS = "Campo NOME_CLIENTE deve possuir, no mínimo, 2 palavras.";
const string MENSAGEM_NOME_TRES_LETRAS = "A Data de Assinatura deve ser menor ou igual à Data Atual.";
const string MENSAGEM_VALOR_DOC_MINIMO = "É necessário informar TODOS os campos do Endereço ou deixar TODOS em branco.";
const string MENSAGEM_VALOR_DOC_MAXIMO = "É necessário informar TODOS os campos do Endereço ou deixar TODOS em branco.";
const string MENSAGEM_DATA_PAGAMENTO = "O valor informado para o imóvel deve ser maior que zero.";

//////////////////////////////

#region Métodos de teste de sucesso.
public void AlterarCpfComSucesso()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "02321557044";
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.cpf);
}

public void AlterarCnpjComSucesso()
{
    this.IncluirComSucessoPessoaJuridica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cnpj = "70817279000186";
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.cnpj);
}

public void AlterarTipoSacadoFisicaComSucesso() //Não sei se pode alterar
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.TipoPessoa = TipoPessoa.Juridica;
    toBoletoBanrisul.cnpj = "70817279000186";
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.tipopessoa);
}

public void AlterarTipoSacadoJuridicaComSucesso() //Não sei se pode alterar
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.TipoPessoa = TipoPessoa.Fisica;
    toBoletoBanrisul.cnpj = "02321557044";
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.tipopessoa);
}

public void AlterarNomeSacadoComSucesso() 
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.nome_sacado = "Matheus Gomes Reis";
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.nome_sacado);
}

public void AlterarValorDocComSucesso()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.valor_doc = 5000m;
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.valor_doc);
}

public void AlterarDataPagamentoComSucesso() //É PRA DAR ERRO. SE DER ERRO É PQ TÁ CORRETO. EXCLUIR MÉTODO APÓS ERRO.
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.data_pagamento = DateTime.Now.Today;
    base.TestarAlterar(toBoletoBanrisul);
    TOBoletoBanrisul toBoletoAlterado = this.ObterRegistro();
    MMAssert.AreEqual("Teste Automatizado Alterado", toBoletoAlterado.data_pagamento);
}

public void ContarComSucesso()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    this.PopularCamposOpcionais(toBoletoBanrisul);
    Retorno<Int64> retornoContagem = base.TestarContar(toBoletoBanrisul);
    MMAssert.AreEqual(1, retornoContagem.Dados);
}  

public void ExcluirComSucessoPessoaFisica()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    base.TestarExcluir(toBoletoBanrisul);
}

public void ExcluirComSucessoPessoaJuridica()
{
    this.IncluirComSucessoPessoaJuridica();
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    base.TestarExcluir(toBoletoBanrisul);
}

public void IncluirComSucessoPessoaFisica()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "02321557044";
    toBoletoBanrisul.tiposacado = TipoPessoa.fisica;
    base.TestarIncluir(toBoletoBanrisul);
}

public void IncluirComSucessoPessoaJuridica()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cnpj = "70817279000186";
    toBoletoBanrisul.tiposacado = TipoPessoa.juridica;
    base.TestarIncluir(toBoletoBanrisul);
}

public void ListarComSucesso()
{
    this.IncluirComSucessoPessoaFisica();
    TOBoletoBanrisul toBoletoBanrisul = new TOPaginacao(1, 10);
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    Retorno<List<TOBoletoBanrisul>> retornoListagem = base.TestarListar(toBoletoBanrisul, toPaginacao);
    MMCollectionAssert.Todos(retornoListagem.Dados, this.BuscarToRetornado);
}

private bool BuscarToRetornado(TOBoletoBanrisul toBoletoBanrisul)
{
    return ???.Equals(toBoletoBanrisul.cod_nosso_nro);
}  

public void ObterComSucessoPessoaFisica()
{
    this.IncluirComSucessoPessoaFisica();
    this.ObterRegistro();            
}

private TOBoletoBanrisul ObterRegistro()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    Retorno<TOIdioma> retornoObtencao = this.RN.Obter(toBoletoBanrisul);
    MMAssert.Sucesso(retornoObtencao);
    return retornoObtencao.Dados;
}
#endregion

#region Teste de falha de campo obrigatório

public void IncluirFalhaCampoObrigatorioPK()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    //toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus Reis";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "cod_nosso_nro");
}

public void IncluirFalhaCampoObrigatorioCpf()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.tiposacado = TipoPessoa.física;
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "CPFCNPJ...");
}

public void IncluirFalhaCampoObrigatorioCnpj()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.tiposacado = TipoPessoa.juridica;
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "CPFCNPJ...");
}

public void IncluirFalhaCampoObrigatorioTipoPessoaFisica()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044"; //Verificar se é necessário ou não
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "Tipo_sacado");
}

public void IncluirFalhaCampoObrigatorioNomeSacado()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    //toBoletoBanrisul.nome_sacado = "Matheus Reis";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "nome_sacado");
}

public void IncluirFalhaCampoObrigatorioTipoMoeda()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus Reis";
    //toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "cod_moeda");
}

public void IncluirFalhaCampoObrigatorioValorDoc()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus Reis";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    //toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "valor_doc");
}

public void IncluirFalhaCampoObrigatorioCodOperador()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus Reis";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    //toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "cod_operador");
}

public void IncluirFalhaCampoObrigatorioDataPagamento()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus Reis";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    //toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retorno = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.FalhaCampoObrigatorio(retorno, "data_pagamento");
}
#endregion
public void IncluirCpfInvalido()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "02321557045"; //cpf inválido
    toBoletoBanrisul.tiposacado = TipoPessoa.fisica;
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(MENSAGEM_CPF_INVALIDO);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}

public void IncluirCnpjInvalido()
{
    TOBoletoBanrisul toBoletoBanrisul = this.PopularCamposObrigatorios();
    toBoletoBanrisul.cpf = "70817279000186"; //cnpj inválido
    toBoletoBanrisul.tiposacado = TipoPessoa.juridica;
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(MENSAGEM_CNPJ_INVALIDO);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}

public void IncluirNomeInvalidoUmaPalavra()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Matheus"; //nome inválido
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(NOME_INVALIDO);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}

public void IncluirNomeInvalidoUDuasPalavrasUmaLetras()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "A B"; //nome inválido
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(NOME_INVALIDO);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}

public void IncluirValorDocInvalidoMenorZero()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Ab Cd";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = -1000m; //valor inválido
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(VALOR_DOC);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}

public void IncluirValorDocInvalidoDezMilhoes()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    toBoletoBanrisul.cpf_cnpj_sacado = "02321557044";
    toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Ab Cd";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = -1000000m; //valor inválido
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    Retorno<Int32> retornoInclusao = this.RN.Incluir(toBoletoBanrisul);
    MMAssert.IsFalse(retornoInclusao.OK);
    string mensagemEsperada = string.Format(VALOR_DOC);
    MMAssert.AreEqual(mensagemEsperada, retornoInclusao.Mensagem.ParaUsuario);
}
#region Teste de validação das RNs

#endregion

//////////////////////////////

#region Métodos acessórios
private TOBoletoBanrisul PopularCamposObrigatorios()
{
    TOBoletoBanrisul toBoletoBanrisul = new TOBoletoBanrisul();
    toBoletoBanrisul.cod_nosso_nro = 123;
    //toBoletoBanrisul.cpf_cnpj_sacado = "02321557044"; CPF_VALIDO
    //toBoletoBanrisul.cpf_cnpj_sacado = "70817279000186"; CNPJ_VALIDO
    //toBoletoBanrisul.tipo_sacado = TipoPessoa.fisica;
    toBoletoBanrisul.nome_sacado = "Ab Cd";
    toBoletoBanrisul.cod_moeda = TipoMoeda.real;
    toBoletoBanrisul.valor_documento = 1000m;
    toBoletoBanrisul.cod_operador = "100";
    toBoletoBanrisul.ult_atualizacao = DateTime.Now.Date; 
    return toBoletoBanrisul;
}
#endregion
