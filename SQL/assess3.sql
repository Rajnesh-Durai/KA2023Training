create table BUS(
	RouteNo int primary key,
	Sources nvarchar(15),
	Destination nvarchar(15)
);

create table PASSENGER(
	PId int primary key,
	Pname nvarchar(15),
	Yob int,
	Gender nvarchar(10)
);

create table BOOK_TICKET(
	PId int ,
	Routeno int,
	Journey_Date date,
	SeatNo int primary key
);

insert into BUS values (1,'Chennai','Bangalore')
insert into BUS values (6,'Kolkata','Bangalore')
insert into BUS values (9,'Mumbai','Chennai')
insert into BUS values (11,'Delhi','Mumbai')
insert into BUS values (99,'Trivandrum','Kochin')

insert into PASSENGER values(1,'Jordan',1998,'male')
insert into PASSENGER values(2,'Emma',1992,'female')
insert into PASSENGER values(3,'Smith',2003,'male')
insert into PASSENGER values(4,'Stella',1974,'female')
insert into PASSENGER values(5,'Santner',1982,'male')

insert into BOOK_TICKET values(1,1,'2022-11-06',1)
insert into BOOK_TICKET values(2,6,'2022-10-16',2)
insert into BOOK_TICKET values(3,9,'2022-12-28',3)
insert into BOOK_TICKET values(4,11,'2022-05-16',4)
insert into BOOK_TICKET values(5,99,'2022-06-07',5)

alter table Book_Ticket add constraint FK_Pid foreign key (PId) references passenger(PId)
alter table Book_Ticket add constraint FK_Route foreign key (Routeno) references Bus(Routeno)

select * from bus
select * from PASSENGER
select * from BOOK_TICKET

/*------------------------------------------------------*/

select sources, destination
from bus
where routeno=99

select t.PId
from BOOK_TICKET t inner join bus b
on t.Routeno=b.RouteNo
where Sources='Mumbai' and Destination='Chennai'

select gender, count(gender) "Person count"
from PASSENGER
group by Gender
order by Gender

select b.RouteNo,b.Sources, b.Destination
from bus b inner join BOOK_TICKET bt
on b.RouteNo=bt.Routeno
where bt.Journey_Date='2022-06-07'

exec dbo.udf_tickets

SELECT * FROM udf_busticket()