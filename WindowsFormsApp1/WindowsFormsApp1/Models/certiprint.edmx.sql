
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/29/2023 07:04:46
-- Generated from EDMX file: D:\projects\CertiPrint-main\WindowsFormsApp1\WindowsFormsApp1\Models\certiprint.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [certiprint];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[logins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[logins];
GO
IF OBJECT_ID(N'[dbo].[admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[admins];
GO
IF OBJECT_ID(N'[dbo].[facilitators]', 'U') IS NOT NULL
    DROP TABLE [dbo].[facilitators];
GO
IF OBJECT_ID(N'[dbo].[certificates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[certificates];
GO
IF OBJECT_ID(N'[dbo].[students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[students];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'logins'
CREATE TABLE [dbo].[logins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [usertype] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'admins'
CREATE TABLE [dbo].[admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'facilitators'
CREATE TABLE [dbo].[facilitators] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL,
    [subjectName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'certificates'
CREATE TABLE [dbo].[certificates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [schoolName] nvarchar(max)  NOT NULL,
    [schoolAddress] nvarchar(max)  NOT NULL,
    [loginId] int  NOT NULL
);
GO

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [gpa] nvarchar(max)  NOT NULL,
    [grade] nvarchar(max)  NOT NULL,
    [remarks] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'logins'
ALTER TABLE [dbo].[logins]
ADD CONSTRAINT [PK_logins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'admins'
ALTER TABLE [dbo].[admins]
ADD CONSTRAINT [PK_admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'facilitators'
ALTER TABLE [dbo].[facilitators]
ADD CONSTRAINT [PK_facilitators]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'certificates'
ALTER TABLE [dbo].[certificates]
ADD CONSTRAINT [PK_certificates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------