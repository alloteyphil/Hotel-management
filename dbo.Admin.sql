CREATE TABLE [dbo].[Admin] (
    [First name]   VARCHAR (50) NOT NULL,
    [Last name]    VARCHAR (50) NOT NULL,
    [Username]     VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [Gender]       VARCHAR (50) NOT NULL,
    [Email ]       VARCHAR (50) NOT NULL,
    [Phone number] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([Username] ASC)
);

