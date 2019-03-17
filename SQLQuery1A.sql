select distinct * 
from Unit, UnitType 
where Unit.TypeID = UnitType.TypeID and UnitType.TypeID =1
select * from UnitType where TypeID =2

select DoorNumber, Unit.TypeID,Floors,UnitType.Bedrooms, UnitType.Bathrooms,UnitType.Squarefeet,UnitType.Den,UnitType.Patio,UnitType.Price from Unit, UnitType 
where Unit.TypeID =UnitType.TypeID and UnitType.Bedrooms =2 and UnitType.Bathrooms =2 and Unit.RentStatus = 'vacant'