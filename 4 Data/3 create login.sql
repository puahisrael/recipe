use master
go
drop login  appadmin
go
create login appadmin with password = 'CUCUmber1!';

use HeartyHearthDB
go
drop user if exists appadmin_user
drop role if exists approle
create role approle
create user appadmin_user from login appadmin;
alter role approle add member appadmin_user