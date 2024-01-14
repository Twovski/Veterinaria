CREATE DATABASE VetReza
GO
USE VetReza
GO

CREATE TABLE Veterinaria(
	VetID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	Direccion NVARCHAR(MAX) NOT NULL,
	"Status" BIT NOT NULL,
	RFC NVARCHAR(50) NOT NULL
)
GO

ALTER TABLE Veterinaria
ADD CONSTRAINT PK_Veterinaria PRIMARY KEY(VetID),
CONSTRAINT DF_StatusVeterinaria DEFAULT(1) FOR "Status" ,
CONSTRAINT UQ_VeterinariaRFC UNIQUE (RFC)
GO

CREATE TABLE Cliente(
	CliID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	"Apellido Paterno" NVARCHAR(50) NOT NULL,
	"Apellido Materno" NVARCHAR(50) NOT NULL,
	Direccion NVARCHAR(MAX) NOT NULL,
	IFE NVARCHAR(30) NOT NULL,
	"Status" BIT NOT NULL,
	Correo NVARCHAR(255) NULL,
	Telefono NVARCHAR(10) NULL,
	Celular NVARCHAR(10) NULL,
	VetID INT NOT NULL
)
GO

ALTER TABLE Cliente 
ADD CONSTRAINT PK_Cliente PRIMARY KEY(CliID),
CONSTRAINT FK_Veterinaria FOREIGN KEY(VetID) 
	REFERENCES Veterinaria(VetID),
CONSTRAINT DF_StatusCliente DEFAULT(1) FOR "Status",
CONSTRAINT UQ_ClienteIFE UNIQUE (IFE)
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_ClienteCorreo
ON Cliente(Correo)
WHERE Correo IS NOT NULL
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_ClienteCelular
ON Cliente(Celular)
WHERE Celular IS NOT NULL;
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_ClienteTelefono
ON Cliente(Telefono)
WHERE Telefono IS NOT NULL
GO

CREATE TABLE TipoAnimal(
	TipoID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL
)
GO

ALTER TABLE TipoAnimal
ADD CONSTRAINT PK_TipoAnimal PRIMARY KEY(TipoID)
GO

CREATE TABLE Paciente(
	PacID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	Sexo CHAR(1) NOT NULL,
	Color NVARCHAR(20) NOT NULL,
	"Status" BIT NOT NULL,
	"Fecha Nacimiento" DATE NULL,
	Edad INT NULL,
	TipoID INT NOT NULL,
	CliID INT NOT NULL
)
GO

ALTER TABLE Paciente
ADD CONSTRAINT PK_Paciente PRIMARY KEY(PacID),
CONSTRAINT FK_TipoAnimal FOREIGN KEY(TipoID)
	REFERENCES TipoAnimal(TipoID),
CONSTRAINT FK_Cliente FOREIGN KEY(CliID)
	REFERENCES Cliente(CliID),
CONSTRAINT DF_StatusPaciente DEFAULT(1) FOR "Status"
GO

CREATE TABLE TipoTratamiento(
	TipoID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
)
GO

ALTER TABLE TipoTratamiento
ADD CONSTRAINT PK_TipoTratamiento PRIMARY KEY(TipoID)
GO

CREATE TABLE Tratamiento(
	TraID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	[Status] BIT NOT NULL,
	TipoID INT NOT NULL
)

ALTER TABLE Tratamiento
ADD CONSTRAINT PK_Tratamiento PRIMARY KEY(TraID),
CONSTRAINT FK_TipoTratamiento FOREIGN KEY(TipoID)
	REFERENCES TipoTratamiento(TipoID),
CONSTRAINT DF_StatusTipoTratamiento DEFAULT(1) FOR [Status]
GO

CREATE TABLE Servicio(
	ServID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	[Status] BIT NOT NULL
)
GO

ALTER TABLE Servicio
ADD CONSTRAINT PK_Servicio PRIMARY KEY(ServID),
CONSTRAINT DF_StatusServicio DEFAULT(1) FOR [Status]

