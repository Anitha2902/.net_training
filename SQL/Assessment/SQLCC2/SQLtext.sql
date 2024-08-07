create table Employee_Details (
    empno int primary key identity,
    empname varchar(50),
    empsal numeric(10, 2) check (empsal >= 25000),
    emptype char(1) check (emptype IN ('F', 'P'))
);

create or alter procedure AddEmployee
    @EmpName varchar(50),
    @Empsal numeric(10, 2),
    @Emptype char(1)
as
begin
    set nocount on;
    insert into Employee_Details (EmpName, Empsal, Emptype) values (@EmpName, @Empsal, @Emptype);
    select 'Employee added successfully' as status;
end;
 
 
exec AddEmployee 'anitha', 38000.00, 'F';

 
 
select * from Employee_Details