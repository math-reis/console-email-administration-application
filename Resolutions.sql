-- Comandos DML

-- SELECT
-- INSERT
-- UPDATE
-- DELETE

-- Sintaxe do comando SELECT

-- SELECT [* ou coluna ou expressão]
-- FROM [TABELA]
-- JOIN [TABELA]
-- ON [TABELA.COLUNA = TABELA.COLUNA]
-- WHERE [Condição]
-- GROUP BY [Agrupar valores iguais de uma coluna]
-- HAVING [Condição pós agrupamento]
-- ORDER BY [Ordem de apresentação]

-- Exercícios

-- Pg. 19

-- Exercício 1:
-- Selecione todas as informações disponíveis das regiões onde se localiza a 
-- empresa.

SELECT COD_REGIAO, NOME_REGIAO 
FROM REGIAO;

-- Exercício 2
-- Selecione o nome dos países cadastrados na empresa.

SELECT NOME_PAIS 
FROM PAIS;

-- Exercício 3
-- Selecione o nome das cidades cadastradas na empresa.

SELECT CIDADE 
FROM LOCAL;

-- Exercício 4
-- Selecione o nome do empregado e o seu percentual de comissão, apresentando a 
-- comissão com o cabeçalho "COMISSAO".

SELECT NOME, PCT_COMISSAO AS "COMISSAO" 
FROM EMPREGADO;

-- Pg. 25

-- Exercício 1
-- Mostrar o nome dos serviços e a diferença entre o salário máximo e o mínimo 
-- para cada um deles. O cabeçalho da coluna de diferenças deve ser “Dif”. 
-- Colocar a saída em ordem descendente das diferenças.

SELECT NOME_SERVICO, SALARIO_MAX - SALARIO_MIN AS "Dif"
FROM SERVICO
ORDER BY "Dif" DESC;

-- Exercício 2
-- Informe os diferentes COD_LOCAL onde há departamentos da empresa.

SELECT COD_LOCAL
FROM DEPARTAMENTO;

-- Exercício 3
-- Informe o código dos diferentes gerentes da empresa, em ordem descendente.

SELECT COD_GERENTE
FROM EMPREGADO
WHERE COD_GERENTE IS NOT NULL
ORDER BY COD_GERENTE DESC;

SELECT DISTINCT COD_GERENTE 
FROM DEPARTAMENTO
WHERE COD_GERENTE IS NOT NULL
ORDER BY COD_GERENTE DESC;

-- Exercício 4
-- Informe o nome e sobrenome de todos os empregados da empresa, por 
-- departamento, ordenando por departamento, descendente, e nome e sobrenome, 
-- ascendentes. Use a posição das colunas no resultado, para indicar o 
-- ordenamento.

SELECT NOME, SOBRENOME, COD_DEP
FROM EMPREGADO
ORDER BY 3 DESC, 1, 2;

-- Pg. 32

-- Exercício 1
-- Mostrar o COD_EMP e a DATA_INICIO do histórico dos empregados, onde 
-- COD_SERVICO for IT_PROG ou SA_MAN.

SELECT COD_EMP, DATA_INICIO
FROM HISTORIA_EMPREGADO
WHERE COD_SERVICO IN ('IT_PROG', 'SA_MAN');

-- Exercício 2
-- Informe o nome dos serviços cujo salário mínimo é menor que 4500 ou o 
-- salário máximo é maior que 12000.

SELECT NOME_SERVICO
FROM SERVICO
WHERE SALARIO_MIN < 4500 OR SALARIO_MAX > 12000;

-- Exercício 3
-- Informe o COD_LOCAL que não tem CEP.

SELECT COD_LOCAL
FROM LOCAL
WHERE CEP IS NULL;

-- Exercício 4
-- Mostre as cidades cujo nome comecem com letra a partir da letra S.

SELECT CIDADE
FROM LOCAL
WHERE CIDADE LIKE 'S%';

-- Pg. 38

-- Exercício 1
-- Mostre a frase 'Eu gosto de trabalhar com SQL', concatenando três grupos de 
-- caracteres diferentes.

SELECT 'Eu gosto ' || 'de trabalhar ' || 'com SQL'
FROM DUAL;

-- Exercício 2
-- Descubra em que posição ocorre a letra 'n' na palavra 
-- 'inconstitucionalissimamente', a partir da sétima posição. E a partir da 
-- posição 15?

SELECT INSTR('inconstitucionalissimamente', 'n', 7), 
       INSTR('inconstitucionalissimamente', 'n', 15)
FROM DUAL;

-- Exercício 3
-- Como fazer para adicionar 'tr' à esquerda de 'Sol' até completar 12 posições.
-- Observe a diferenciação do resultado se forem completadas 12 ou 11 posições.

SELECT LPAD('Sol', 12, 'tr')
FROM DUAL;

-- Exercício 4
-- Qual o comprimento do string resultante da operação de retirada de todos os 
-- brancos à esquerda de ' Teste ', sendo que há 3 brancos à esquerda e 3 à 
-- direita da palavra ?

SELECT LENGTH(LTRIM('   Teste   '))
FROM DUAL;
