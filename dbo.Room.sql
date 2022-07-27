CREATE TABLE [dbo].[Room] (
    [RoomID]           VARCHAR (50) NOT NULL,
    [BookingID]        VARCHAR (50) NULL,
    [Room]             VARCHAR (50) NULL,
    [Roomtype]         VARCHAR (50) NULL,
    [Bedchoice]        VARCHAR (50) NULL,
    [Roomprice]        VARCHAR (50) NULL,
    [Roomavailability] VARCHAR (50) NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomID] ASC)
);

