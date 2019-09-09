CREATE TABLE [dbo].[Login]
(
	[IdLogin] INT NOT NULL PRIMARY KEY, 
    [Login] VARCHAR(20) NOT NULL, 
    [Senha] VARCHAR(20) NOT NULL, 
    [DataCadastro] DATETIME NOT NULL
)
