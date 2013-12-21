
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/20/2013 14:29:06
-- Generated from EDMX file: D:\Data\NIPPO\NIPPO\NIPPO_DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [nippo_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_authoritiesusers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users] DROP CONSTRAINT [FK_authoritiesusers];
GO
IF OBJECT_ID(N'[dbo].[FK_userssections]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users] DROP CONSTRAINT [FK_userssections];
GO
IF OBJECT_ID(N'[dbo].[FK_userswork_reports]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[work_reports] DROP CONSTRAINT [FK_userswork_reports];
GO
IF OBJECT_ID(N'[dbo].[FK_work_reportswork_detail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[work_detail] DROP CONSTRAINT [FK_work_reportswork_detail];
GO
IF OBJECT_ID(N'[dbo].[FK_work_detailprojects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[work_detail] DROP CONSTRAINT [FK_work_detailprojects];
GO
IF OBJECT_ID(N'[dbo].[FK_work_detailtasks]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tasks] DROP CONSTRAINT [FK_work_detailtasks];
GO
IF OBJECT_ID(N'[dbo].[FK_projectscustomers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[customers] DROP CONSTRAINT [FK_projectscustomers];
GO
IF OBJECT_ID(N'[dbo].[FK_business_segmentsbusiness_type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[business_type] DROP CONSTRAINT [FK_business_segmentsbusiness_type];
GO
IF OBJECT_ID(N'[dbo].[FK_business_typebusiness_detail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[business_detail] DROP CONSTRAINT [FK_business_typebusiness_detail];
GO
IF OBJECT_ID(N'[dbo].[FK_projectsbusiness_type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projects] DROP CONSTRAINT [FK_projectsbusiness_type];
GO
IF OBJECT_ID(N'[dbo].[FK_projectsbusiness_detail]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[projects] DROP CONSTRAINT [FK_projectsbusiness_detail];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users];
GO
IF OBJECT_ID(N'[dbo].[authorities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[authorities];
GO
IF OBJECT_ID(N'[dbo].[sections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sections];
GO
IF OBJECT_ID(N'[dbo].[work_reports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[work_reports];
GO
IF OBJECT_ID(N'[dbo].[work_detail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[work_detail];
GO
IF OBJECT_ID(N'[dbo].[projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[projects];
GO
IF OBJECT_ID(N'[dbo].[tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tasks];
GO
IF OBJECT_ID(N'[dbo].[customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customers];
GO
IF OBJECT_ID(N'[dbo].[holidays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[holidays];
GO
IF OBJECT_ID(N'[dbo].[business_segments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[business_segments];
GO
IF OBJECT_ID(N'[dbo].[business_type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[business_type];
GO
IF OBJECT_ID(N'[dbo].[business_detail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[business_detail];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [login] nvarchar(max)  NULL,
    [password] nvarchar(max)  NOT NULL,
    [lastname] nvarchar(max)  NOT NULL,
    [firstname] nvarchar(max)  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [authorities_ID] int  NULL,
    [sections_ID] int  NULL
);
GO

-- Creating table 'authorities'
CREATE TABLE [dbo].[authorities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [master] bit  NOT NULL,
    [project_management] bit  NOT NULL,
    [list_viewer] nvarchar(max)  NOT NULL,
    [input] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'sections'
CREATE TABLE [dbo].[sections] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL
);
GO

-- Creating table 'work_reports'
CREATE TABLE [dbo].[work_reports] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [year] smallint  NOT NULL,
    [month] smallint  NOT NULL,
    [day] smallint  NOT NULL,
    [FY] smallint  NOT NULL,
    [start_time] datetime  NULL,
    [end_time] datetime  NULL,
    [work_times] float  NULL,
    [overtime125] float  NULL,
    [overtime150] float  NULL,
    [holiday_work_times] float  NULL,
    [note] nvarchar(max)  NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] smallint  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [rest_time] float  NOT NULL,
    [users_ID] int  NULL
);
GO

-- Creating table 'work_detail'
CREATE TABLE [dbo].[work_detail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [times] float  NOT NULL,
    [note] nvarchar(max)  NULL,
    [work_reports_ID] int  NULL,
    [projects_ID] int  NULL
);
GO

-- Creating table 'projects'
CREATE TABLE [dbo].[projects] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FY] smallint  NOT NULL,
    [num] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [start_date] nvarchar(max)  NULL,
    [end_date] datetime  NULL,
    [project_code] smallint  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] nvarchar(max)  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] nvarchar(max)  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] nvarchar(max)  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [share_flag] bit  NOT NULL,
    [tentative_flag] bit  NOT NULL,
    [tentative_created_by] nvarchar(max)  NULL,
    [business_type_ID] int  NULL,
    [business_detail_ID] int  NULL
);
GO

-- Creating table 'tasks'
CREATE TABLE [dbo].[tasks] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [work_detail_ID] int  NULL
);
GO

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [projects_ID] int  NULL
);
GO

-- Creating table 'holidays'
CREATE TABLE [dbo].[holidays] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [year] decimal(18,0)  NOT NULL,
    [month] decimal(18,0)  NOT NULL,
    [day] decimal(18,0)  NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'business_segments'
CREATE TABLE [dbo].[business_segments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FY] smallint  NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL
);
GO

-- Creating table 'business_type'
CREATE TABLE [dbo].[business_type] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FY] smallint  NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [business_segments_ID] int  NULL
);
GO

-- Creating table 'business_detail'
CREATE TABLE [dbo].[business_detail] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FY] smallint  NOT NULL,
    [code] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [alias] nvarchar(max)  NULL,
    [delete_flag] bit  NOT NULL,
    [created_at] datetime  NULL,
    [created_by] nvarchar(max)  NULL,
    [updated_at] datetime  NULL,
    [updated_by] nvarchar(max)  NULL,
    [deleted_at] datetime  NULL,
    [deleted_by] nvarchar(max)  NULL,
    [business_type_ID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'authorities'
ALTER TABLE [dbo].[authorities]
ADD CONSTRAINT [PK_authorities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'sections'
ALTER TABLE [dbo].[sections]
ADD CONSTRAINT [PK_sections]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'work_reports'
ALTER TABLE [dbo].[work_reports]
ADD CONSTRAINT [PK_work_reports]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'work_detail'
ALTER TABLE [dbo].[work_detail]
ADD CONSTRAINT [PK_work_detail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'projects'
ALTER TABLE [dbo].[projects]
ADD CONSTRAINT [PK_projects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [PK_tasks]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'holidays'
ALTER TABLE [dbo].[holidays]
ADD CONSTRAINT [PK_holidays]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'business_segments'
ALTER TABLE [dbo].[business_segments]
ADD CONSTRAINT [PK_business_segments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'business_type'
ALTER TABLE [dbo].[business_type]
ADD CONSTRAINT [PK_business_type]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'business_detail'
ALTER TABLE [dbo].[business_detail]
ADD CONSTRAINT [PK_business_detail]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [authorities_ID] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [FK_authoritiesusers]
    FOREIGN KEY ([authorities_ID])
    REFERENCES [dbo].[authorities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_authoritiesusers'
CREATE INDEX [IX_FK_authoritiesusers]
ON [dbo].[users]
    ([authorities_ID]);
GO

-- Creating foreign key on [sections_ID] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [FK_userssections]
    FOREIGN KEY ([sections_ID])
    REFERENCES [dbo].[sections]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_userssections'
CREATE INDEX [IX_FK_userssections]
ON [dbo].[users]
    ([sections_ID]);
GO

-- Creating foreign key on [users_ID] in table 'work_reports'
ALTER TABLE [dbo].[work_reports]
ADD CONSTRAINT [FK_userswork_reports]
    FOREIGN KEY ([users_ID])
    REFERENCES [dbo].[users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_userswork_reports'
CREATE INDEX [IX_FK_userswork_reports]
ON [dbo].[work_reports]
    ([users_ID]);
GO

-- Creating foreign key on [work_reports_ID] in table 'work_detail'
ALTER TABLE [dbo].[work_detail]
ADD CONSTRAINT [FK_work_reportswork_detail]
    FOREIGN KEY ([work_reports_ID])
    REFERENCES [dbo].[work_reports]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_work_reportswork_detail'
CREATE INDEX [IX_FK_work_reportswork_detail]
ON [dbo].[work_detail]
    ([work_reports_ID]);
GO

-- Creating foreign key on [projects_ID] in table 'work_detail'
ALTER TABLE [dbo].[work_detail]
ADD CONSTRAINT [FK_work_detailprojects]
    FOREIGN KEY ([projects_ID])
    REFERENCES [dbo].[projects]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_work_detailprojects'
CREATE INDEX [IX_FK_work_detailprojects]
ON [dbo].[work_detail]
    ([projects_ID]);
GO

-- Creating foreign key on [work_detail_ID] in table 'tasks'
ALTER TABLE [dbo].[tasks]
ADD CONSTRAINT [FK_work_detailtasks]
    FOREIGN KEY ([work_detail_ID])
    REFERENCES [dbo].[work_detail]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_work_detailtasks'
CREATE INDEX [IX_FK_work_detailtasks]
ON [dbo].[tasks]
    ([work_detail_ID]);
GO

-- Creating foreign key on [projects_ID] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [FK_projectscustomers]
    FOREIGN KEY ([projects_ID])
    REFERENCES [dbo].[projects]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_projectscustomers'
CREATE INDEX [IX_FK_projectscustomers]
ON [dbo].[customers]
    ([projects_ID]);
GO

-- Creating foreign key on [business_segments_ID] in table 'business_type'
ALTER TABLE [dbo].[business_type]
ADD CONSTRAINT [FK_business_segmentsbusiness_type]
    FOREIGN KEY ([business_segments_ID])
    REFERENCES [dbo].[business_segments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_business_segmentsbusiness_type'
CREATE INDEX [IX_FK_business_segmentsbusiness_type]
ON [dbo].[business_type]
    ([business_segments_ID]);
GO

-- Creating foreign key on [business_type_ID] in table 'business_detail'
ALTER TABLE [dbo].[business_detail]
ADD CONSTRAINT [FK_business_typebusiness_detail]
    FOREIGN KEY ([business_type_ID])
    REFERENCES [dbo].[business_type]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_business_typebusiness_detail'
CREATE INDEX [IX_FK_business_typebusiness_detail]
ON [dbo].[business_detail]
    ([business_type_ID]);
GO

-- Creating foreign key on [business_type_ID] in table 'projects'
ALTER TABLE [dbo].[projects]
ADD CONSTRAINT [FK_projectsbusiness_type]
    FOREIGN KEY ([business_type_ID])
    REFERENCES [dbo].[business_type]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_projectsbusiness_type'
CREATE INDEX [IX_FK_projectsbusiness_type]
ON [dbo].[projects]
    ([business_type_ID]);
GO

-- Creating foreign key on [business_detail_ID] in table 'projects'
ALTER TABLE [dbo].[projects]
ADD CONSTRAINT [FK_projectsbusiness_detail]
    FOREIGN KEY ([business_detail_ID])
    REFERENCES [dbo].[business_detail]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_projectsbusiness_detail'
CREATE INDEX [IX_FK_projectsbusiness_detail]
ON [dbo].[projects]
    ([business_detail_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------