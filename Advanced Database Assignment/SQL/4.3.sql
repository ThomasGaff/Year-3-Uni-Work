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


insert into RACE
values (1,TIMESTAMP  '2017-03-26 06:00:00', TIMESTAMP  '2017-03-26 06:00:00', TIMESTAMP '2017-03-26 06:00:00', 'Melbourne');
insert into RACE
values (2,TIMESTAMP '2017-04-09 07:00:00', TIMESTAMP '2017-04-09 07:00:00',TIMESTAMP '2017-04-09 07:00:00', 'Shanghai');
insert into RACE
values (3,TIMESTAMP '2017-04-16 16:00:00', TIMESTAMP '2017-04-16 16:00:00',TIMESTAMP '2017-04-16 16:00:00', 'Bahrain');
insert into RACE
values (4,TIMESTAMP '2017-04-30 13:00:00', TIMESTAMP '2017-04-30 13:00:00',TIMESTAMP '2017-04-30 13:00:00', 'Sochi');
insert into RACE
values (5,TIMESTAMP '2017-05-14 13:00:00', TIMESTAMP '2017-05-14 13:00:00',TIMESTAMP '2017-05-14 13:00:00', 'Barcelona');
insert into RACE
values (6,TIMESTAMP '2017-05-28 13:00:00', TIMESTAMP '2017-05-28 13:00:00',TIMESTAMP '2017-05-28 13:00:00', 'Monte Carlo');
insert into RACE
values (7,TIMESTAMP '2017-06-11 19:00:00', TIMESTAMP '2017-06-11 19:00:00',TIMESTAMP '2017-06-11 19:00:00', 'Montreal');
insert into RACE
values (8,TIMESTAMP '2017-06-25 14:00:00', TIMESTAMP '2017-06-25 14:00:00',TIMESTAMP '2017-06-25 14:00:00', 'Baku');
insert into RACE
values (9,TIMESTAMP '2017-07-09 13:00:00', TIMESTAMP '2017-07-09 13:00:00',TIMESTAMP '2017-07-09 13:00:00', 'Spielberg');
insert into RACE
values (10,TIMESTAMP '2017-07-16 13:00:00', TIMESTAMP '2017-07-16 13:00:00',TIMESTAMP '2017-07-16 13:00:00', 'Silverstone');
insert into RACE
values (11,TIMESTAMP '2017-07-30 13:00:00', TIMESTAMP '2017-07-30 13:00:00',TIMESTAMP '2017-07-30 13:00:00', 'Budapest');
insert into RACE
values (12,TIMESTAMP '2017-08-27 13:00:00', TIMESTAMP '2017-08-27 13:00:00',TIMESTAMP '2017-08-27 13:00:00', 'Spa-Francorchamps');
insert into RACE
values (13,TIMESTAMP '2017-09-03 13:00:00', TIMESTAMP '2017-09-03 13:00:00',TIMESTAMP '2017-09-03 13:00:00', 'Monza');
insert into RACE
values (14,TIMESTAMP '2017-09-17 13:00:00', TIMESTAMP '2017-09-17 13:00:00',TIMESTAMP '2017-09-17 13:00:00', 'Singapore');


insert into MANUFACTURER
values (1,'Ferrari', 'Italy', 'Fiorano Circuit');
insert into MANUFACTURER
values (2,'Force India-Mercedes', 'India', 'Buddh International Circuit');
insert into MANUFACTURER
values (3,'Haas-Ferrari', 'United States of America', 'Circuit of the Americas');
insert into MANUFACTURER
values (4,'McLaren-Honda', 'United Kingdom', 'Silverstone');
insert into MANUFACTURER
values (5,'Mercedes', 'Germany', 'Nürburgring');
insert into MANUFACTURER
values (6,'Red Bull Racing-TAG Heuer', 'Austria', 'Spielberg');
insert into MANUFACTURER
values (7,'Renault', 'France', 'Circuit Paul Ricard');
insert into MANUFACTURER
values (8,'Sauber-Ferrari', 'Switzerland', 'Bremgarten Circuit');
insert into MANUFACTURER
values (9,'Toro Rosso', 'Italy', 'Autodromo Nazionale Monza');
insert into MANUFACTURER
values (10,'Williams-Mercedes', 'United Kingdom', 'Silverstone');

insert into TEAM
values (1,' Scuderia Ferrari', 'Italy');
insert into TEAM
values (2,'Sahara Force India F1 Team', 'India');
insert into TEAM
values (3,'Haas F1 Team', 'United States of America');
insert into TEAM
values (4,'McLaren Honda Formula 1 Team', 'United Kingdom');
insert into TEAM
values (5,'Mercedes AMG Petronas Motorsport', 'Germany');
insert into TEAM
values (6,'Red Bull Racing', 'Austria');
insert into TEAM
values (7,'Renault Sport Formula One Team', 'France');
insert into TEAM
values (8,'Sauber F1 Team', 'Switzerland');
insert into TEAM
values (9,'Scuderia Toro Rosso', 'Italy');
insert into TEAM
values (10,'Williams Martini Racing', 'United Kingdom');

insert into DRIVER
values (44, 5,'Hamilton', 'Lewis', 'United Kingdom');
insert into DRIVER
values (5,1,'Vettel', 'Sebastian', 'Germany');
insert into DRIVER
values (77,5,'Bottas', 'Valtteri', 'Finland');
insert into DRIVER
values (7,1,'Räikkönen', 'Kimi', 'Finland');
insert into DRIVER
values (3,6,'Ricciardo', 'Daniel', 'Australia');
insert into DRIVER
values (33,6,'Verstappen', 'Max', 'Netherlands');
insert into DRIVER
values (11,2,'Pérez', 'Sergio', 'Mexico');
insert into DRIVER
values (31,2,'Ocon', 'Esteban', 'France');
insert into DRIVER
values (55,7,'Sainz Jr.', 'Carlos', 'Spain');
insert into DRIVER
values (27,7,'Hülkenberg', 'Nico', 'Germany');
insert into DRIVER
values (19,10,'Massa', 'Felipe', 'Brazil');
insert into DRIVER
values (18,10,'Stroll', 'Lance', 'Canada');
insert into DRIVER
values (8,3,'Grosjean', 'Romain', 'France');
insert into DRIVER
values (20,3,'Magnussen', 'Kevin', 'Denmark');
insert into DRIVER
values (14,4,'Alonso', 'Fernando', 'Spain');
insert into DRIVER
values (2,4,'Vandoorne', 'Lewis', 'Belgium');
insert into DRIVER
values (30,7,'Palmer', 'Jolyon', 'United Kingdom');
insert into DRIVER
values (94,8,'Wehrlein', 'Pascal', 'Germany');
insert into DRIVER
values (26,9,'Kvyat', 'Daniil', 'Russian Federation');
insert into DRIVER
values (9,8,'Ericsson', 'Marcus', 'Sweeden');
insert into DRIVER
values (10,9,'Gasly', 'Pierre', 'France');
insert into DRIVER
values (36,8,'Giovinazzi', 'Antonio', 'Italy');
insert into DRIVER
values (28,9,'Hartley', 'Brendon', 'Australia');

