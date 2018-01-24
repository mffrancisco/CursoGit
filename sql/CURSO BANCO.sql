PRODUTOS

INSERT INTO [dbo].[CLIENTES](CodigoEndereco, CPF, NOME, TELEFONE, NUMERO)
	VALUES(1, '42051197806', 'MATHEUS FERREIRA FRANCISCO', '993152149', 1370)

INSERT INTO [dbo].[PRODUTOS]
	VALUES('TECLADO', 50.00, 30)

SELECT NOME,
	--SUM(PRECO)
	--TOTAL = SUM(PRECO)
	--SUM(PRECO) AS TOTAL
	SUM(PRECO) TOTAL
	FROM [dbo].[PRODUTOS]
	GROUP BY NOME
	HAVING SUM(PRECO) > 30.00
--	ORDER BY ESTOQUE ASC

SELECT *
	FROM [dbo].[PRODUTOS]
	--WHERE EMAIL IS NULL

UPDATE [dbo].[CLIENTES]
	SET COMPLEMENTO = 'AP 4'
	WHERE CODIGO_CLIENTE = 2

DELETE FROM [dbo].[CLIENTES]
	--WHERE CODIGO_PRODUTO = 2