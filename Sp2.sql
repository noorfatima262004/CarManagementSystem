USE FProject
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SignUpOfCustomer
    @Username VARCHAR(255),
    @Password VARCHAR(255),
    @UserType INT,
    @Date DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserId INT;

    -- Insert into Users table and retrieve the UserID
    INSERT INTO Users (UserName, password, UserType) VALUES (@Username, @Password, @UserType);
    SET @UserId = SCOPE_IDENTITY(); -- Retrieve the UserID

    -- Insert into CustomerInformation table using the retrieved UserID
    INSERT INTO CustomerInformation (UserId, Date) VALUES (@UserId, @Date);
END
