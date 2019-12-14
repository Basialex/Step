--create trigger onInsertMessage
--On Diseases
--for insert
--as 
--begin
--raiserror('%d rows added', 0,1,@@rowcount)
--end

--insert into Diseases values ('Hv_1')

--select* From  Diseases

--disable trigger onIsertMessage on Diseases

--create trigger  onDeleteflu
--on Diseases
--for delete
--as
--begin
 --declare @temp nvarchar(30)
 --select @temp=[Name]
 --from deleted
 --if (@temp='Flu')
 --rollback transaction
 --else
 --Print(@temp + 'was deleted')
--end

--delete
--from Diseases
----where [Name]='Flu'

--alter trigger onAlterTable
--on Database
--for  Alter_table
--as
--begin
--raiserror ('adimn ',0,1)
--rollback
--end

--alter table Departments
--add NewColum2 int


create trigger onDeleteDoctors
on DOCTORS
for delete 
as
begin
  declare @temp int
  declare @temp2 int
 select @temp=Id, @temp2=Inters.DoctorId
 from deleted,Inters
 where deleted.Id=Inters.DoctorId 
 if (@temp=@temp2)
   Print(@temp + 'Забороняється адміном')
    rollback transaction
end

--Alter table Info
--add   Financu money 


create trigger onInsert
on Departments
for insert
as
begin
declare @salary money
select @salary=inserted.Financu
from inserted
if(@salary>30000)
insert into info(@[Name],@salary)
end

