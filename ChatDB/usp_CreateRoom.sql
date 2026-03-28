CREATE PROCEDURE usp_CreateRoom
@RoomName VARCHAR(50),
@RoomPassword VARCHAR(50)
AS
BEGIN
INSERT INTO ROOMS (RoomName, RoomPassword)
VALUES (@RoomName, @RoomPassword)
END