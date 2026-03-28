CREATE PROCEDURE usp_CreateAccount
@Username VARCHAR(50),
@PasswordHash VARCHAR(200),
@Salt VARCHAR(200)
AS
BEGIN
INSERT INTO Accounts (Username, PasswordHash, Salt)
VALUES(@Username, @PasswordHash, @Salt)
END

