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
VALUES (N'20200205233523_InitialMigration', N'2.1.14-servicing-32113');

GO

ALTER TABLE [Artikal] ADD [Izmijenjen] bit NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200205233809_ChangedAttrbut', N'2.1.14-servicing-32113');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200207225955_IzmjeneArtikal', N'2.1.14-servicing-32113');

GO

CREATE TABLE [izmjeneArtikla] (
    [Id] int NOT NULL IDENTITY,
    [ArtikalId] int NOT NULL,
    [IzmijenjenDatum] datetime2 NOT NULL,
    CONSTRAINT [PK_izmjeneArtikla] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200207230030_IzmjeneArtikalV2', N'2.1.14-servicing-32113');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Artikal]') AND [c].[name] = N'Izmijenjen');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Artikal] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Artikal] DROP COLUMN [Izmijenjen];

GO

ALTER TABLE [izmjeneArtikla] ADD [OldValue] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200207235051_izmjene', N'2.1.14-servicing-32113');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200208141216_IzmjenaCijenaPDVIKolicinaTabele', N'2.1.14-servicing-32113');

GO

CREATE TABLE [IzmjenaCijenaIPdv] (
    [Id] int NOT NULL IDENTITY,
    [ArtikalId] int NOT NULL,
    [StaraCijena] float NULL,
    [StariPdv] float NULL,
    [TipIzmjene] int NOT NULL,
    CONSTRAINT [PK_IzmjenaCijenaIPdv] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [IzmjenaKolicina] (
    [Id] int NOT NULL IDENTITY,
    [ArtikalId] int NOT NULL,
    [StaraKolicina] int NOT NULL,
    CONSTRAINT [PK_IzmjenaKolicina] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200208141303_IzmjenaCijenaPDVIKolicinaTabeleV2', N'2.1.14-servicing-32113');

GO

ALTER TABLE [IzmjenaCijenaIPdv] ADD [DatumIzmjene] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [IzmjenaCijenaIPdv] ADD [NovaCijena] float NULL;

GO

ALTER TABLE [IzmjenaCijenaIPdv] ADD [NoviPdv] float NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200209200112_DodaliNoveAtribute', N'2.1.14-servicing-32113');

GO

