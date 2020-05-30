CREATE TABLE [dbo].[Medicines] (
    [idMedicine]     INT  NOT NULL,
    [Name]           TEXT NOT NULL,
    [Dosage]         TEXT NOT NULL,
    [Date_of_issue]  DATE NOT NULL,
    [Expiration_day] DATE NOT NULL,
    [Visit_id]       INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([idMedicine] ASC)
);

