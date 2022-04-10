create database employee;

use employee;

create table emp_details
(
e_id int primary key auto_increment,
e_name varchar(20),
e_salary int
);

insert into emp_details (e_name, e_salary) 
values ('anzit',5000),('ujwal',45313),('Kshitiz',992000);

select * from emp_details;

select  * from emp_details where e_salary=(select max(e_salary) from emp_details);

update emp_details set e_salary=10 where e_id=3;

update emp_details set e_name= 'anzitey chor' where e_id=3;

update emp_details set e_name= 'khsitiz' where e_id= 1;

delete from emp_details where e_id=1;

insert into emp_details values(1,'anzit',900000);

alter table emp_details
add column address varchar(50);

alter table emp_details
drop column address;

update  emp_details set address='Ramechaap angu tha chap' where e_id=1;
update  emp_details set address='Ramechaap angu tha chap' where e_id=2;
update  emp_details set address='Ramechaap angu tha chap' where e_id=3;

delete from emp_details where e_id=3;
 insert into emp_details values(3,'kshitiz',56666,'ramechaap');
