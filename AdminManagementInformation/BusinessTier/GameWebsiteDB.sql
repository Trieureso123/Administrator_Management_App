/***** Object: Database [GameWebsiteDB] Script Date: 11/10/2022 10:11:30 AM *****/

CREATE DATABASE [GameDB]
CONTAINMENT = NONE
ON PRIMARY 
( NAME = 'GameDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRIEU\MSSQL\DATA\GameDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
LOG ON
( NAME = N'GameDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TRIEU\MSSQL\DATA\GameDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

USE [GameDB]
GO

/***** Object: Table Account  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo]. [Account]	
( 
	[IdAccount] [INT] IDENTITY(1,1),
	[NameAccount] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL
	CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED
	(
		[IdAccount] ASC
	)
)
GO

/***** Object: Question  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo].[Question] 
( 
	[IdQuestion] [INT] IDENTITY(1,1),
	[Question] [nvarchar](500) NOT NULL,
	[PhoneNumber] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[CreateDate] [DateTime] NOT NULL,
	[IsRead] [BIT] DEFAULT(0) NOT NULL
	CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED
	(
		[IdQuestion] ASC
	)
)
GO

/***** Object: Table Catefory  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo].[Category] 
( 
	[IdCategory] [INT] IDENTITY(1,1),
	[NameCategory] [nvarchar](20) NOT NULL
	CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED
	(
		[IdCategory] ASC
	)
)
GO

/***** Object: Table Lesson  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo].[Lesson] 
( 
	[IdLesson] [INT] IDENTITY(1,1),
	[IdCategory] [INT] NOT NULL,
	[NameLesson] [nvarchar](100) NOT NULL,
	[VideoUrl] [nvarchar](300) NOT NULL
	CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED
	(
		[IdLesson] ASC
	)

)
GO
/***** Object: Table Description  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo].[Description]
(
	[IdDescription] [INT] IDENTITY(1,1),
	[IdLesson] [INT] NOT NULl,
	[Time] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](500) NOT NULL
	CONSTRAINT [PK_Description] PRIMARY KEY CLUSTERED
	(
		[IdDescription] ASC
	)

)
GO

/***** Object: Table Feedback  Script Date: 11/10/2022 10:11:30 AM *****/
CREATE TABLE [dbo].[Feedback]
( 
	[IdFeedback] [INT] primary KEY IDENTITY(1,1),
	[IdLesson] [INT] ,
	[LessonFeedback] [nvarchar](500),
	[PhoneNumber] [nvarchar](15),
	[Rating] [INT],
	[CreateDate] [DateTime],
	[IsRead] [BIT] DEFAULT(0)
)
GO

INSERT INTO [dbo].[Account] VALUES ('admin', 'admin', 'admin')
INSERT INTO [dbo].[Category] VALUES ('2DProgramming')
INSERT INTO [dbo].[Lesson] VALUES(1,'Basic programming with C#', 'https://www.youtube.com/watch?v=gB1F9G0JXOo&ab_channel=freeCodeCamp.org')

INSERT INTO [dbo].[Description] VALUES (1, '9:07','[INT]roducing to Unity [INT]erface')
INSERT INTO [dbo].[Description] VALUES (1, '22:10','Starting with Unity basic')
INSERT INTO [dbo].[Description] VALUES (1, '29:47','RigidBodies and CollidersS')
INSERT INTO [dbo].[Description] VALUES (1, '38:19','Audio Source and UI Elements')
INSERT INTO [dbo].[Description] VALUES (1, '45:47','Moving character with code')
INSERT INTO [dbo].[Description] VALUES (1, '54:22','[INT]roducing to Variables')
INSERT INTO [dbo].[Description] VALUES (1, '1:06:14','Operations with Variables')
INSERT INTO [dbo].[Description] VALUES (1, '1:19:01','Functions')
INSERT INTO [dbo].[Description] VALUES (1, '1:34:22','Conditional Statements')
INSERT INTO [dbo].[Description] VALUES (1, '1:49:29','Loops')
INSERT INTO [dbo].[Description] VALUES (1, '1:58:41','Coroutines')
INSERT INTO [dbo].[Description] VALUES (1, '2:04:39','Classes')
INSERT INTO [dbo].[Description] VALUES (1, '2:16:39','Accessibility Modifiers (Data Encapsulation)')
INSERT INTO [dbo].[Description] VALUES (1, '2:26:54', 'Inheritance')

INSERT INTO [dbo].[Description] VALUES (1, '2:43:35', 'Getting Components')
INSERT INTO [dbo].[Description] VALUES (1, '2:52:32', 'Monster chase game [INT]ro')
INSERT INTO [dbo].[Description] VALUES (1, '2:53:55', 'Importing Assets')
INSERT INTO [dbo].[Description] VALUES (1, '3:02:22', 'Creating player animations')
INSERT INTO [dbo].[Description] VALUES (1, '3:17:36', 'Sorting layers and Order in layer')
INSERT INTO [dbo].[Description] VALUES (1, '3:24:04', 'Creating the game background')
INSERT INTO [dbo].[Description] VALUES (1, '3:33:03', 'Player Movement')
INSERT INTO [dbo].[Description] VALUES (1, '3:50:26', 'Animating the player via code')
INSERT INTO [dbo].[Description] VALUES (1, '4:04:34', 'Player jumping')
INSERT INTO [dbo].[Description] VALUES (1, '4:19:03', 'Camera follow player')
INSERT INTO [dbo].[Description] VALUES (1, '4:30:42', 'Enemy animations')

INSERT INTO [dbo].[Description] VALUES (1, '4:39:40', 'Enemy script')
INSERT INTO [dbo].[Description] VALUES (1, '4:51:15', 'Enemy Spawner')
INSERT INTO [dbo].[Description] VALUES (1, '5:15:15', 'Enemy Collision')
INSERT INTO [dbo].[Description] VALUES (1, '5:31:55', 'The collector script')
INSERT INTO [dbo].[Description] VALUES (1, '5:40:32', 'UI System in Unity')
INSERT INTO [dbo].[Description] VALUES (1, '5:53:06', 'Creating main menu')
INSERT INTO [dbo].[Description] VALUES (1, '6:02:34', 'Navigating between scenes')
INSERT INTO [dbo].[Description] VALUES (1, '6:13:04', 'Selecting a character')
INSERT INTO [dbo].[Description] VALUES (1, '6:20:50', 'Static variables')
INSERT INTO [dbo].[Description] VALUES (1, '6:30:23', 'Singleton Pattern')
INSERT INTO [dbo].[Description] VALUES (1, '6:41:35', 'Events And Delegates')
INSERT INTO [dbo].[Description] VALUES (1, '7:13:11', 'Instantiating the selected character')
INSERT INTO [dbo].[Description] VALUES (1, '7:17:59', 'Finish the game')


INSERT INTO [dbo].[Question] ([Question], [PhoneNumber], [Email], [CreateDate]) VALUES ('why the unity can make game?', '0712596230', 'lac@gmail.com', '2022-09-25 08:07:12')
INSERT INTO [dbo].[Feedback] (IdLesson, LessonFeedback, PhoneNumber, Rating, CreateDate) VALUES (1, 'i have nothing to say hihi', '236034347', 2, '2022-09-25 08:07:12')

select * from [dbo].[Account]
select * from [dbo].[Question]
select * from [dbo].[Category]
select * from [dbo].[Description]
select * from [dbo].[Feedback]
select * from [dbo].[Lesson]
