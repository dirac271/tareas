-- TaskDB: script de creación de la tabla Tareas (RF1.1).
-- Se ejecuta sobre la base de datos TaskDB.mdf en SQL Server LocalDB.

CREATE TABLE dbo.Tareas
(
    Id            INT IDENTITY(1,1) NOT NULL,
    Titulo        NVARCHAR(100)     NOT NULL,
    Descripcion   NVARCHAR(500)     NULL,
    Estado        NVARCHAR(20)      NOT NULL CONSTRAINT DF_Tareas_Estado DEFAULT ('Pendiente'),
    FechaCreacion DATETIME          NOT NULL CONSTRAINT DF_Tareas_FechaCreacion DEFAULT (GETDATE()),
    CONSTRAINT PK_Tareas PRIMARY KEY CLUSTERED (Id),
    CONSTRAINT CK_Tareas_Estado CHECK (Estado IN ('Pendiente', 'Completada'))
);
