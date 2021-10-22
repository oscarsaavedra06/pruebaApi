# pruebaApi

.Net 5 webApi

Capa de acceso a datos : Entity Framework core 
Base de datos: SQL Server localDB
Comandos para crear base datos : Consola del administrador de paquetes => Proyecto predeterminado Infraestructure=> Update-Database

SQL Script
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [casas] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(50) NULL,
    CONSTRAINT [PK_casas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [solicitudIngresos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(20) NULL,
    [Apellido] nvarchar(20) NULL,
    [Identificacion] int NOT NULL,
    [IdCasa] int NOT NULL,
    CONSTRAINT [PK_solicitudIngresos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211020150150_initial', N'5.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[solicitudIngresos]') AND [c].[name] = N'Identificacion');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [solicitudIngresos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [solicitudIngresos] ALTER COLUMN [Identificacion] nvarchar(10) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211021000013_cambiotipoDato', N'5.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [solicitudIngresos] ADD [Edad] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211022134716_campo-edad', N'5.0.11');
GO

COMMIT;
GO
