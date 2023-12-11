-- use master 
create login hw_login with password = 'HOMEwork1!'

-- switch to HeartyHearthDB
create user hw_user from login hw_login 

alter role db_datareader add member hw_user
alter role db_datawriter add member hw_user