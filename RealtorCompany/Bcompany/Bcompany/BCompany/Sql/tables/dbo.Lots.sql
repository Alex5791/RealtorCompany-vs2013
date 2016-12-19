CREATE TABLE [dbo].[lots] (
    [lot_id]  INT          IDENTITY (1, 1) NOT NULL,
    [area]    VARCHAR (20) NOT NULL,
    [street]  VARCHAR (20) NOT NULL,
    [S]       INT          NOT NULL,
    [ad_type] VARCHAR (20) NOT NULL,
    [price]   VARCHAR (20) NOT NULL,
	[date]		 DATE		  NOT NULL,
	[status]	 VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([lot_id] ASC)
);

