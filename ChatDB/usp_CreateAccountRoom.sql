CREATE PROCEDURE usp_CreateAccountRoom
@AccountID INT,
@RoomID INT
AS
BEGIN
INSERT INTO AccountRooms (AccountID, RoomID)
VALUES (@AccountID, @RoomID)
END