CREATE TABLE [dbo].[Customer] (
    [ID]          VARCHAR (50) NOT NULL,
    [Firstname]   VARCHAR (50) NULL,
    [Lastname]    VARCHAR (50) NULL,
    [Gender]      VARCHAR (50) NULL,
    [Address]     VARCHAR (50) NULL,
    [City]        VARCHAR (50) NULL,
    [Postcode]    VARCHAR (50) NULL,
    [Phonenumber] VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [DateofBirth] VARCHAR (50) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([ID] ASC)
);

