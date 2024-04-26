USE FProject
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE CredentialsOfAdmin
    @Username VARCHAR(255),
    @Password VARCHAR(255),
    @UserType INT

AS
BEGIN
    SET NOCOUNT ON;

    -- Insert into Users table and retrieve the UserID
    INSERT INTO Users (UserName, password, UserType) VALUES (@Username, @Password, @UserType);

END
