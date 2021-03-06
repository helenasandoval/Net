
USE [Prueba_Lider]
GO

CREATE TABLE [dbo].[TipoDocumento](
	[IdTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)ON [PRIMARY]
) ON [PRIMARY]
GO



GO
CREATE TABLE [dbo].[Pais](
       [paiIdPais] [smallint] IDENTITY(1,1) NOT NULL,
       [paiNomPais] [varchar](50) NOT NULL,
       [paiUsuario] [varchar](30) NOT NULL,
       [paiFchAccion] [datetime] NOT NULL
CONSTRAINT [PK_commPais] PRIMARY KEY CLUSTERED

(
       [paiIdPais] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO




GO

CREATE TABLE [dbo].[Departamento](
       [depIDDepartamento] [tinyint] NOT NULL,
       [depIdPais] [smallint] NOT NULL,
       [depNomDepartamento] [varchar](50) NOT NULL,
       [depUsuario] [varchar](30) NOT NULL,
       [depFecha] [datetime] NOT NULL
CONSTRAINT [PK_commDepartamento] PRIMARY KEY CLUSTERED
(
   [depIDDepartamento] ASC
)ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE Departamento
ADD FOREIGN KEY ([depIdPais]) REFERENCES Pais ([paiIdPais])

GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NULL,
	[Direccion] [varchar](200) NULL,
	[FechaNacimiento] [date] NULL,
	[Cedula] [varchar](20) NULL,
	[TipoDocumento] [int] NULL,
	[Pais] [smallint] NULL,
	[Departamento] [tinyint] NULL,
	[CiudadNacimiento] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Usuario]
ADD FOREIGN KEY ([TipoDocumento]) REFERENCES [TipoDocumento] ([IdTipoDocumento])
go
ALTER TABLE [Usuario]
ADD FOREIGN KEY ([Departamento]) REFERENCES [Departamento] ([depIDDepartamento])

go
ALTER TABLE [Usuario]
ADD FOREIGN KEY ([Pais]) REFERENCES [Pais] ([paiIdPais])

