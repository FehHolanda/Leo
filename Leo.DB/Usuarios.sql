CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT NOT NULL PRIMARY KEY identity, 
    [IdLogin] INT NOT NULL, 
    [IdPerfil] INT NOT NULL, 
    [Nome] NVARCHAR(50) NOT NULL, 
    [EhAtivo] BIT NOT NULL, 
    [DataCadastro] DATETIME NOT NULL,
)
