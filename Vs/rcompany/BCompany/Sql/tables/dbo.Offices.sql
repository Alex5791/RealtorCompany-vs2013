CREATE TABLE [dbo].[offices] (
    [office_id]  INT          IDENTITY (1, 1) NOT NULL,
    [area]       VARCHAR (20) NOT NULL,
    [street]     VARCHAR (20) NOT NULL,
    [house]      INT          NOT NULL,
    [apartament] INT          NOT NULL,
    [floor]      VARCHAR (20) NOT NULL,
    [S]          INT          NOT NULL,
    [ad_type]    VARCHAR (20) NOT NULL,
    [price]      VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([office_id] ASC)
);

