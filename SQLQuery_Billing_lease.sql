Select Lease.LeaseID, Tenant.First_name, Tenant.Last_name, Lease.Monthlyrate, Lease.Startdate, Lease.Enddate, Unit.RentStatus
From Lease,Tenant,Unit
where Lease.TID=Tenant.TID AND Lease.BID=Unit.BID