insert into DATE_TIME
values (1,TIMESTAMP '2017-03-26 06:00:00');
insert into DATE_TIME
values (2,TIMESTAMP '2017-04-09 07:00:00');
insert into DATE_TIME
values (3,TIMESTAMP '2017-04-16 16:00:00');
insert into DATE_TIME
values (4,TIMESTAMP '2017-04-30 13:00:00');
insert into DATE_TIME
values (5,TIMESTAMP '2017-05-14 13:00:00');
insert into DATE_TIME
values (6,TIMESTAMP '2017-05-28 13:00:00');
insert into DATE_TIME
values (7,TIMESTAMP '2017-06-11 19:00:00');
insert into DATE_TIME
values (8,TIMESTAMP '2017-06-25 14:00:00');
insert into DATE_TIME
values (9,TIMESTAMP '2017-07-09 13:00:00');
insert into DATE_TIME
values (10,TIMESTAMP '2017-07-16 13:00:00');
insert into DATE_TIME
values (11,TIMESTAMP '2017-07-30 13:00:00');
insert into DATE_TIME
values (12,TIMESTAMP '2017-08-27 13:00:00');
insert into DATE_TIME
values (13,TIMESTAMP '2017-09-03 13:00:00');
insert into DATE_TIME
values (14,TIMESTAMP '2017-09-17 13:00:00');


