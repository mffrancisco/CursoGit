IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_SelVendas]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelVendas]

GO

CREATE PROCEDURE [dbo].[SP_SelVendas]

	AS
	
	/* Documentação

		Arquivo.....: Venda.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Selecionar as vendas cadastradas
		Exemplo.....:	EXEC [dbo].[SP_SelVendas]
		
	*/

	BEGIN

		SELECT	CodigoVenda,
				DataVenda,
				SubTotal,
				Deconto,
				Total
			FROM[dbo].[Vendas]

	END

GO

IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_SelItensVenda]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelItensVenda]

GO

CREATE PROCEDURE [dbo].[SP_SelItensVenda]

	AS

	/* Documentação

		Arquivo.....: Venda.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Seleciona os itens de uma venda
		Exemplo.....:	EXEC [dbo].[SP_SelItensVenda] 1
		
	*/

	BEGIN

		SELECT	v.CodigoVenda
				v.CodigoProduto,
				p.Nome,
				p.Preco,
				v.QuantidadeVendida * p.preco AS Total
			FROM [dbo].[VendaItens] v
				INNER JOIN [dbo].[Produtos] p
					ON p.CodigoProduto = v.CodigoProduto
			WHERE v.CodigoVenda = @CodigoVenda
	
	END

IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_InsVenda]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_InsVenda]

GO

CREATE PROCEDURE [dbo].[SP_InsVenda]

	@CodigoCliente int = NULL,
	@SubTotal decimal(10,2),
	@Total	decimal (10,2),
	@Desconto decimal(10,2) NULL,
	@Entrega	char(1),
	@Cep int = NULL,
	@Logradouro	varchar(50) = NULL
	@Bairro		varchar(30) = NULL,
	@Cidade		varchar(30) = NULL,
	@UF			char(2) = NULL,
	@Numero		smallint = NULL,
	@Complemento	varchar(30) = NULL


	AS

	/* Documentação

		Arquivo.....: Venda.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Seleciona os itens de uma venda
		Paramentros.: @Entrega
						S -- Os produtos da venda serão entregue em um novo endereço.
						N -- Os produtos da venda serão retirados junto a compra.
						C -- Os produtos da venda serão entregues mp endereço do cliente.

		Exemplo.....:	EXEC [dbo].[SP_InsVenda] 1
		
	*/

	BEGIN
		
		INSERT INTO [dbo].[Vendas]
			VALUES(@CodigoCliente, GETDATE(), @SubTotal, @Desconto, @Total, @Entrega)

		IF @@ERROR <> 0 OR @@ROWCOUNT = 0
			RETURN -1

		SET @CodigoVenda = SCOPE_IDENTITY()

		IF @Entrega = 'N'
			RETURN @CodigoVenda

		IF @ENTREGA = 'S'
			BEGIN
				
				IF NOT EXISTS (SELECT TOP 1 1
					FROM [dbo].[Enderecos]
					WHERE Cep = @Cep)

				BEGIN
					INSERT INTO [dbo].[Enderecos]
						VALUES(@Cep, @Logradouro, @Bairro, @Cidade, @UF)

					IF @@ERROR <> 0 OR @@ROWCOUNT = 0
						RETURN -2

					SET @CodigoEndereco = SCOPE_IDENTITY()
				END
		ELSE
				SET @CodigoEndereco = (SELECT	CodigoEndereco
										FROM	[dbo].[Enderecos]
										WHERE Cep = @Cep
		END

		IF @Entrega = 'C'
			SET @CodigoEndereco = (SELECT CodigoEndereco
									FROM [dbo].Clientes]
									WHERE CodigoCliente = @CodigoCliente)

		INSERT INTO [dbo].[Endereco]
			VALUES(@CodigoEndereco, @CodigoVenda, 
				END

			END

	END
