
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/08/2016 16:44:28
-- Generated from EDMX file: h:\documents\visual studio 2015\Projects\Klinik\Klinik.Data\KlinikModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Klinik];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MedicinePurchaseDetailMedicinePurchase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailMedicinePurchases] DROP CONSTRAINT [FK_MedicinePurchaseDetailMedicinePurchase];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicineMedicineStock]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedicineStocks] DROP CONSTRAINT [FK_MedicineMedicineStock];
GO
IF OBJECT_ID(N'[dbo].[FK_MedicineDetailMedicinePurchase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Medicines] DROP CONSTRAINT [FK_MedicineDetailMedicinePurchase];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientVisitDetailPatientVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailPatientVisits] DROP CONSTRAINT [FK_PatientVisitDetailPatientVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientPatientVisit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PatientVisits] DROP CONSTRAINT [FK_PatientPatientVisit];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientDetailHospitalized]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailHospitalizeds] DROP CONSTRAINT [FK_PatientDetailHospitalized];
GO
IF OBJECT_ID(N'[dbo].[FK_HospitalizedDetailHospitalized]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetailHospitalizeds] DROP CONSTRAINT [FK_HospitalizedDetailHospitalized];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Patients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Patients];
GO
IF OBJECT_ID(N'[dbo].[PatientVisits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PatientVisits];
GO
IF OBJECT_ID(N'[dbo].[DetailPatientVisits]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailPatientVisits];
GO
IF OBJECT_ID(N'[dbo].[MedicinePurchases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicinePurchases];
GO
IF OBJECT_ID(N'[dbo].[Medicines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medicines];
GO
IF OBJECT_ID(N'[dbo].[MedicineStocks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedicineStocks];
GO
IF OBJECT_ID(N'[dbo].[DetailMedicinePurchases]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailMedicinePurchases];
GO
IF OBJECT_ID(N'[dbo].[Admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admins];
GO
IF OBJECT_ID(N'[dbo].[DetailHospitalizeds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetailHospitalizeds];
GO
IF OBJECT_ID(N'[dbo].[Hospitalizeds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hospitalizeds];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Patients'
CREATE TABLE [dbo].[Patients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BinusianId] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [BloodType] nvarchar(max)  NOT NULL,
    [Section] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PatientVisits'
CREATE TABLE [dbo].[PatientVisits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeIn] datetime  NOT NULL,
    [TimeOut] datetime  NOT NULL,
    [Diagnose] nvarchar(max)  NOT NULL,
    [Condition] nvarchar(max)  NOT NULL,
    [Treatment] nvarchar(max)  NOT NULL,
    [Comments] nvarchar(max)  NULL,
    [Patient_Id] int  NOT NULL
);
GO

-- Creating table 'DetailPatientVisits'
CREATE TABLE [dbo].[DetailPatientVisits] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Qty] nvarchar(max)  NOT NULL,
    [PatientVisit_Id] int  NOT NULL
);
GO

-- Creating table 'MedicinePurchases'
CREATE TABLE [dbo].[MedicinePurchases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Total] int  NOT NULL
);
GO

-- Creating table 'Medicines'
CREATE TABLE [dbo].[Medicines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MedicineStocks'
CREATE TABLE [dbo].[MedicineStocks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Qty] nvarchar(max)  NOT NULL,
    [ExpDate] datetime  NOT NULL,
    [Medicine_Id] int  NOT NULL
);
GO

-- Creating table 'DetailMedicinePurchases'
CREATE TABLE [dbo].[DetailMedicinePurchases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Qty] nvarchar(max)  NOT NULL,
    [ExpDate] datetime  NOT NULL,
    [MedicinePurchase_Id] int  NOT NULL,
    [Medicine_Id] int  NOT NULL
);
GO

-- Creating table 'Admins'
CREATE TABLE [dbo].[Admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Pass] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetailHospitalizeds'
CREATE TABLE [dbo].[DetailHospitalizeds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Diagnose] nvarchar(max)  NOT NULL,
    [HospitalName] nvarchar(max)  NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [Patient_Id] int  NOT NULL,
    [Hospitalized_Id] int  NOT NULL
);
GO

-- Creating table 'Hospitalizeds'
CREATE TABLE [dbo].[Hospitalizeds] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Patients'
ALTER TABLE [dbo].[Patients]
ADD CONSTRAINT [PK_Patients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PatientVisits'
ALTER TABLE [dbo].[PatientVisits]
ADD CONSTRAINT [PK_PatientVisits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailPatientVisits'
ALTER TABLE [dbo].[DetailPatientVisits]
ADD CONSTRAINT [PK_DetailPatientVisits]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicinePurchases'
ALTER TABLE [dbo].[MedicinePurchases]
ADD CONSTRAINT [PK_MedicinePurchases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Medicines'
ALTER TABLE [dbo].[Medicines]
ADD CONSTRAINT [PK_Medicines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MedicineStocks'
ALTER TABLE [dbo].[MedicineStocks]
ADD CONSTRAINT [PK_MedicineStocks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailMedicinePurchases'
ALTER TABLE [dbo].[DetailMedicinePurchases]
ADD CONSTRAINT [PK_DetailMedicinePurchases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Admins'
ALTER TABLE [dbo].[Admins]
ADD CONSTRAINT [PK_Admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetailHospitalizeds'
ALTER TABLE [dbo].[DetailHospitalizeds]
ADD CONSTRAINT [PK_DetailHospitalizeds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hospitalizeds'
ALTER TABLE [dbo].[Hospitalizeds]
ADD CONSTRAINT [PK_Hospitalizeds]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MedicinePurchase_Id] in table 'DetailMedicinePurchases'
ALTER TABLE [dbo].[DetailMedicinePurchases]
ADD CONSTRAINT [FK_MedicinePurchaseDetailMedicinePurchase]
    FOREIGN KEY ([MedicinePurchase_Id])
    REFERENCES [dbo].[MedicinePurchases]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicinePurchaseDetailMedicinePurchase'
CREATE INDEX [IX_FK_MedicinePurchaseDetailMedicinePurchase]
ON [dbo].[DetailMedicinePurchases]
    ([MedicinePurchase_Id]);
GO

-- Creating foreign key on [Medicine_Id] in table 'MedicineStocks'
ALTER TABLE [dbo].[MedicineStocks]
ADD CONSTRAINT [FK_MedicineMedicineStock]
    FOREIGN KEY ([Medicine_Id])
    REFERENCES [dbo].[Medicines]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicineMedicineStock'
CREATE INDEX [IX_FK_MedicineMedicineStock]
ON [dbo].[MedicineStocks]
    ([Medicine_Id]);
GO

-- Creating foreign key on [Medicine_Id] in table 'DetailMedicinePurchases'
ALTER TABLE [dbo].[DetailMedicinePurchases]
ADD CONSTRAINT [FK_MedicineDetailMedicinePurchase]
    FOREIGN KEY ([Medicine_Id])
    REFERENCES [dbo].[Medicines]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicineDetailMedicinePurchase'
CREATE INDEX [IX_FK_MedicineDetailMedicinePurchase]
ON [dbo].[DetailMedicinePurchases]
    ([Medicine_Id]);
GO

-- Creating foreign key on [PatientVisit_Id] in table 'DetailPatientVisits'
ALTER TABLE [dbo].[DetailPatientVisits]
ADD CONSTRAINT [FK_PatientVisitDetailPatientVisit]
    FOREIGN KEY ([PatientVisit_Id])
    REFERENCES [dbo].[PatientVisits]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientVisitDetailPatientVisit'
CREATE INDEX [IX_FK_PatientVisitDetailPatientVisit]
ON [dbo].[DetailPatientVisits]
    ([PatientVisit_Id]);
GO

-- Creating foreign key on [Patient_Id] in table 'PatientVisits'
ALTER TABLE [dbo].[PatientVisits]
ADD CONSTRAINT [FK_PatientPatientVisit]
    FOREIGN KEY ([Patient_Id])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientPatientVisit'
CREATE INDEX [IX_FK_PatientPatientVisit]
ON [dbo].[PatientVisits]
    ([Patient_Id]);
GO

-- Creating foreign key on [Patient_Id] in table 'DetailHospitalizeds'
ALTER TABLE [dbo].[DetailHospitalizeds]
ADD CONSTRAINT [FK_PatientDetailHospitalized]
    FOREIGN KEY ([Patient_Id])
    REFERENCES [dbo].[Patients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientDetailHospitalized'
CREATE INDEX [IX_FK_PatientDetailHospitalized]
ON [dbo].[DetailHospitalizeds]
    ([Patient_Id]);
GO

-- Creating foreign key on [Hospitalized_Id] in table 'DetailHospitalizeds'
ALTER TABLE [dbo].[DetailHospitalizeds]
ADD CONSTRAINT [FK_HospitalizedDetailHospitalized]
    FOREIGN KEY ([Hospitalized_Id])
    REFERENCES [dbo].[Hospitalizeds]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HospitalizedDetailHospitalized'
CREATE INDEX [IX_FK_HospitalizedDetailHospitalized]
ON [dbo].[DetailHospitalizeds]
    ([Hospitalized_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------