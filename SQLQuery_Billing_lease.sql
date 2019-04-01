Select distinct Lease.LeaseID, Lease.DoorNumber, Lease.BID, Lease.TID, Tenant.First_name, Tenant.Last_name,
Lease.Monthlyrate, Lease.Startdate, Lease.Enddate, Tenant.Email
From Lease,Tenant,Unit
where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID AND Lease.DoorNumber=Unit.DoorNumber