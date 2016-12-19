CREATE TABLE [dbo].[users] (
    [user_id]     INT          IDENTITY (1, 1) NOT NULL,
	[role]		  VARCHAR (20) NOT NULL,
    [surname]     VARCHAR (20) NOT NULL,
    [name]        VARCHAR (20) NOT NULL,
    [middle_name] VARCHAR (20) NOT NULL,
    [login]       VARCHAR (20) NOT NULL,
    [password]    VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC),
	CONSTRAINT [AK_LOGIN] UNIQUE NONCLUSTERED ([login] ASC)
);

