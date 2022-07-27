CREATE TABLE [dbo].[Booking] (
    [BookingID]        VARCHAR (50) NOT NULL,
    [CustomerID]       VARCHAR (50) NULL,
    [PaymentID]        VARCHAR (50) NULL,
    [StartDateBooking] VARCHAR (50) NULL,
    [EndDateBooking]   VARCHAR (50) NULL,
    [Room]             VARCHAR (50) NULL,
    [Roomtype]         VARCHAR (50) NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([BookingID] ASC)
);

