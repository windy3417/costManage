
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/18/2020 09:31:58
-- Generated from EDMX file: E:\code\成本管理\成本管理\DAL\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [manage];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[xm_plug_t_materailUnitPrice_main]', 'U') IS NOT NULL
    DROP TABLE [dbo].[xm_plug_t_materailUnitPrice_main];
GO
IF OBJECT_ID(N'[dbo].[xm_plug_t_materialUnitPice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[xm_plug_t_materialUnitPice];
GO
IF OBJECT_ID(N'[manageModel1StoreContainer].[xm_plug_v_historyPriceForFisrtRecord]', 'U') IS NOT NULL
    DROP TABLE [manageModel1StoreContainer].[xm_plug_v_historyPriceForFisrtRecord];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'xm_plug_t_materailUnitPrice_main'
CREATE TABLE [dbo].[xm_plug_t_materailUnitPrice_main] (
    [ID] int  NOT NULL,
    [voucherNo] nvarchar(10)  NOT NULL,
    [year] int  NOT NULL,
    [month] int  NOT NULL
);
GO

-- Creating table 'xm_plug_t_materialUnitPice'
CREATE TABLE [dbo].[xm_plug_t_materialUnitPice] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FID] nvarchar(10)  NOT NULL,
    [cinvCode] nvarchar(20)  NOT NULL,
    [unitPrice] float  NOT NULL
);
GO

-- Creating table 'xm_plug_v_historyPriceForFisrtRecord'
CREATE TABLE [dbo].[xm_plug_v_historyPriceForFisrtRecord] (
    [cinvCode] nvarchar(20)  NOT NULL,
    [unitPice] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'xm_plug_t_materailUnitPrice_main'
ALTER TABLE [dbo].[xm_plug_t_materailUnitPrice_main]
ADD CONSTRAINT [PK_xm_plug_t_materailUnitPrice_main]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'xm_plug_t_materialUnitPice'
ALTER TABLE [dbo].[xm_plug_t_materialUnitPice]
ADD CONSTRAINT [PK_xm_plug_t_materialUnitPice]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [cinvCode], [unitPice] in table 'xm_plug_v_historyPriceForFisrtRecord'
ALTER TABLE [dbo].[xm_plug_v_historyPriceForFisrtRecord]
ADD CONSTRAINT [PK_xm_plug_v_historyPriceForFisrtRecord]
    PRIMARY KEY CLUSTERED ([cinvCode], [unitPice] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------