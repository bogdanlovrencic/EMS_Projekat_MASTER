IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Artikal] (
    [Id] int NOT NULL IDENTITY,
    [NazivArtikla] nvarchar(max) NULL,
    [CijenaArtikla] float NOT NULL,
    [PDV] float NOT NULL,
    [KolicinaNaStanju] int NOT NULL,
    [DatumOd] datetime2 NOT NULL,
    [DatumDo] datetime2 NOT NULL,
    CONSTRAINT [PK_Artikal] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200205233523_InitialMigration', N'2.1.11-servicing-32099');

GO

ALTER TABLE [Artikal] ADD [Izmijenjen] bit NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200205233809_ChangedAttrbut', N'2.1.11-servicing-32099');

GO

