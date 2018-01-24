IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_SelClientes]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelClientes]

GO

CREATE PROCEDURE [dbo].[SelClientes]


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_SelDadosCliente]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelDadosCliente]

GO

CREATE PROCEDURE [dbo].[SP_SelDadosCliente]
	@CodigoCliente int

	AS
	
	/* Documentação

		Arquivo.....: Cliente.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Seleciona os dados referentes a um cliente

		Exemplo.....: EXEC [dbo].[SP_SelDadosCliente]
		
	*/

	BEGIN
		SELECT	c.CodigoCliente,
				c.CPF,
				c.Nome,
				c.Telefone,
				c.Email,
				c.Numero,
				c.Complemento,
				e.CodigoEndereco,
				e.CEP,
				e.Logradouro,
				e.Bairro,
				e.Cidade,
				e.UF
			FROM [dbo].[Clientes] c
				LEFT OUTER JOIN [dbo].[Enderecos] e
					ON c.CodigoEndereco = e.CodigoEndereco
			--WHERE c.CodigoCliente 
	END

IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_SelDadosCliente]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelDadosCliente]

GO

CREATE PROCEDURE [dbo].[SP_InsCliente]
	@CPF			varchar(14),
	@Nome			varchar(50),
	@Telefone		varchar(15) = NULL,
	@Email			varchar(50) = NULL,
	@Numero			smallint,
	@Complemento	varchar(30) = NULL,
	@Cep			int,
	@Logradouro		varchar(50),
	@Bairro			varchar(30),
	@Cidade			varchar(30),
	@UF				char(2)

	AS

	/* Documentação

		Arquivo.....: Cliente.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Insere um novo cliente
		Retornos....:	0 - Processamento OK
						1 - Falha ao cadastrar o endereco.
						2 - Falha ao cadastrar o cliente.

		Exemplo.....:	EXEC [dbo].[SP_InsCliente] '45104130843', 'Bruno Alves', NULL, NULL, 500, NULL, 14407702, 'Rua: Elias Sampaio',
													'Distrito', 'Franca', 'SP'
		
	*/

	BEGIN

		DECLARE @CodigoEndereco int

		BEGIN TRANSACTION

			INSERT INTO [dbo].[Enderecos]
				VALUES(@CEP, @Logradouro, @Bairro, @Cidade, @UF)
		
			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					ROLLBACK TRANSACTION
					RETURN 1
				END

			SET @CodigoEndereco = SCOPE_IDENTITY()

			INSERT INTO [dbo].[Clientes]
				VALUES(@CodigoEndereco, @CPF, @Nome, @Telefone, @Email, @Numero, @Complemento)

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					ROLLBACK TRANSACTION
					RETURN 2
				END

		COMMIT TRANSACTION
			
	END

IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_UpdCliente]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_UpdCliente]

GO

CREATE PROCEDURE [dbo].[SP_UpdCliente]
	@CPF			varchar(14),
	@Nome			varchar(50),
	@Telefone		varchar(15) = NULL,
	@Email			varchar(50) = NULL,
	@Numero			smallint,
	@Complemento	varchar(30) = NULL,
	@Cep			int,
	@Logradouro		varchar(50),
	@Bairro			varchar(30),
	@Cidade			varchar(30),
	@UF				char(2)

	AS

	/* Documentação

		Arquivo.....: Cliente.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Atualiza as informações do cliente
		Retornos....:	0 - Processamento OK
						1 - Falha ao atualizar os dados do Cliente.
						2 - Falha ao atualizar os dados do endereço.

		Exemplo.....:	EXEC [dbo].[SP_InsCliente] '45104130843', 'Bruno Alves', 992302556, 'Bruno@smn.com.br, 600, NULL, 14407702, 'Rua: Elias Sampaio',
													'Distrito', 'Franca', 'SP'
		
	*/


	BEGIN
		BEGIN TRANSACTION

			UPDATE [dbo].[Clientes]
				SET CPF = @CPF,
					Nome = @Nome		
					Telefone = @Telefone	
					Email = @Email		
					Numero = @Numero		
					Complemento = @Complemento	
				WHERE CodigoCliente = @CodigoCliente	

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				RETURN 1

			UPDATE [dbo].[Enderecos]
				SET Cep = @Cep
					Logradouro = @Logradouro
					Bairro = @Bairro


	END

IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].SP_DelCliente]')
		AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_DelCliente]

GO

CREATE PROCEDURE [dbo].[SP_DelCliente]
	@CodigoCliente int,
	@CodigoEndereco int

	AS

	/* Documentação

		Arquivo.....: Cliente.sql
		Autor.......: Matheus Francisco
		Data........: 22/01/2018
		Objetivo....: Atualiza as informações do cliente
		Retornos....:	0 - Processamento OK
						1 - Falha ao deletar o Cliente.
						2 - Falha ao deletar o endereço.

		Exemplo.....:	EXEC [dbo].[SP_DelCliente] 1, 1
		
	*/

	BEGIN
		BEGIN TRANSACTION

			DELETE FROM [dbo].[Clientes]
				WHERE CodigoCliente = @CodigoCliente

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					ROLLBACK TRANSACTION
					RETURN 1
				END


			DELETE FROM [dbo].[Enderecos]
				WHERE CodigoEndereco = @CodigoEndereco

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					ROLLBACK TRANSACTION
					RETURN 2
				END
			
			COMMIT TRANSACTION
			RETURN 0
				
	END
