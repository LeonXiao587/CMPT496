DECLARE @ty int,@floors INT,@BID int,@RantStatus varchar(40),@count int,@door int

SET @ty=1
set	@floors = 1
set @BID = 10
set @RantStatus = 'Occupied'
set @count = 1
WHILE @floors<10 
BEGIN
	WHILE @count< 10
	BEGIN
	set @door = @floors*10 + @count
	INSERT INTO Unit ( TypeID, Floors,RentStatus,BID,DoorNumber)  --xxÎª±íÃû
	VALUES  ( (SELECT TOP 4 TypeID FROM UnitType order by newid()), @floors,@RantStatus,(SELECT TOP 1 BID FROM Building order by newid()),@door  )
	SET @count=@count+1
	END
SET @floors=@floors+1
END