
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2020 20:32:15
-- Generated from EDMX file: C:\Users\ddedeaga\source\repos\Proiect2020\ModelDesignFirst_L1\Model1.edmx
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

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [userID] int IDENTITY(1,1) NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Data'
CREATE TABLE [dbo].[Data] (
    [dataId] int IDENTITY(1,1) NOT NULL,
    [dataType] nvarchar(max)  NOT NULL,
    [creationDate] time  NOT NULL,
    [eventName] nvarchar(max)  NOT NULL,
    [people] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [movedData] bit  NOT NULL,
    [favoriteData] bit  NOT NULL
);
GO

-- Creating table 'SpecialProperties'
CREATE TABLE [dbo].[SpecialProperties] (
    [dataId] int IDENTITY(1,1) NOT NULL,
    [propertyID] nvarchar(max)  NOT NULL,
    [propertyName] nvarchar(max)  NOT NULL,
    [propertyDescription] nvarchar(max)  NOT NULL,
    [Datum_dataId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [userID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([userID] ASC);
GO

-- Creating primary key on [dataId] in table 'Data'
ALTER TABLE [dbo].[Data]
ADD CONSTRAINT [PK_Data]
    PRIMARY KEY CLUSTERED ([dataId] ASC);
GO

-- Creating primary key on [dataId] in table 'SpecialProperties'
ALTER TABLE [dbo].[SpecialProperties]
ADD CONSTRAINT [PK_SpecialProperties]
    PRIMARY KEY CLUSTERED ([dataId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Datum_dataId] in table 'SpecialProperties'
ALTER TABLE [dbo].[SpecialProperties]
ADD CONSTRAINT [FK_DataSpecialProperties]
    FOREIGN KEY ([Datum_dataId])
    REFERENCES [dbo].[Data]
        ([dataId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataSpecialProperties'
CREATE INDEX [IX_FK_DataSpecialProperties]
ON [dbo].[SpecialProperties]
    ([Datum_dataId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------