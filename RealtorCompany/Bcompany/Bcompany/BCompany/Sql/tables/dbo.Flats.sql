CREATE TABLE [dbo].[flats] (
    [flat_id]    INT           IDENTITY (1, 1) NOT NULL,
    [area]       VARCHAR (20)  NOT NULL,
    [street]     VARCHAR (20)  NOT NULL,
    [house]      INT           NOT NULL,
    [apartament] INT           NOT NULL,
    [floor]      VARCHAR (20)  NOT NULL,
    [numrooms]   INT           NOT NULL,
    [S]          INT           NOT NULL,
    [ad_type]    VARCHAR (20)  NOT NULL,
    [price]      VARCHAR (20)  NOT NULL,
    [date]       DATE		   NOT NULL,
    [status]     VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([flat_id] ASC)
);

