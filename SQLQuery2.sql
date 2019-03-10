DECLARE @ty int,@floors INT,@BID int,@RantStatus varchar(40),@count int,@door int

SET @ty=1
set	@floors = 1
set @BID = 10
set @RantStatus = 'Occupied'
set @count = 1
WHILE @floors<6
BEGIN
	WHILE @count< 10
	BEGIN
	--set @door = @floors * 10 + @count
	INSERT INTO Unit ( TypeID, Floors,RentStatus,BID,DoorNumber)  --xxÎª±íÃû
	VALUES  ( (SELECT TOP 1 TypeID FROM UnitType order by newid()), @floors,(select TOP 1 test FROM test order by newid() ),16,@floors * 100 + @count  )
	SET @count=@count+1
	end
SET @floors=@floors+1
set @count = 1
END
--delete from unit