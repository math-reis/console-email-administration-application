function Pxcsbohn() 
{
    this.mudarTipoSacadoFiltro = mudarTipoPessoaSacado;
    function mudarTipoSacadoFiltro()
    {
        var selecaoRadio = getValorRadio('txtFiltroTipoSacado');
        if (selecaoRadio == 'F')
        {
            $('#divFiltroCpfCnpjSacado').show();
            
            $('label[for=txtFiltroCodCliente]').text('CPF');

            oInfra.getUtil().adicionarMascara('#txtFiltroCodCliente', '{cpf}');
            $('#txtFiltroCpfCnpjSacado').attr('type', 'mm-cpf');
            $('#txtFiltroCpfCnpjSacado').attr('mm-regras', 'cpf');
            $('#txtFiltroCpfCnpjSacado').attr('placeholder', '000.000.000-00');
        }
        else
        {
            $('#divFiltroCpfCnpjSacado').show();

            $('label[for=txtFiltroCpfCnpjSacado]').text('CNPJ');

            oInfra.getUtil().adicionarMascara('#txtFiltroCpfCnpjSacado', '{cnpj}');
            $('#txtFiltroCpfCnpjSacado').attr('type', 'mm-cnpj');
            $('#txtFiltroCpfCnpjSacado').attr('mm-regras', 'cnpj');
            $('#txtFiltroCpfCnpjSacado').attr('placeholder', '000.000.00/0000-00');
        }
    }
}
