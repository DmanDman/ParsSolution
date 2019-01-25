CREATE TABLE [dbo].[DatabaseGroupUsers] (
    [DatabaseGroupUsersId] BIGINT     IDENTITY (1, 1) NOT NULL,
    [DatabaseGroupID]	   NCHAR(10) NOT NULL, 
	[DoctorID]             NCHAR (10) NULL,
    [UserID]               NCHAR (10) NULL,
    [RoleID] NCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([DatabaseGroupUsersId] ASC)
);