GO

CREATE TABLE Veterinario(
	VetID INT IDENTITY NOT NULL,
	Nombre NVARCHAR(50) NOT NULL,
	[Apellido Paterno] NVARCHAR(50) NOT NULL,
	[Apellido Materno] NVARCHAR(50) NOT NULL,
	RFC NVARCHAR(50) NOT NULL,
	Correo NVARCHAR(255) NOT NULL,
	"Status" BIT NOT NULL
)
GO

ALTER TABLE Veterinario
ADD CONSTRAINT PK_Veterinario PRIMARY KEY(VetID),
CONSTRAINT DF_StatusVeterinario DEFAULT(1) FOR "Status"
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_VeterinarioRFC
ON Veterinario(RFC)
WHERE RFC IS NOT NULL
GO

CREATE UNIQUE NONCLUSTERED INDEX UQ_VeterinarioCorreo
ON Veterinario(Correo)
WHERE Correo IS NOT NULL;
GO

CREATE TABLE Autenticacion(
	VetID INT NOT NULL,
	Contraseña VARCHAR(50) NOT NULL
)
GO

ALTER TABLE Autenticacion
ADD CONSTRAINT PK_Autenticacion PRIMARY KEY(VetID),
CONSTRAINT FK_AutenticacionVeterinario FOREIGN KEY(VetID)
	REFERENCES Veterinario(VetID),
CONSTRAINT DF_Contraseña DEFAULT 'contraseña' FOR Contraseña
GO

CREATE TABLE Cita(
	CitaID INT IDENTITY NOT NULL,
	Motivo NVARCHAR(MAX) NOT NULL,
	Anotaciones NVARCHAR(MAX) NOT NULL,
	VetID INT NOT NULL,
	PacID INT NOT NULL,
	ServID INT NOT NULL,
	Fecha DATETIME NOT NULL
)
GO

ALTER TABLE Cita
ADD CONSTRAINT PK_Cita PRIMARY KEY(CitaID),
CONSTRAINT FK_Paciente FOREIGN KEY(PacID)
	REFERENCES Paciente(PacID),
CONSTRAINT FK_Veterinario FOREIGN KEY(VetID)
	REFERENCES Veterinario(VetID),
CONSTRAINT FK_Servicio FOREIGN KEY(ServID)
	REFERENCES Servicio(ServID),
CONSTRAINT DF_FechaCita DEFAULT GETDATE() FOR Fecha
GO

CREATE TABLE CitaDetalle(
	CitaID INT NOT NULL,
	TraID INT NOT NULL,
	Cantidad INT NOT NULL,
	Fecha DATETIME NOT NULL,
	[Fecha Proxima] DATETIME NULL
)
GO

ALTER TABLE CitaDetalle
ADD CONSTRAINT PK_CitaDetalle PRIMARY KEY(CitaID, TraID),
CONSTRAINT FK_Tratamiento FOREIGN KEY(TraID)
	REFERENCES Tratamiento(TraID),
CONSTRAINT FK_Cita FOREIGN KEY(CitaID)
	REFERENCES Cita(CitaID),
CONSTRAINT DF_FechaDetalle DEFAULT GETDATE() FOR Fecha
GO

CREATE VIEW VW_Cliente
AS
SELECT 
	C.CliID,
	C.Nombre,
	C."Apellido Paterno",
	C."Apellido Materno",
	C.Direccion,
	C.IFE,
	C.Correo,
	C.Telefono,
	C.Celular,
	V.VetID,
	V.Nombre AS Veterinaria
FROM Cliente C
INNER JOIN Veterinaria V
	ON V.VetID = C.VetID
WHERE C.[Status] = 1
GO