insert into RESULT
values (    5,    1,    1,    1,    1,    1,    TIMESTAMP '2017-03-26 07:24:11',    25    );
insert into RESULT
values (    77,    1,    5,    5,    1,    3,    TIMESTAMP '2017-03-26 07:24:22',    15    );
insert into RESULT
values (    7,    1,    1,    1,    1,    4,    TIMESTAMP '2017-03-26 07:24:34',    12    );
insert into RESULT
values (    3,    1,    6,    6,    1,    17,    TIMESTAMP '2017-03-26 07:25:11',    0    );
insert into RESULT
values (    33,    1,    6,    6,    1,    5,    TIMESTAMP '2017-03-26 07:24:54',    10    );
insert into RESULT
values (    11,    1,    2,    2,    1,    7,    TIMESTAMP '2017-03-26 07:26:11',    6    );
insert into RESULT
values (    31,    1,    2,    2,    1,    10,    TIMESTAMP '2017-03-26 07:27:11',    1    );
insert into RESULT
values (    55,    1,    7,    7,    1,    8,    TIMESTAMP '2017-03-26 07:28:11',    4    );
insert into RESULT
values (    27,    1,    7,    7,    1,    11,    TIMESTAMP '2017-03-26 07:29:11',    0    );
insert into RESULT
values (    19,    1,    10,    10,    1,    6,    TIMESTAMP '2017-03-26 07:30:11',    8    );
insert into RESULT
values (    18,    1,    10,    10,    1,    16,    TIMESTAMP '2017-03-26 07:31:11',    0    );
insert into RESULT
values (    8,    1,    3,    3,    1,    20,    TIMESTAMP '2017-03-26 07:32:11',    0    );
insert into RESULT
values (    20,    1,    3,    3,    1,    15,    TIMESTAMP '2017-03-26 07:33:11',    0    );
insert into RESULT
values (    14,    1,    4,    4,    1,    14,    TIMESTAMP '2017-03-26 07:34:11',    0    );
insert into RESULT
values (    2,    1,    4,    4,    1,    13,    TIMESTAMP '2017-03-26 07:35:11',    0    );
insert into RESULT
values (    30,    1,    7,    7,    1,    19,    TIMESTAMP '2017-03-26 07:37:11',    0    );
insert into RESULT
values (    94,    1,    8,    8,    1,    21,    TIMESTAMP '2017-03-26 07:38:11',    0    );
insert into RESULT
values (    26,    1,    9,    9,    1,    9,    TIMESTAMP '2017-03-26 07:39:11',    2    );
insert into RESULT
values (    9,    1,    8,    8,    1,    18,    TIMESTAMP '2017-03-26 07:40:11',    0    );
insert into RESULT
values (    10,    1,    9,    9,    1,    22,    TIMESTAMP '2017-03-26 07:41:11',    0    );
insert into RESULT
values (    36,    1,    8,    8,    1,    12,    TIMESTAMP '2017-03-26 07:42:11',    0    );
insert into RESULT
values (    28,    1,    9,    9,    1,    23,    TIMESTAMP '2017-03-26 07:43:11',    0    );
insert into RESULT                            
values (    44,    2,    5,    5,    2,    1,    TIMESTAMP '2017-04-09 08:37:36',    25    );
insert into RESULT
values (    5,    2,    1,    1,    2,    2,    TIMESTAMP '2017-04-09 08:37:38',    18    );
insert into RESULT
values (    77,    2,    5,    5,    2,    3,    TIMESTAMP '2017-04-09 08:37:39',    15    );
insert into RESULT
values (    7,    2,    1,    1,    2,    4,    TIMESTAMP '2017-04-09 08:37:40',    12    );
insert into RESULT
values (    3,    2,    6,    6,    2,    5,    TIMESTAMP '2017-04-09 08:37:41',    10    );
insert into RESULT
values (    33,    2,    6,    6,    2,    6,    TIMESTAMP '2017-04-09 08:37:42',    8    );
insert into RESULT
values (    11,    2,    2,    2,    2,    7,    TIMESTAMP '2017-04-09 08:37:43',    6    );
insert into RESULT
values (    31,    2,    2,    2,    2,    8,    TIMESTAMP '2017-04-09 08:37:44',    4    );
insert into RESULT
values (    55,    2,    7,    7,    2,    9,    TIMESTAMP '2017-04-09 08:37:45',    2    );
insert into RESULT
values (    27,    2,    7,    7,    2,    10,    TIMESTAMP '2017-04-09 08:37:46',    1    );
insert into RESULT
values (    19,    2,    10,    10,    2,    11,    TIMESTAMP '2017-04-09 08:38:36',    0    );
insert into RESULT
values (    18,    2,    10,    10,    2,    12,    TIMESTAMP '2017-04-09 08:39:36',    0    );
insert into RESULT
values (    8,    2,    3,    3,    2,    13,    TIMESTAMP '2017-04-09 08:40:36',    0    );
insert into RESULT
values (    20,    2,    3,    3,    2,    14,    TIMESTAMP '2017-04-09 08:41:36',    0    );
insert into RESULT
values (    14,    2,    4,    4,    2,    15,    TIMESTAMP '2017-04-09 08:42:36',    0    );
insert into RESULT
values (    2,    2,    4,    4,    2,    16,    TIMESTAMP '2017-04-09 08:43:36',    0    );
insert into RESULT
values (    30,    2,    7,    7,    2,    17,    TIMESTAMP '2017-04-09 08:44:36',    0    );
insert into RESULT
values (    94,    2,    8,    8,    2,    18,    TIMESTAMP '2017-04-09 08:45:36',    0    );
insert into RESULT
values (    26,    2,    9,    9,    2,    19,    TIMESTAMP '2017-04-09 08:46:36',    0    );
insert into RESULT
values (    9,    2,    8,8,    2,    20,    TIMESTAMP '2017-04-09 08:47:36',    0    );
insert into RESULT
values (    10,    2,    9,    9,    2,    21,    TIMESTAMP '2017-04-09 08:48:36',    0    );
insert into RESULT
values (    36,    2,    8,    8,    2,    22,    TIMESTAMP '2017-04-09 08:49:36',    0    );
insert into RESULT
values (    28,    2,    9,    9,    2,    23,    TIMESTAMP '2017-04-09 08:50:36',    0    );
insert into RESULT                        
values (    44    ,3    ,5,    5,    3,    10,    TIMESTAMP '2017-04-16 17:34:14',    1    );
insert into RESULT
values (    5,    3    ,1    ,1,    3    ,9,    TIMESTAMP '2017-04-16 17:34:12',    2    );
insert into RESULT
values (    77    ,3,    5,    5,    3,    8,    TIMESTAMP '2017-04-16 17:34:10',    4    );
insert into RESULT
values (    7    ,3,    1,    1,    3,    7,    TIMESTAMP '2017-04-16 17:34:09',    6    );
insert into RESULT
values (    3    ,3,    6,    6,    3,    6,    TIMESTAMP '2017-04-16 17:34:08',    8    );
insert into RESULT
values (    33,    3    ,6,    6    ,3,    5,    TIMESTAMP '2017-04-16 17:34:07',    10    );
insert into RESULT
values (    11,    3    ,2    ,2    ,3    ,4,    TIMESTAMP '2017-04-16 17:34:05',    12    );
insert into RESULT
values (    31,    3    ,2    ,2,    3    ,3,    TIMESTAMP '2017-04-16 17:34:03',    15    );
insert into RESULT
values (    55,    3    ,7    ,7,    3,    2,    TIMESTAMP '2017-04-16 17:34:01',    18    );
insert into RESULT
values (    27,3    ,7,7,    3    ,1,    TIMESTAMP '2017-04-16 17:34:53',    25    );
insert into RESULT
values (    19    ,3,    10,    10,    3,    11    ,TIMESTAMP '2017-04-16 17:36:53',    0    );
insert into RESULT
values (    18,    3,    10,    10,    3,    12    ,TIMESTAMP '2017-04-16 17:37:53',    0    );
insert into RESULT
values (    8    ,3,    3,    3,    3,    13    ,TIMESTAMP '2017-04-16 17:38:53',    0    );
insert into RESULT
values (    20    ,3    ,3,    3,    3,    14    ,TIMESTAMP '2017-04-16 17:39:53',    0    );
insert into RESULT
values (    14,    3,    4    ,4    ,3,    15    ,TIMESTAMP '2017-04-16 17:40:53',    0    );
insert into RESULT
values (    2,    3,    4,    4,    3,    16    ,TIMESTAMP '2017-04-16 17:41:53',    0    );
insert into RESULT
values (    30    ,3,    7,    7,    3,    17    ,TIMESTAMP '2017-04-16 17:42:53',    0    );
insert into RESULT
values (    94    ,3,    8,    8    ,3,    18    ,TIMESTAMP '2017-04-16 17:43:53',    0    );
insert into RESULT
values (    26    ,3,    9    ,9    ,3    ,19    ,TIMESTAMP '2017-04-16 17:44:53',    0    );
insert into RESULT
values (    9,    3,    8,    8,    3    ,20    ,TIMESTAMP '2017-04-16 17:45:53',    0    );
insert into RESULT
values (    10,    3    ,9    ,9    ,3    ,21    ,TIMESTAMP '2017-04-16 17:46:53',    0    );
insert into RESULT
values (    36    ,3    ,8    ,8    ,3    ,22    ,TIMESTAMP '2017-04-16 17:47:53',    0    );
insert into RESULT
values (    28    ,3    ,9    ,9    ,3    ,23    ,TIMESTAMP '2017-04-16 17:48:53',    0    );

