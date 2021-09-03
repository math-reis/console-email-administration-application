    this.exibirOcultarCampo = exibirOcultarCampo;
    function exibirOcultarCampo(idCampo, bExibe)
    {
        var sExibe = (bExibe) ? 'block' : 'none';
        document.getElementById(idCampo).style.display = sExibe;
        //$("#trCodCliente").css("display", "block");
    }

    this.exibirCamposTipoPessoa = exibirCamposTipoPessoa;
    function exibirCamposTipoPessoa(tipoPessoa)
    {
        var bExibe = (tipoPessoa == 'F') ? true : false;
        //Outra forma (menos enxuta) de fazer a atribuição para o bExibe
        //bExibe = false;
        //if (tipoPessoa == 'F')
        //    bExibe = true;

        exibirOcultarCampo('trNomeMae', bExibe);
        exibirOcultarCampo('trNomeFantasia', !bExibe);
        exibirOcultarCampo('trValorCapital', !bExibe);
        exibirOcultarCampo('trDataConstituicao', !bExibe);
    }

    this.mudarTipoPessoaCadastro = mudarTipoPessoaCadastro;
    function mudarTipoPessoaCadastro()
    {
        var selecaoRadio = getValorRadio('txtCadastroTipoPessoa');
        $('#divCamposInclusao').show();
        exibirCamposTipoPessoa(selecaoRadio);

        if (selecaoRadio == 'F')
        {
            $('label[for=txtCadastroCodCliente]').text('CPF');

            oInfra.getUtil().adicionarMascara('#txtCadastroCodCliente', '{cpf}');
            $('#txtCadastroCodCliente').attr('type', 'mm-cpf');
            $('#txtCadastroCodCliente').attr('mm-regras', 'cpf');
            $('#txtCadastroCodCliente').attr('placeholder', '000.000.000-00');
        }
        if (selecaoRadio == 'J')
        {
            $('label[for=txtCadastroCodCliente]').text('CNPJ');

            oInfra.getUtil().adicionarMascara('#txtCadastroCodCliente', '{cnpj}');
            $('#txtCadastroCodCliente').attr('type', 'mm-cnpj');
            $('#txtCadastroCodCliente').attr('mm-regras', 'cnpj');
            $('#txtCadastroCodCliente').attr('placeholder', '000.000.00/0000-00');
        }
    }

    //Retorna o campo value de um radio que tenha sido selecionado
    this.getValorRadio = getValorRadio;
    function getValorRadio(sNomeRadio)
    {
        var radios = document.getElementsByName(sNomeRadio);
        for (var i=0; i< radios.length; i++)
        {
            if (radios[i].checked)
            {
                return radios[i].value;
            }
        }
        return '';
    }