CREATE VIEW VW_Paciente
AS
SELECT
P.PacID,
P.Nombre,
P.Sexo,
P.Color,
P.[Status],
P.[Fecha Nacimiento],
P.Edad,
C.CliID,
C.Nombre AS Cliente,
TA.TipoID,
TA.Nombre AS [Tipo Animal]
FROM Paciente P
INNER JOIN Cliente C
	ON C.CliID = P.CliID
INNER JOIN TipoAnimal TA
	ON TA.TipoID = P.TipoID
WHERE P.[Status] = 1
GO

CREATE VIEW VW_Veterinario
AS
SELECT 
*
FROM Veterinario
WHERE [Status] = 1
GO

CREATE VIEW VW_Servicio
AS
SELECT 
* 
FROM Servicio
WHERE [Status] = 1
GO

CREATE VIEW VW_Tratamiento
AS
SELECT 
T.TraID,
T.Nombre,
T.[Status],
TT.TipoID,
TT.Nombre AS [Tipo Tratamiento]
FROM Tratamiento T
INNER JOIN TipoTratamiento TT
	ON T.TipoID = TT.TipoID
WHERE T.[Status] = 1
GO

CREATE VIEW VW_Cita
AS
SELECT
C.CitaID, 
P.PacID,
P.Nombre AS Paciente,
C.Fecha,
C.Motivo,
C.Anotaciones,
V.VetID,
V.Nombre AS Veterinario,
S.ServID,
S.Nombre AS [Servicio]
FROM Cita C
INNER JOIN Veterinario V
	ON V.VetID = C.VetID
INNER JOIN Servicio S
	ON C.ServID = S.ServID
INNER JOIN Paciente P
	ON P.PacID = C.PacID
GO

CREATE VIEW VW_Vacuna
AS
SELECT
C.CitaID, 
C.Fecha,
T.TraID,
T.Nombre AS Vacuna,
CD.Cantidad,
CD.[Fecha Proxima]
FROM Cita C
INNER JOIN CitaDetalle CD
	ON C.CitaID = CD.CitaID
INNER JOIN Tratamiento T
	ON T.TraID = CD.TraID
WHERE T.TipoID = 1
GO

CREATE VIEW VW_Desparasitante
AS
SELECT
C.CitaID, 
C.Fecha,
T.TraID,
T.Nombre AS Desparasitante,
CD.Cantidad,
CD.[Fecha Proxima]
FROM Cita C
INNER JOIN CitaDetalle CD
	ON C.CitaID = CD.CitaID
INNER JOIN Tratamiento T
	ON T.TraID = CD.TraID
WHERE T.TipoID = 2
GO

CREATE VIEW VW_Login
AS
SELECT 
V.*,
A.Contraseña
FROM Autenticacion A
INNER JOIN Veterinario V
	ON A.VetID = V.VetID
GO

CREATE VIEW VW_Notificacion
AS
SELECT 
'¡El paciente ' + P.Nombre + ' ! tiene ahora su tratamiento: ' + T.Nombre + '.'  AS [Mensaje]
FROM CitaDetalle CD
INNER JOIN Cita C
	ON C.CitaID = CD.CitaID
INNER JOIN Paciente P
	ON P.PacID = C.PacID
INNER JOIN Tratamiento T
	ON CD.TraID = T.TraID
WHERE DATEADD(MINUTE, -1, GETDATE()) < CD.[Fecha Proxima] AND CD.[Fecha Proxima] < DATEADD(MINUTE, 1, GETDATE())
GO

INSERT INTO Servicio(Nombre)
VALUES
('Consulta'),
('Cirugia'),
('Estetica')
GO

INSERT INTO TipoTratamiento
VALUES
('Vacuna'),
('Desparasitante')
GO

INSERT INTO TipoAnimal
VALUES
('Perro'),
('Gato')
GO

INSERT INTO Veterinaria(Nombre, Direccion, RFC)
VALUES
('Veterinaria Reza', 'Av. Los Tomateros', 'SDFDFGGHXCZ')
GO


select * from Paciente