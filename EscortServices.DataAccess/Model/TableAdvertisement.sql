CREATE TABLE [dbo].[Advertisement] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Password]        CHAR (32)      NOT NULL,
    [Name]            NVARCHAR (50)  NOT NULL,
    [CityId]          SMALLINT       NOT NULL,
    [CityName]        NVARCHAR (50)  NOT NULL,
    [VoivodeshipId]   SMALLINT       NOT NULL,
    [VoivodeshipName] TINYINT        NOT NULL,
    [Address]         NVARCHAR (100) NULL,
    [Email]           VARCHAR (320)  NOT NULL,
    [Telephone]       VARCHAR (30)   NOT NULL,
    [Age]             TINYINT        NOT NULL,
    [Weight]          TINYINT        NOT NULL,
    [BustSize]        VARCHAR (2)    NOT NULL,
    [English]         BIT            NOT NULL,
    [German]          BIT            NOT NULL,
    [Russian]         BIT            NOT NULL,
    [Price1h]         SMALLINT       NOT NULL,
    [Price30min]      SMALLINT       NULL,
    [Price15min]      SMALLINT       NULL,
    [PriceAllNight]   SMALLINT       NULL,
    [OutCallsId]      TINYINT        NULL,
    [MonFrom]         TIME (0)       NULL,
    [MonTo]           TIME (0)       NULL,
    [TueFrom]         TIME (0)       NULL,
    [TueTo]           TIME (0)       NULL,
    [WedFrom]         TIME (0)       NULL,
    [WedTo]           TIME (0)       NULL,
    [ThuFrom]         TIME (0)       NULL,
    [ThuTo]           TIME (0)       NULL,
    [FriFrom]         TIME (0)       NULL,
    [FroTo]           TIME (0)       NULL,
    [SatFrom]         TIME (0)       NULL,
    [SatTo]           TIME (0)       NULL,
    [SunFrom]         TIME (0)       NULL,
    [SunTo]           TIME (0)       NULL,
    [ContentPL]       NVARCHAR (MAX) NULL,
    [ContentEN]       NVARCHAR (MAX) NULL,
    [ContentDE]       NVARCHAR (MAX) NULL,
    [ContentRU]       NVARCHAR (MAX) NULL,
    [PublicId]        NVARCHAR (61)  NOT NULL,
    [Date]            DATETIME2 (0)  NOT NULL
);


insert into Advertisement
(Password,Name,CityId,CityName,VoivodeshipId,VoivodeshipName,Address,Email,Telephone,Age,Weight,BustSize,English,German,Russian,Price1h,Price30min,Price15min,PriceAllNight,OutCallsId,MonFrom,MonTo,TueFrom,TueTo,WedFrom,WedTo,ThuFrom,ThuTo,FriFrom,FroTo,SatFrom,SatTo,SunFrom,SunTo,ContentPL,ContentEN,ContentDE,ContentRU,PublicId)
values
('df','fd','1','kjl','3','23','3','3','3','3','3','3','True','True','True','1','1','1','1','1','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:00','00:00:01','1','1','1','1','1')