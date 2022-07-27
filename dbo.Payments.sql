CREATE TABLE [dbo].[Payments] (
    [PaymentID]    VARCHAR (50) NOT NULL,
    [CustomerName] VARCHAR (50) NOT NULL,
    [BankName]     VARCHAR (50) NOT NULL,
    [CardNumber]   VARCHAR (50) NOT NULL,
    [BankBranch]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentID] ASC)
);

