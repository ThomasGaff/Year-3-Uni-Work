drop table RESULT;
drop table DATE_TIME;
drop table DRIVER;
drop table TEAM;
drop table MANUFACTURER;
drop table RACE;

create table RACE
(race_number number(3) not null primary key,
day timestamp not null,
month timestamp not null,
year timestamp not null,
track varchar2(30)not null);

create table MANUFACTURER
(manufacturer_no number(3) not null primary key,
manufacturer_name varchar2(30) not null,
home_country varchar2(30) not null,
test_track varchar2(30) not null);

create table TEAM
(team_no number(3) not null primary key,
team_name varchar2(50) not null,
home_country varchar2(30) not null);

create table DRIVER
(driver_id number(3) not null primary key,
team_no number(3) not null references TEAM (team_no),
lastname varchar2(30) not null,
firstname varchar2(30) not null,
country varchar2(30) not null);

create table DATE_TIME
(time_id number(3) not null primary key,
datetimestamp timestamp not null);

create table RESULT
(driver_id number(3) not null references DRIVER(driver_id),
time_id number(3) not null references DATE_TIME(time_id),
team_no number(3) not null references TEAM(team_no),
manufacturer_no number(3) not null references MANUFACTURER(manufacturer_no),
race_number number(3) not null references RACE(race_number),
finish_position number(2),
finish_time timestamp,
points number(4), 
CONSTRAINT PK_RESULT PRIMARY KEY (driver_id, time_id, team_no, manufacturer_no, race_number));



