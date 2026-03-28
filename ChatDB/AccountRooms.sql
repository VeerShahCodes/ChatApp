CREATE TABLE [dbo].[AccountRooms]
(
	AccountID INT NOT NULL,
	RoomID INT NOT NULL,
	PRIMARY KEY(AccountID, RoomID),

	CONSTRAINT fk_AccountRooms_AccountID FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID),
	CONSTRAINT fk_AccountRooms_RoomID FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)

)

