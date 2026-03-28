CREATE PROCEDURE usp_JoinRoom
@RoomName VARCHAR(50),
@RoomPassword VARCHAR(50)
AS
BEGIN
SELECT RoomID FROM Rooms WHERE RoomName=@RoomName AND RoomPassword=@RoomPassword
END