insert into RESULT                                    
values (    44    ,4    ,5,    5,4    ,1    ,TIMESTAMP '2017-04-30 14:28:08',    25    );
insert into RESULT
values (    5,    4,    1,    1    ,4,    3    ,TIMESTAMP '2017-04-30 14:28:10',    15    );
insert into RESULT
values (    77,    4    ,5,    5,    4,    5    ,TIMESTAMP '2017-04-30 14:28:12',    10    );
insert into RESULT
values (    7    ,4    ,1    ,1,    4    ,7    ,TIMESTAMP '2017-04-30 14:28:14',    6    );
insert into RESULT
values (    3    ,4,    6,    6    ,4,    9    ,TIMESTAMP '2017-04-30 14:28:16',    2    );
insert into RESULT
values (    33,    4    ,6,    6,    4,    2    ,TIMESTAMP '2017-04-30 14:28:09',    18    );
insert into RESULT
values (    11    ,4,    2,    2,    4,    4    ,TIMESTAMP '2017-04-30 14:28:11',    12    );
insert into RESULT
values (    31,4,    2    ,2,    4,    6    ,TIMESTAMP '2017-04-30 14:28:13',    8    );
insert into RESULT
values (    55,    4,    7,    7,    4,    8    ,TIMESTAMP '2017-04-30 14:28:15',    4    );
insert into RESULT
values (    27    ,4    ,7    ,7,    4,    10    ,TIMESTAMP '2017-04-30 14:28:17',    1    );
insert into RESULT
values (    19,    4,    10,    10,    4,    11    ,TIMESTAMP '2017-04-30 14:29:08',    0    );
insert into RESULT
values (    18,    4    ,10,    10,    4    ,12    ,TIMESTAMP '2017-04-30 14:30:08',    0    );
insert into RESULT
values (    8    ,4    ,3    ,3    ,4    ,13    ,TIMESTAMP '2017-04-30 14:31:08',    0    );
insert into RESULT
values (    20    ,4    ,3    ,3,    4    ,14    ,TIMESTAMP '2017-04-30 14:32:08',    0    );
insert into RESULT
values (    14,    4    ,4    ,4,    4,    15    ,TIMESTAMP '2017-04-30 14:33:08',    0    );
insert into RESULT
values (    2    ,4    ,4    ,4    ,4,    16    ,TIMESTAMP '2017-04-30 14:34:08',    0    );
insert into RESULT
values (    30    ,4    ,7,    7    ,4    ,17    ,TIMESTAMP '2017-04-30 14:35:08',    0    );
insert into RESULT
values (    94    ,4    ,8    ,8    ,4    ,18    ,TIMESTAMP '2017-04-30 14:36:08',    0    );
insert into RESULT
values (    26    ,4,9    ,9,    4    ,19    ,TIMESTAMP '2017-04-30 14:37:08',    0    );
insert into RESULT
values (    9    ,4    ,8    ,8    ,4,20    ,TIMESTAMP '2017-04-30 14:38:08',    0    );
insert into RESULT
values (    10    ,4,    9,9,    4,    21    ,TIMESTAMP '2017-04-30 14:39:08',    0    );
insert into RESULT
values (    36    ,4,    8    ,8,    4,    22    ,TIMESTAMP '2017-04-30 14:40:08',    0    );
insert into RESULT
values (    28,    4,    9    ,9,    4,    23    ,TIMESTAMP '2017-04-30 14:41:08',    0    );

insert into RESULT                                    
values (    44,    5,    5,    5,    5,    2    ,TIMESTAMP '2017-05-14 14:35:57',    18    );
insert into RESULT
values (    5,    5,    1    ,1,    5,    4    ,TIMESTAMP '2017-05-14 14:35:59',    12    );
insert into RESULT
values (    77,    5,    5,    5,    5,    6    ,TIMESTAMP '2017-05-14 14:36:10',    8    );
insert into RESULT
values (    7    ,5,    1    ,1    ,5,    8    ,TIMESTAMP '2017-05-14 14:36:30',    4    );
insert into RESULT
values (    3,    5,    6,    6    ,5,    10    ,TIMESTAMP '2017-05-14 14:36:50',    1    );
insert into RESULT
values (    33,    5,    6,    6    ,5,    1    ,TIMESTAMP '2017-05-14 14:35:56',    25    );
insert into RESULT
values (    11,    5,    2,    2,    5,    3    ,TIMESTAMP '2017-05-14 14:35:58',    15    );
insert into RESULT
values (    31    ,5,    2    ,2,    5,    5    ,TIMESTAMP '2017-05-14 14:36:00',    10    );
insert into RESULT
values (    55,    5,    7    ,7    ,5,    7    ,TIMESTAMP '2017-05-14 14:36:20',    6    );
insert into RESULT
values (    27,    5,    7    ,7    ,5,    9    ,TIMESTAMP '2017-05-14 14:36:40',    2    );
insert into RESULT
values (    19,    5,    10    ,10,    5,    11    ,TIMESTAMP '2017-05-14 14:36:56',    0    );
insert into RESULT
values (    18    ,5,    10,    10    ,5,    12    ,TIMESTAMP '2017-05-14 14:37:56',    0    );
insert into RESULT
values (    8    ,5,    3,    3    ,5,    13    ,TIMESTAMP '2017-05-14 14:38:56',    0    );
insert into RESULT
values (    20    ,5,    3,    3    ,5,    14    ,TIMESTAMP '2017-05-14 14:39:56',    0    );
insert into RESULT
values (    14,    5,    4,    4    ,5,    15    ,TIMESTAMP '2017-05-14 14:40:56',    0    );
insert into RESULT
values (    2    ,5,    4,    4    ,5,    16    ,TIMESTAMP '2017-05-14 14:41:56',    0    );
insert into RESULT
values (    30,    5,    7    ,7    ,5,    17    ,TIMESTAMP '2017-05-14 14:42:56',    0    );
insert into RESULT
values (    94,    5,    8,    8,    5,    18    ,TIMESTAMP '2017-05-14 14:43:56',    0    );
insert into RESULT
values (    26,    5,    9,    9    ,5,    19    ,TIMESTAMP '2017-05-14 14:44:56',    0    );
insert into RESULT
values (    9    ,5,    8,    8    ,5,    20    ,TIMESTAMP '2017-05-14 14:45:56',    0    );
insert into RESULT
values (    10    ,5,    9    ,9,    5,    21    ,TIMESTAMP '2017-05-14 14:46:56',    0    );
insert into RESULT
values (    36    ,5,    8    ,8,    5,    22    ,TIMESTAMP '2017-05-14 14:47:56',    0    );
insert into RESULT
values (    28    ,5,    9    ,9    ,5,    23    ,TIMESTAMP '2017-05-14 14:48:56',    0    );
insert into RESULT                                
values (    44    ,6    ,5,    5,    6,    2    ,TIMESTAMP '2017-05-28 14:24:15',    18    );
insert into RESULT
values (    5,    6    ,1,    1,    6    ,1    ,TIMESTAMP '2017-05-28 14:24:11',    25    );
insert into RESULT
values (    77    ,6    ,5,    5,    6,    3    ,TIMESTAMP '2017-05-28 14:24:22',    15    );
insert into RESULT
values (    7    ,6    ,1,    1    ,6,    4    ,TIMESTAMP '2017-05-28 14:24:34',    12    );
insert into RESULT
values (    3    ,6    ,6,    6    ,6,    17    ,TIMESTAMP '2017-05-28 14:25:11',    0    );
insert into RESULT
values (    33    ,6,    6,    6,    6,5    ,TIMESTAMP '2017-05-28 14:24:54',    10    );
insert into RESULT
values (    11    ,6    ,2,    2,    6,    7    ,TIMESTAMP '2017-05-28 14:28:11',    6    );
insert into RESULT
values (    31,    6,    2,    2    ,6    ,10    ,TIMESTAMP '2017-05-28 14:27:11',    1    );
insert into RESULT
values (    55,    6    ,7,    7,    6,    8    ,TIMESTAMP '2017-05-28 14:28:11',    4    );
insert into RESULT
values (    27    ,6    ,7    ,7    ,6    ,11    ,TIMESTAMP '2017-05-28 14:29:11',    0    );
insert into RESULT
values (    19,    6,    10    ,10,    6    ,6    ,TIMESTAMP '2017-05-28 14:30:11',    8    );
insert into RESULT
values (    18    ,6    ,10,    10    ,6    ,16    ,TIMESTAMP '2017-05-28 14:31:11',    0    );
insert into RESULT
values (    8    ,6,    3,    3    ,6,    20    ,TIMESTAMP '2017-05-28 14:32:11',    0    );
insert into RESULT
values (    20    ,6    ,3    ,3,    6,    15    ,TIMESTAMP '2017-05-28 14:33:11',    0    );
insert into RESULT
values (    14    ,6    ,4,    4,    6,    14    ,TIMESTAMP '2017-05-28 14:34:11',    0    );
insert into RESULT
values (    2    ,6    ,4,    4,    6,    13    ,TIMESTAMP '2017-05-28 14:35:11',    0    );
insert into RESULT
values (    30    ,6    ,7,    7    ,6,    19    ,TIMESTAMP '2017-05-28 14:37:11',    0    );
insert into RESULT
values (    94    ,6    ,8    ,8,6,    21    ,TIMESTAMP '2017-05-28 14:38:11',    0    );
insert into RESULT
values (    26,    6    ,9,    9    ,6    ,9    ,TIMESTAMP '2017-05-28 14:39:11',    2    );
insert into RESULT
values (    9    ,6,    8    ,8,    6    ,18    ,TIMESTAMP '2017-05-28 14:40:11',    0    );
insert into RESULT
values (    10,6    ,9    ,9,    6,    22    ,TIMESTAMP '2017-05-28 14:41:11',    0    );
insert into RESULT
values (    36,    6,    8,    8,    6,    12    ,TIMESTAMP '2017-05-28 14:42:11',    0    );
insert into RESULT
values (    28,    6,    9,    9,    6    ,23    ,TIMESTAMP '2017-05-28 14:43:11',    0    );

