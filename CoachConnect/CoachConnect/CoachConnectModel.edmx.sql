
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/26/2017 19:28:08
-- Generated from EDMX file: D:\Spring Semester\team software\TeamProject\22393_Team2\CoachConnect\CoachConnect\CoachConnectModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_sft_2172];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Course_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_Course_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Department_Interest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Department] DROP CONSTRAINT [FK_Department_Interest];
GO
IF OBJECT_ID(N'[dbo].[FK_Room_Building]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Room] DROP CONSTRAINT [FK_Room_Building];
GO
IF OBJECT_ID(N'[dbo].[FK_Session_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Session] DROP CONSTRAINT [FK_Session_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_Session_Room]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Session] DROP CONSTRAINT [FK_Session_Room];
GO
IF OBJECT_ID(N'[dbo].[FK_SessionRoster_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SessionRoster] DROP CONSTRAINT [FK_SessionRoster_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCourse_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCourse] DROP CONSTRAINT [FK_UserCourse_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCourse_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCourse] DROP CONSTRAINT [FK_UserCourse_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCourse_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCourse] DROP CONSTRAINT [FK_UserCourse_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Building]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Building];
GO
IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[Day]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Day];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[Interest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Interest];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Room]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Room];
GO
IF OBJECT_ID(N'[dbo].[Session]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Session];
GO
IF OBJECT_ID(N'[dbo].[SessionRoster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SessionRoster];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TimePeriod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimePeriod];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UserAvailability]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserAvailability];
GO
IF OBJECT_ID(N'[dbo].[UserCourse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCourse];
GO
IF OBJECT_ID(N'[db_sft_2172ModelStoreContainer].[CoachByName]', 'U') IS NOT NULL
    DROP TABLE [db_sft_2172ModelStoreContainer].[CoachByName];
GO
IF OBJECT_ID(N'[db_sft_2172ModelStoreContainer].[CoachByTime]', 'U') IS NOT NULL
    DROP TABLE [db_sft_2172ModelStoreContainer].[CoachByTime];
GO
IF OBJECT_ID(N'[db_sft_2172ModelStoreContainer].[CoachInterest]', 'U') IS NOT NULL
    DROP TABLE [db_sft_2172ModelStoreContainer].[CoachInterest];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Buildings'
CREATE TABLE [dbo].[Buildings] (
    [BuildingID] nvarchar(50)  NOT NULL,
    [BuildingName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [CourseID] nvarchar(50)  NOT NULL,
    [CourseName] nvarchar(100)  NOT NULL,
    [IsActive] bit  NOT NULL,
    [DepartmentID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [RoomID] nvarchar(50)  NOT NULL,
    [RoomNumber] nvarchar(25)  NOT NULL,
    [OpenTime] time  NOT NULL,
    [CloseTime] time  NOT NULL,
    [BuildingID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Sessions'
CREATE TABLE [dbo].[Sessions] (
    [SessionID] nvarchar(50)  NOT NULL,
    [StartTime] time  NOT NULL,
    [EndTime] time  NOT NULL,
    [RoomID] nvarchar(50)  NOT NULL,
    [CourseID] nvarchar(50)  NOT NULL,
    [IsMonday] nvarchar(50)  NULL,
    [IsTuesday] bit  NULL,
    [IsWednesday] bit  NULL,
    [IsThursday] bit  NULL,
    [IsFriday] bit  NULL,
    [IsSaturday] bit  NULL
);
GO

-- Creating table 'SessionRosters'
CREATE TABLE [dbo].[SessionRosters] (
    [SessionID] nvarchar(50)  NOT NULL,
    [UserID] nchar(10)  NOT NULL,
    [RoleID] nchar(10)  NOT NULL
);
GO

-- Creating table 'TimePeriods'
CREATE TABLE [dbo].[TimePeriods] (
    [TimePeriodID] varchar(25)  NOT NULL,
    [TimePeriodName] varchar(25)  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [DepartmentID] nvarchar(50)  NOT NULL,
    [DepartmentName] nvarchar(50)  NOT NULL,
    [InterestID] nvarchar(50)  NULL
);
GO

-- Creating table 'Interests'
CREATE TABLE [dbo].[Interests] (
    [InterestID] nvarchar(50)  NOT NULL,
    [InterestName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [RoleID] nvarchar(5)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(100)  NOT NULL,
    [FirstName] nvarchar(100)  NOT NULL,
    [IsAdmin] bit  NOT NULL,
    [IsCoach] bit  NOT NULL,
    [Password] nvarchar(50)  NULL,
    [IsActive] bit  NOT NULL,
    [IsStudent] bit  NOT NULL,
    [ProfilePic] nvarchar(50)  NULL,
    [ActiveCoachSince] datetime  NULL,
    [MiddleName] nvarchar(100)  NULL,
    [Phone] varchar(10)  NULL,
    [Email] nvarchar(320)  NULL,
    [DisplayName] nvarchar(200)  NOT NULL,
    [ResetPassword] bit  NOT NULL
);
GO

-- Creating table 'Days'
CREATE TABLE [dbo].[Days] (
    [DayID] varchar(25)  NOT NULL,
    [DayName] varchar(25)  NOT NULL
);
GO

-- Creating table 'UserAvailabilities'
CREATE TABLE [dbo].[UserAvailabilities] (
    [DayID] varchar(25)  NOT NULL,
    [TimePeriodID] varchar(25)  NOT NULL,
    [UserID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'UserCourses'
CREATE TABLE [dbo].[UserCourses] (
    [UserID] nvarchar(50)  NOT NULL,
    [RoleID] nvarchar(5)  NOT NULL,
    [CourseID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'CoachInterests'
CREATE TABLE [dbo].[CoachInterests] (
    [UserID] nvarchar(50)  NOT NULL,
    [Coach] nvarchar(201)  NOT NULL,
    [Time] varchar(25)  NOT NULL,
    [Day] varchar(25)  NOT NULL,
    [CourseID] nvarchar(50)  NOT NULL,
    [Subjects] nvarchar(100)  NOT NULL,
    [Interest] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'CoachByTimes'
CREATE TABLE [dbo].[CoachByTimes] (
    [UserID] nvarchar(50)  NOT NULL,
    [Coach] nvarchar(201)  NOT NULL,
    [Time] varchar(25)  NOT NULL,
    [Day] varchar(25)  NOT NULL,
    [CourseID] nvarchar(50)  NOT NULL,
    [Subject] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'CoachByNames'
CREATE TABLE [dbo].[CoachByNames] (
    [LastName] nvarchar(100)  NULL,
    [FirstName] nvarchar(100)  NOT NULL,
    [IsCoach] bit  NOT NULL,
    [IsActive] bit  NOT NULL,
    [ActiveCoachSince] datetime  NULL,
    [UserID] nvarchar(50)  NOT NULL,
    [ProfilePic] nvarchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BuildingID] in table 'Buildings'
ALTER TABLE [dbo].[Buildings]
ADD CONSTRAINT [PK_Buildings]
    PRIMARY KEY CLUSTERED ([BuildingID] ASC);
GO

-- Creating primary key on [CourseID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([CourseID] ASC);
GO

-- Creating primary key on [RoomID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([RoomID] ASC);
GO

-- Creating primary key on [SessionID] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [PK_Sessions]
    PRIMARY KEY CLUSTERED ([SessionID] ASC);
GO

-- Creating primary key on [SessionID], [UserID], [RoleID] in table 'SessionRosters'
ALTER TABLE [dbo].[SessionRosters]
ADD CONSTRAINT [PK_SessionRosters]
    PRIMARY KEY CLUSTERED ([SessionID], [UserID], [RoleID] ASC);
GO

-- Creating primary key on [TimePeriodID] in table 'TimePeriods'
ALTER TABLE [dbo].[TimePeriods]
ADD CONSTRAINT [PK_TimePeriods]
    PRIMARY KEY CLUSTERED ([TimePeriodID] ASC);
GO

-- Creating primary key on [DepartmentID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([DepartmentID] ASC);
GO

-- Creating primary key on [InterestID] in table 'Interests'
ALTER TABLE [dbo].[Interests]
ADD CONSTRAINT [PK_Interests]
    PRIMARY KEY CLUSTERED ([InterestID] ASC);
GO

-- Creating primary key on [RoleID] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([RoleID] ASC);
GO

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [DayID] in table 'Days'
ALTER TABLE [dbo].[Days]
ADD CONSTRAINT [PK_Days]
    PRIMARY KEY CLUSTERED ([DayID] ASC);
GO

-- Creating primary key on [DayID], [TimePeriodID], [UserID] in table 'UserAvailabilities'
ALTER TABLE [dbo].[UserAvailabilities]
ADD CONSTRAINT [PK_UserAvailabilities]
    PRIMARY KEY CLUSTERED ([DayID], [TimePeriodID], [UserID] ASC);
GO

-- Creating primary key on [UserID], [CourseID] in table 'UserCourses'
ALTER TABLE [dbo].[UserCourses]
ADD CONSTRAINT [PK_UserCourses]
    PRIMARY KEY CLUSTERED ([UserID], [CourseID] ASC);
GO

-- Creating primary key on [Coach], [Day], [Time], [Subjects], [Interest], [UserID], [CourseID] in table 'CoachInterests'
ALTER TABLE [dbo].[CoachInterests]
ADD CONSTRAINT [PK_CoachInterests]
    PRIMARY KEY CLUSTERED ([Coach], [Day], [Time], [Subjects], [Interest], [UserID], [CourseID] ASC);
GO

-- Creating primary key on [UserID], [Coach], [Time], [Day], [Subject], [CourseID] in table 'CoachByTimes'
ALTER TABLE [dbo].[CoachByTimes]
ADD CONSTRAINT [PK_CoachByTimes]
    PRIMARY KEY CLUSTERED ([UserID], [Coach], [Time], [Day], [Subject], [CourseID] ASC);
GO

-- Creating primary key on [FirstName], [IsCoach], [IsActive], [UserID] in table 'CoachByNames'
ALTER TABLE [dbo].[CoachByNames]
ADD CONSTRAINT [PK_CoachByNames]
    PRIMARY KEY CLUSTERED ([FirstName], [IsCoach], [IsActive], [UserID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BuildingID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [FK_Room_Building]
    FOREIGN KEY ([BuildingID])
    REFERENCES [dbo].[Buildings]
        ([BuildingID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Room_Building'
CREATE INDEX [IX_FK_Room_Building]
ON [dbo].[Rooms]
    ([BuildingID]);
GO

-- Creating foreign key on [CourseID] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [FK_Session_Course]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Session_Course'
CREATE INDEX [IX_FK_Session_Course]
ON [dbo].[Sessions]
    ([CourseID]);
GO

-- Creating foreign key on [RoomID] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [FK_Session_Room]
    FOREIGN KEY ([RoomID])
    REFERENCES [dbo].[Rooms]
        ([RoomID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Session_Room'
CREATE INDEX [IX_FK_Session_Room]
ON [dbo].[Sessions]
    ([RoomID]);
GO

-- Creating foreign key on [SessionID] in table 'SessionRosters'
ALTER TABLE [dbo].[SessionRosters]
ADD CONSTRAINT [FK_SessionRoster_Session]
    FOREIGN KEY ([SessionID])
    REFERENCES [dbo].[Sessions]
        ([SessionID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DepartmentID] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Course_Department]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([DepartmentID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Course_Department'
CREATE INDEX [IX_FK_Course_Department]
ON [dbo].[Courses]
    ([DepartmentID]);
GO

-- Creating foreign key on [InterestID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_Department_Interest]
    FOREIGN KEY ([InterestID])
    REFERENCES [dbo].[Interests]
        ([InterestID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Department_Interest'
CREATE INDEX [IX_FK_Department_Interest]
ON [dbo].[Departments]
    ([InterestID]);
GO

-- Creating foreign key on [DayID] in table 'UserAvailabilities'
ALTER TABLE [dbo].[UserAvailabilities]
ADD CONSTRAINT [FK_UserAvailability_Day]
    FOREIGN KEY ([DayID])
    REFERENCES [dbo].[Days]
        ([DayID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TimePeriodID] in table 'UserAvailabilities'
ALTER TABLE [dbo].[UserAvailabilities]
ADD CONSTRAINT [FK_UserAvailability_TimePeriod]
    FOREIGN KEY ([TimePeriodID])
    REFERENCES [dbo].[TimePeriods]
        ([TimePeriodID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAvailability_TimePeriod'
CREATE INDEX [IX_FK_UserAvailability_TimePeriod]
ON [dbo].[UserAvailabilities]
    ([TimePeriodID]);
GO

-- Creating foreign key on [UserID] in table 'UserAvailabilities'
ALTER TABLE [dbo].[UserAvailabilities]
ADD CONSTRAINT [FK_UserAvailability_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserAvailability_User'
CREATE INDEX [IX_FK_UserAvailability_User]
ON [dbo].[UserAvailabilities]
    ([UserID]);
GO

-- Creating foreign key on [CourseID] in table 'UserCourses'
ALTER TABLE [dbo].[UserCourses]
ADD CONSTRAINT [FK_UserCourse_Course]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([CourseID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCourse_Course'
CREATE INDEX [IX_FK_UserCourse_Course]
ON [dbo].[UserCourses]
    ([CourseID]);
GO

-- Creating foreign key on [RoleID] in table 'UserCourses'
ALTER TABLE [dbo].[UserCourses]
ADD CONSTRAINT [FK_UserCourse_Role]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[Roles]
        ([RoleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCourse_Role'
CREATE INDEX [IX_FK_UserCourse_Role]
ON [dbo].[UserCourses]
    ([RoleID]);
GO

-- Creating foreign key on [UserID] in table 'UserCourses'
ALTER TABLE [dbo].[UserCourses]
ADD CONSTRAINT [FK_UserCourse_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------