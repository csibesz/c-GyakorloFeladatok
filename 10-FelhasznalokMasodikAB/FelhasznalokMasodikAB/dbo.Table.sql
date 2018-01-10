CREATE TABLE [dbo].[Felhasznalo]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Felhasznalonev] VARCHAR(64) NOT NULL,
	[Jelszo] VARCHAR(64) NOT NULL,
	[RegisztracioIdeje] DATETIME NOT NULL,
	PRIMARY KEY CLUSTERED([Id] ASC),
	UNIQUE NONCLUSTERED([Felhasznalonev] ASC)
);