insert into RESULT                                    
values (    44,    7    ,5,    5,    7,    1    ,TIMESTAMP '2017-06-11 20:37:36',    25    );
insert into RESULT
values (    5,    7,    1,    1,    7    ,2    ,TIMESTAMP '2017-06-11 20:37:38',    18    );
insert into RESULT
values (    77,    7    ,5,    5,    7,    3    ,TIMESTAMP '2017-06-11 20:37:39',    15    );
insert into RESULT
values (    7    ,7,    1,    1,    7,    4    ,TIMESTAMP '2017-06-11 20:37:40',    12    );
insert into RESULT
values (    3,    7    ,6,    6,    7,    5    ,TIMESTAMP '2017-06-11 20:37:41',    10    );
insert into RESULT
values (    33    ,7,    6    ,6    ,7,6    ,TIMESTAMP '2017-06-11 20:37:42',    8    );
insert into RESULT
values (    11,    7,    2,    2,    7,    7    ,TIMESTAMP '2017-06-11 20:37:43',    6    );
insert into RESULT
values (    31,    7    ,2,    2,    7,    8    ,TIMESTAMP '2017-06-11 20:37:44',    4    );
insert into RESULT
values (    55,    7,    7,    7,    7,    9    ,TIMESTAMP '2017-06-11 20:37:45',    2    );
insert into RESULT
values (    27,    7,    7,    7,    7,    10    ,TIMESTAMP '2017-06-11 20:37:46',    1    );
insert into RESULT
values (    19    ,7    ,10,    10,    7    ,11    ,TIMESTAMP '2017-06-11 20:38:36',    0    );
insert into RESULT
values (    18,    7    ,10    ,10    ,7,    12    ,TIMESTAMP '2017-06-11 20:39:36',    0    );
insert into RESULT
values (    8    ,7,    3    ,3,    7    ,13    ,TIMESTAMP '2017-06-11 20:40:36',    0    );
insert into RESULT
values (    20,    7    ,3    ,3,    7    ,14    ,TIMESTAMP '2017-06-11 20:41:36',    0    );
insert into RESULT
values (    14    ,7,    4    ,4    ,7    ,15    ,TIMESTAMP '2017-06-11 20:42:36',    0    );
insert into RESULT
values (    2    ,7    ,4    ,4,    7    ,16    ,TIMESTAMP '2017-06-11 20:43:36',    0    );
insert into RESULT
values (    30,    7    ,7    ,7    ,7,17    ,TIMESTAMP '2017-06-11 20:44:36',    0    );
insert into RESULT
values (    94    ,7,    8    ,8,    7,    18    ,TIMESTAMP '2017-06-11 20:45:36',    0    );
insert into RESULT
values (    26    ,7,    9    ,9    ,7,    19    ,TIMESTAMP '2017-06-11 20:46:36',    0    );
insert into RESULT
values (    9,    7    ,8,    8,    7,    20    ,TIMESTAMP '2017-06-11 20:47:36',    0    );
insert into RESULT
values (    10,    7    ,9    ,9,    7    ,21    ,TIMESTAMP '2017-06-11 20:48:36',    0    );
insert into RESULT
values (    36    ,7    ,8,    8,    7,    22    ,TIMESTAMP '2017-06-11 20:49:36',    0    );
insert into RESULT
values (    28,    7,    9,    9,    7,    23    ,TIMESTAMP '2017-06-11 20:50:36',    0    );

