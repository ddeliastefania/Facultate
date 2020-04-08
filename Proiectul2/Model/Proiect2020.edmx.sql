
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 16:25:13
-- Generated from EDMX file: C:\Users\ddedeaga\source\repos\ModelProiect2020\Proiect2020.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Datas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Datas];
GO
IF OBJECT_ID(N'[dbo].[SpecialProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SpecialProperties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Datas'
CREATE TABLE [dbo].[Datas] (
    [DataID] int IDENTITY(1,1) NOT NULL,
    [DateType] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [EventName] nvarchar(max)  NOT NULL,
    [People] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [MovedData] bit  NOT NULL,
    [FavoriteData] bit  NOT NULL
);
GO

-- Creating table 'SpecialProperties'
CREATE TABLE [dbo].[SpecialProperties] (
    [DataID] int IDENTITY(1,1) NOT NULL,
    [PropertyID] int  NOT NULL,
    [PropertyName] nvarchar(max)  NOT NULL,
    [PropertyDescription] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [DataID] in table 'Datas'
ALTER TABLE [dbo].[Datas]
ADD CONSTRAINT [PK_Datas]
    PRIMARY KEY CLUSTERED ([DataID] ASC);
GO

-- Creating primary key on [DataID] in table 'SpecialProperties'
ALTER TABLE [dbo].[SpecialProperties]
ADD CONSTRAINT [PK_SpecialProperties]
    PRIMARY KEY CLUSTERED ([DataID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------