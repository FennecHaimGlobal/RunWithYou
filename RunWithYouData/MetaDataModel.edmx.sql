
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/29/2016 21:43:56
-- Generated from EDMX file: C:\Worker\RunWithYou\RunWithYouData\MetaDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RunWithYouDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Trails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trails];
GO
IF OBJECT_ID(N'[dbo].[UsersInformation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersInformation];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsersInformations'
CREATE TABLE [dbo].[UsersInformations] (
    [Id] nvarchar(128)  NOT NULL,
    [FirstName] nvarchar(100)  NOT NULL,
    [LastName] nvarchar(100)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Phone1] nvarchar(20)  NOT NULL,
    [Phone2] nvarchar(20)  NOT NULL,
    [Address] nvarchar(200)  NOT NULL,
    [code] nvarchar(10)  NOT NULL,
    [city] nvarchar(100)  NOT NULL,
    [country] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Trails'
CREATE TABLE [dbo].[Trails] (
    [Id] int  NOT NULL,
    [created_by] nvarchar(128)  NOT NULL,
    [created_date] datetime  NULL,
    [update_date] datetime  NULL,
    [date_of_trail] datetime  NOT NULL,
    [place_of_start] nvarchar(max)  NOT NULL,
    [distance] int  NOT NULL,
    [type_of_trail] nvarchar(50)  NOT NULL,
    [description] nvarchar(max)  NULL,
    [geo_location] nchar(10)  NULL,
    [city] nvarchar(100)  NULL,
    [country] nvarchar(100)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UsersInformations'
ALTER TABLE [dbo].[UsersInformations]
ADD CONSTRAINT [PK_UsersInformations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Trails'
ALTER TABLE [dbo].[Trails]
ADD CONSTRAINT [PK_Trails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------