insert into RESULT                                    
values (    44,    8    ,5,    5,    8,    10    ,TIMESTAMP '2017-06-25 15:34:14',    1    );
insert into RESULT
values (    5,    8    ,1,    1,    8,    9    ,TIMESTAMP '2017-06-25 15:34:12',    2    );
insert into RESULT
values (    77,    8    ,5,    5,    8,    8    ,TIMESTAMP '2017-06-25 15:34:10',    4    );
insert into RESULT
values (    7    ,8,    1,    1,8,    7    ,TIMESTAMP '2017-06-25 15:34:09',    6    );
insert into RESULT
values (    3,    8    ,6,    6,    8,    6    ,TIMESTAMP '2017-06-25 15:34:08',    8    );
insert into RESULT
values (    33,    8,    6,    6    ,8,    5    ,TIMESTAMP '2017-06-25 15:34:07',    10    );
insert into RESULT
values (    11    ,8    ,2,    2    ,8,    4    ,TIMESTAMP '2017-06-25 15:34:05',    12    );
insert into RESULT
values (    31,    8    ,2    ,2    ,8,    3    ,TIMESTAMP '2017-06-25 15:34:03',    15    );
insert into RESULT
values (    55    ,8    ,7,    7,    8,    2    ,TIMESTAMP '2017-06-25 15:34:01',    18    );
insert into RESULT
values (    27,    8    ,7,    7    ,8,1    ,TIMESTAMP '2017-06-25 15:34:53',    25    );
insert into RESULT
values (    19    ,8    ,10    ,10,    8,    11    ,TIMESTAMP '2017-06-25 15:36:53',    0    );
insert into RESULT
values (    18    ,8    ,10,    10,    8,    12    ,TIMESTAMP '2017-06-25 15:37:53',    0    );
insert into RESULT
values (    8,    8    ,3    ,3    ,8    ,13    ,TIMESTAMP '2017-06-25 15:38:53',    0    );
insert into RESULT
values (    20    ,8    ,3,    3    ,8    ,14    ,TIMESTAMP '2017-06-25 15:39:53',    0    );
insert into RESULT
values (    14    ,8    ,4    ,4    ,8,    15    ,TIMESTAMP '2017-06-25 15:40:53',    0    );
insert into RESULT
values (    2    ,8    ,4    ,4,    8    ,16    ,TIMESTAMP '2017-06-25 15:41:53',    0    );
insert into RESULT
values (    30    ,8    ,7    ,7,    8,    17    ,TIMESTAMP '2017-06-25 15:42:53',    0    );
insert into RESULT
values (    94    ,8,    8,    8,    8,    18    ,TIMESTAMP '2017-06-25 15:43:53',    0    );
insert into RESULT
values (    26,    8    ,9,    9,    8,    19    ,TIMESTAMP '2017-06-25 15:44:53',    0    );
insert into RESULT
values (    9    ,8    ,8    ,8,    8,    20    ,TIMESTAMP '2017-06-25 15:45:53',    0    );
insert into RESULT
values (    10,8    ,9    ,9,    8,    21    ,TIMESTAMP '2017-06-25 15:46:53',    0    );
insert into RESULT
values (    36    ,8    ,8,    8,    8,    22    ,TIMESTAMP '2017-06-25 15:47:53',    0    );
insert into RESULT
values (    28    ,8    ,9    ,9    ,8    ,23    ,TIMESTAMP '2017-06-25 15:48:53',    0    );

insert into RESULT                                    
values (    44,    9,    5    ,5,    9,    1    ,TIMESTAMP '2017-07-09 14:28:08',    25    );
insert into RESULT
values (    5    ,9    ,1    ,1    ,9,    3    ,TIMESTAMP '2017-07-09 14:28:10',    15    );
insert into RESULT
values (    77,    9,    5    ,5,    9,    5    ,TIMESTAMP '2017-07-09 14:28:12',    10    );
insert into RESULT
values (    7    ,9,    1,    1,    9,    7    ,TIMESTAMP '2017-07-09 14:28:14',    6    );
insert into RESULT
values (    3,    9,    6,    6,    9,    9    ,TIMESTAMP '2017-07-09 14:28:16',    2    );
insert into RESULT
values (    33,    9    ,6,    6    ,9,    2    ,TIMESTAMP '2017-07-09 14:28:09',    18    );
insert into RESULT
values (    11,    9,    2,    2    ,9,    4    ,TIMESTAMP '2017-07-09 14:28:11',    12    );
insert into RESULT
values (    31    ,9,    2,    2,    9    ,6    ,TIMESTAMP '2017-07-09 14:28:13',    8    );
insert into RESULT
values (    55    ,9,    7    ,7,    9    ,8    ,TIMESTAMP '2017-07-09 14:28:15',    4    );
insert into RESULT
values (    27,    9,    7,    7    ,9    ,10    ,TIMESTAMP '2017-07-09 14:28:17',    1    );
insert into RESULT
values (    19,    9,    10,    10,    9,    11    ,TIMESTAMP '2017-07-09 14:29:08',    0    );
insert into RESULT
values (    18    ,9    ,10,    10,    9,    12    ,TIMESTAMP '2017-07-09 14:09:08',    0    );
insert into RESULT
values (    8,    9    ,3,    3    ,9,    13    ,TIMESTAMP '2017-07-09 14:31:08',    0    );
insert into RESULT
values (    20,    9    ,3    ,3    ,9    ,14    ,TIMESTAMP '2017-07-09 14:32:08',    0    );
insert into RESULT
values (    14,    9,    4,    4    ,9,    15    ,TIMESTAMP '2017-07-09 14:33:08',    0    );
insert into RESULT
values (    2    ,9    ,4    ,4    ,9    ,16    ,TIMESTAMP '2017-07-09 14:34:08',    0    );
insert into RESULT
values (    30,    9    ,7,7    ,9    ,17    ,TIMESTAMP '2017-07-09 14:35:08',    0    );
insert into RESULT
values (    94,    9,    8,    8,    9    ,18    ,TIMESTAMP '2017-07-09 14:36:08',    0    );
insert into RESULT
values (    26,    9    ,9,    9    ,9,    19    ,TIMESTAMP '2017-07-09 14:37:08',    0    );
insert into RESULT
values (    9    ,9    ,8    ,8,    9,    20    ,TIMESTAMP '2017-07-09 14:38:08',    0    );
insert into RESULT
values (    10    ,9,    9,    9,    9,    21    ,TIMESTAMP '2017-07-09 14:39:08',    0    );
insert into RESULT
values (    36    ,9    ,8,    8    ,9,    22    ,TIMESTAMP '2017-07-09 14:40:08',    0    );
insert into RESULT
values (    28    ,9,    9,    9,    9,    23    ,TIMESTAMP '2017-07-09 14:41:08',    0    );

