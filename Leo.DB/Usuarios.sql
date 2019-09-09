CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY identity,  
    [Nome] NVARCHAR(50) NOT NULL, 
	[Email] VARCHAR(20) NOT NULL, 
    [Senha] VARCHAR(20) NOT NULL, 

)
