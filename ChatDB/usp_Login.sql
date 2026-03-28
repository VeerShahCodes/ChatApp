CREATE PROCEDURE usp_Login
@Username VARCHAR(50),
@PasswordHash VARCHAR(200)
AS
BEGIN
SELECT AccountID FROM Accounts WHERE @Username=Username AND @PasswordHash=PasswordHash
END