insert into RESULT                                
values (    44,    10    ,5,    5    ,10    ,2    ,TIMESTAMP '2017-07-16 16:35:57',    18    );
insert into RESULT
values (    5    ,10    ,1    ,1    ,10    ,4    ,TIMESTAMP '2017-07-16 16:35:59',    12    );
insert into RESULT
values (    77,    10,    5    ,5    ,10,    6    ,TIMESTAMP '2017-07-16 16:36:10',    8    );
insert into RESULT
values (    7    ,10,    1,    1,    10,    8    ,TIMESTAMP '2017-07-16 16:36:30',    4    );
insert into RESULT
values (    3    ,10,    6    ,6,    10,    10    ,TIMESTAMP '2017-07-16 16:36:50',    1    );
insert into RESULT
values (    33,    10,    6    ,6    ,10,    1    ,TIMESTAMP '2017-07-16 16:35:56',    25    );
insert into RESULT
values (    11,    10,    2,    2    ,10,    3    ,TIMESTAMP '2017-07-16 16:35:58',    15    );
insert into RESULT
values (    31    ,10,    2    ,2    ,10,    5    ,TIMESTAMP '2017-07-16 16:36:00',    10    );
insert into RESULT
values (    55,    10,    7,    7,    10,    7    ,TIMESTAMP '2017-07-16 16:36:20',    6    );
insert into RESULT
values (    27    ,10,    7,    7    ,10    ,9    ,TIMESTAMP '2017-07-16 16:36:40',    2    );
insert into RESULT
values (    19    ,10    ,10    ,10,    10,    11    ,TIMESTAMP '2017-07-16 16:36:56',    0    );
insert into RESULT
values (    18    ,10,    10    ,10,10,    12    ,TIMESTAMP '2017-07-16 16:37:56',    0    );
insert into RESULT
values (    8    ,10    ,3,    3    ,10    ,13    ,TIMESTAMP '2017-07-16 16:38:56',    0    );
insert into RESULT
values (    20    ,10    ,3    ,3    ,10,    14    ,TIMESTAMP '2017-07-16 16:39:56',    0    );
insert into RESULT
values (    14    ,10,    4    ,4    ,10    ,15    ,TIMESTAMP '2017-07-16 16:40:56',    0    );
insert into RESULT
values (    2    ,10,    4,    4,    10    ,16    ,TIMESTAMP '2017-07-16 16:41:56',    0    );
insert into RESULT
values (    30,    10    ,7    ,7    ,10    ,17    ,TIMESTAMP '2017-07-16 16:42:56',    0    );
insert into RESULT
values (    94    ,10,    8,    8,    10    ,18    ,TIMESTAMP '2017-07-16 16:43:56',    0    );
insert into RESULT
values (    26,    10    ,9,    9    ,10,    19    ,TIMESTAMP '2017-07-16 16:44:56',    0    );
insert into RESULT
values (    9    ,10,    8    ,8    ,10,    20    ,TIMESTAMP '2017-07-16 16:45:56',    0    );
insert into RESULT
values (    10    ,10    ,9,    9    ,10    ,21    ,TIMESTAMP '2017-07-16 16:46:56',    0    );
insert into RESULT
values (    36    ,10    ,8,    8    ,10    ,22    ,TIMESTAMP '2017-07-16 16:47:56',    0    );
insert into RESULT
values (    28    ,10,    9    ,9,    10    ,23    ,TIMESTAMP '2017-07-16 16:48:56',    0    );

insert into RESULT                                    
values (    44    ,11    ,5    ,5    ,11,    2    ,TIMESTAMP '2017-07-30 14:24:15',    18    );
insert into RESULT
values (    5    ,11,    1,    1    ,11    ,1    ,TIMESTAMP '2017-07-30 14:24:11',    25    );
insert into RESULT
values (    77    ,11,    5    ,5    ,11,    3    ,TIMESTAMP '2017-07-30 14:24:22',    15    );
insert into RESULT
values (    7    ,11,    1,    1    ,11,    4    ,TIMESTAMP '2017-07-30 14:24:34',    12    );
insert into RESULT
values (    3,    11    ,6,    6    ,11    ,17    ,TIMESTAMP '2017-07-30 14:25:11',    0    );
insert into RESULT
values (    33,    11,6    ,6,11,    5    ,TIMESTAMP '2017-07-30 14:24:54',    10    );
insert into RESULT
values (    11,    11,    2,    2,    11,    7    ,TIMESTAMP '2017-07-30 14:30:11',    6    );
insert into RESULT
values (    31    ,11    ,2    ,2,    11    ,10    ,TIMESTAMP '2017-07-30 14:27:11',    1    );
insert into RESULT
values (    55    ,11,    7,    7    ,11    ,8    ,TIMESTAMP '2017-07-30 14:28:11',    4    );
insert into RESULT
values (    27    ,11    ,7,    7,    11,    11    ,TIMESTAMP '2017-07-30 14:29:11',    0    );
insert into RESULT
values (    19    ,11    ,10,    10    ,11    ,6    ,TIMESTAMP '2017-07-30 14:30:11',    8    );
insert into RESULT
values (    18,    11,    10,    10,    11,    16    ,TIMESTAMP '2017-07-30 14:31:11',    0    );
insert into RESULT
values (    8,    11,    3,    3,    11,    20    ,TIMESTAMP '2017-07-30 14:32:11',    0    );
insert into RESULT
values (    20    ,11,    3    ,3    ,11,    15    ,TIMESTAMP '2017-07-30 14:33:11',    0    );
insert into RESULT
values (    14,    11,    4,    4    ,11    ,14    ,TIMESTAMP '2017-07-30 14:34:11',    0    );
insert into RESULT
values (    2    ,11,    4    ,4    ,11    ,13    ,TIMESTAMP '2017-07-30 14:35:11',    0    );
insert into RESULT
values (    30    ,11,    7,    7    ,11    ,19    ,TIMESTAMP '2017-07-30 14:37:11',    0    );
insert into RESULT
values (    94    ,11    ,8,8    ,11,21    ,TIMESTAMP '2017-07-30 14:38:11',    0    );
insert into RESULT
values (    26    ,11    ,9    ,9    ,11    ,9    ,TIMESTAMP '2017-07-30 14:39:11',    2    );
insert into RESULT
values (    9    ,11,    8    ,8    ,11,    18    ,TIMESTAMP '2017-07-30 14:40:11',    0    );
insert into RESULT
values (    10    ,11,    9    ,9    ,11    ,22    ,TIMESTAMP '2017-07-30 14:41:11',    0    );
insert into RESULT
values (    36,11,    8    ,8,    11    ,12    ,TIMESTAMP '2017-07-30 14:42:11',    0    );
insert into RESULT
values (    28,    11    ,9    ,9    ,11    ,23    ,TIMESTAMP '2017-07-30 14:43:11',    0    );

