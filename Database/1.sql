create database work;

use work;

create table work1
(
id int primary key auto_increment,
name varchar(20),
address varchar(20),
contact int 
);

insert into work1 (name,address,contact) values ('ronaldo','portugal',9865652),('messi','Argentina',985621),('Neymar','Brazil',9533244),('Pogba','France',65256546);
drop table work1;
select * from work1;


update work1 set name='Leroy Sane' where id= 1;
update work1 set address='Germany' where id = 1;




 

create table work2
(
w_eid int primary key auto_increment,
w_name varchar(20),
w_address varchar(20),
w_contact int
);

alter table work1 add column w_eid int ,
add  foreign key(w_eid) references work2(w_eid);
alter table work1
add constraint fk_work2 foreign key(w_eid) references work2(w_eid);

alter table work1
drop  constraint fk_work2;
alter table work1
drop column w_eid;
desc work1;

insert into work2 (w_name,w_address,w_contact)
values ('Lewandoski','Poland',99855),('Suraez','Uruguay',664687),('Haland','Norway',365146);

select * from work2;


alter table work1
add constraint fk_work foreign key(id) references work1(id);