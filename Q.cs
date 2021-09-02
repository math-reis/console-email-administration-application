MontarCamposChave

//Método_Lucas
if (toBoletoBanrisul.CodNossoNro.FoiSetado)
{
    montagem.Invoke("COD_NOSSO_NRO", new CampoObrigatorio<String>(toBoletoBanrisul.CodNossoNro.ToString().PadLeft(14, '0')));
}
//Método_Nélio
if (toBoletoBanrisul.CodNossoNro.FoiSetado)
{
    CampoObrigatorio<String> CodNossoNro = System.Text.RegularExpressions.Regex.Replace(toBoletoBanrisul.CodNossoNro.LerConteudoOuPadrao(), @"\D", String.Empty).PadLeft(14, '0');
    montagem.Invoke("COD_NOSSO_NRO", CodNossoNro);
}

MontarCampos

montagem.Invoke("CPF_CNPJ_SACADO", toBoletoBanrisul.CpfCnpjSacado);
montagem.Invoke("TIPO_SACADO", toBoletoBanrisul.TipoSacado);
montagem.Invoke("COD_MOEDA", toBoletoBanrisul.CodMoeda);
montagem.Invoke("VALOR_DOCUMENTO", toBoletoBanrisul.ValorDocumento);
montagem.Invoke("COD_OPERADOR", toBoletoBanrisul.CodOperador);
montagem.Invoke("DATA_EMISSAO", toBoletoBanrisul.DataEmissao);
montagem.Invoke("DATA_VENCIMENTO", toBoletoBanrisul.DataVencimento);
montagem.Invoke("DATA_PAGAMENTO", toBoletoBanrisul.DataPagamento);
montagem.Invoke("DATA_CANCELAMENTO", toBoletoBanrisul.DataCancelamento);
montagem.Invoke("SITUACAO", toBoletoBanrisul.Situacao); //Testar com e sem... talvez não precise invocar

if (montagem == this.Sql.MontarCampoWhere)
{
    if (toBoletoBanrisul.NomeSacado.FoiSetado)
    {
        this.Sql.MontarCampoWhere("NOME_SACADO", new CampoObrigatorio<String>("%" + toBoletoBanrisul.NomeSacado.ToString() + "%"), ConstrutorSql.OperadoresUnitarios.Like);
    }
}
else
{
    montagem.Invoke("NOME_SACADO", toBoletoBanrisul.NomeSacado);
}
