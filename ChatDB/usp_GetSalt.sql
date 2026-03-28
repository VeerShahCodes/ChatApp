CREATE PROCEDURE usp_GetSalt
@Username VARCHAR(50)
AS
BEGIN
SELECT Salt FROM Accounts WHERE @Username=Username
END