insert into RESULT                                    
values (    44    ,12    ,5    ,5    ,12,1    ,TIMESTAMP '2017-08-27 14:37:36',    25    );
insert into RESULT
values (    5    ,12,    1,    1,    12,    2    ,TIMESTAMP '2017-08-27 14:37:38',    18    );
insert into RESULT
values (    77    ,12    ,5,    5,    12,    3    ,TIMESTAMP '2017-08-27 14:37:39',    15    );
insert into RESULT
values (    7    ,12    ,1    ,1    ,12,    4    ,TIMESTAMP '2017-08-27 14:37:40',    12    );
insert into RESULT
values (    3,    12,6    ,6,    12,    5    ,TIMESTAMP '2017-08-27 14:37:41',    10    );
insert into RESULT
values (    33    ,12,    6,    6,12,    6    ,TIMESTAMP '2017-08-27 14:37:42',    8    );
insert into RESULT
values (    11    ,12    ,2,    2,    12,    7    ,TIMESTAMP '2017-08-27 14:37:43',    6    );
insert into RESULT
values (    31,    12,    2,    2    ,12,    8    ,TIMESTAMP '2017-08-27 14:37:44',    4    );
insert into RESULT
values (    55    ,12,    7    ,7,    12,    9    ,TIMESTAMP '2017-08-27 14:37:45',    2    );
insert into RESULT
values (    27,12    ,7,    7,    12,    10    ,TIMESTAMP '2017-08-27 14:37:46',    1    );
insert into RESULT
values (    19,    12    ,10    ,10,    12,    11    ,TIMESTAMP '2017-08-27 14:38:36',    0    );
insert into RESULT
values (    18    ,12    ,10,    10,    12    ,12    ,TIMESTAMP '2017-08-27 14:39:36',    0    );
insert into RESULT
values (    8    ,12    ,3    ,3    ,12    ,13    ,TIMESTAMP '2017-08-27 14:40:36',    0    );
insert into RESULT
values (    20,    12    ,3    ,3,    12    ,14    ,TIMESTAMP '2017-08-27 14:41:36',    0    );
insert into RESULT
values (    14,    12    ,4,    4    ,12    ,15    ,TIMESTAMP '2017-08-27 14:42:36',    0    );
insert into RESULT
values (    2,    12,    4    ,4    ,12    ,16    ,TIMESTAMP '2017-08-27 14:43:36',    0    );
insert into RESULT
values (    30    ,12,    7    ,7,    12    ,17    ,TIMESTAMP '2017-08-27 14:44:36',    0    );
insert into RESULT
values (    94    ,12    ,8    ,8,    12    ,18    ,TIMESTAMP '2017-08-27 14:45:36',    0    );
insert into RESULT
values (    26    ,12,    9,    9    ,12    ,19    ,TIMESTAMP '2017-08-27 14:46:36',    0    );
insert into RESULT
values (    9    ,12,    8    ,8    ,12    ,20    ,TIMESTAMP '2017-08-27 14:47:36',    0    );
insert into RESULT
values (    10,    12    ,9,    9,    12    ,21    ,TIMESTAMP '2017-08-27 14:48:36',    0    );
insert into RESULT
values (    36    ,12,8    ,8    ,12,    22    ,TIMESTAMP '2017-08-27 14:49:36',    0    );
insert into RESULT
values (    28,    12,9    ,9,12    ,23    ,TIMESTAMP '2017-08-27 14:50:36',    0    );

insert into RESULT                                    
values (    44,    13,    5    ,5,    13    ,10    ,TIMESTAMP '2017-09-03 14:34:14',    1    );
insert into RESULT
values (    5    ,13,    1,    1    ,13,    9    ,TIMESTAMP '2017-09-03 14:34:12',    2    );
insert into RESULT
values (    77    ,13    ,5    ,5    ,13,    8    ,TIMESTAMP '2017-09-03 14:34:10',    4    );
insert into RESULT
values (    7    ,13    ,1    ,1    ,13    ,7    ,TIMESTAMP '2017-09-03 14:34:09',    6    );
insert into RESULT
values (    3    ,13    ,6    ,6    ,13    ,6    ,TIMESTAMP '2017-09-03 14:34:08',    8    );
insert into RESULT
values (    33,    13,    6,    6    ,13,    5    ,TIMESTAMP '2017-09-03 14:34:07',    10    );
insert into RESULT
values (    11    ,13    ,2    ,2    ,13    ,4    ,TIMESTAMP '2017-09-03 14:34:05',    12    );
insert into RESULT
values (    31    ,13    ,2    ,2    ,13    ,3    ,TIMESTAMP '2017-09-03 14:34:03',    15    );
insert into RESULT
values (    55    ,13    ,7    ,7    ,13,    2    ,TIMESTAMP '2017-09-03 14:34:01',    18    );
insert into RESULT
values (    27    ,13,    7    ,7    ,13    ,1    ,TIMESTAMP '2017-09-03 14:34:53',    25    );
insert into RESULT
values (    19    ,13,    10,    10,    13,    11    ,TIMESTAMP '2017-09-03 14:36:53',    0    );
insert into RESULT
values (    18,    13    ,10    ,10    ,13,    12    ,TIMESTAMP '2017-09-03 14:37:53',    0    );
insert into RESULT
values (    8    ,13    ,3    ,3    ,13    ,13    ,TIMESTAMP '2017-09-03 14:38:53',    0    );
insert into RESULT
values (    20    ,13    ,3    ,3    ,13    ,14    ,TIMESTAMP '2017-09-03 14:39:53',    0    );
insert into RESULT
values (    14    ,13,    4    ,4    ,13    ,15    ,TIMESTAMP '2017-09-03 14:40:53',    0    );
insert into RESULT
values (    2,    13,    4,    4    ,13    ,16    ,TIMESTAMP '2017-09-03 14:41:53',    0    );
insert into RESULT
values (    30    ,13    ,7    ,7,    13    ,17    ,TIMESTAMP '2017-09-03 14:42:53',    0    );
insert into RESULT
values (    94,    13,    8,    8    ,13    ,18    ,TIMESTAMP '2017-09-03 14:43:53',    0    );
insert into RESULT
values (    26,    13,    9,    9,    13    ,19    ,TIMESTAMP '2017-09-03 14:44:53',    0    );
insert into RESULT
values (    9    ,13,    8,    8    ,13,    20    ,TIMESTAMP '2017-09-03 14:45:53',    0    );
insert into RESULT
values (    10,    13,    9    ,9,    13    ,21    ,TIMESTAMP '2017-09-03 14:46:53',    0    );
insert into RESULT
values (    36    ,13    ,8,    8,    13,    22    ,TIMESTAMP '2017-09-03 14:47:53',    0    );
insert into RESULT
values (    28,    13    ,9,    9    ,13    ,23    ,TIMESTAMP '2017-09-03 14:48:53',    0    );

