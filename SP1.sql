USE FProject
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE InsertIntoLookup
    @Value VARCHAR(255),
    @Category VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Lookup (value, category) VALUES (@Value, @Category);
END
