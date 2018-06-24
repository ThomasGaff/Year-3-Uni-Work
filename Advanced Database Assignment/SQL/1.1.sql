drop table deposit;
drop table acct_holding;
drop table customer;
drop table account;
drop table store;

create table store
(store_location varchar2(30) not null primary key,
store_region varchar2(30) not null,
assets number(10,2) not null);

create table account
(account_no varchar2(10) not null primary key,
store_location varchar2(30) not null references store(store_location),
balance number(10,2) not null);

create table customer
(customer_name varchar2(30) not null primary key,
cust_street varchar2(30) not null,
cust_city varchar2(30) not null);

create table acct_holding
(customer_name varchar2(30) not null references customer(customer_name),
account_no varchar2(25) not null references account (account_no),
CONSTRAINT PK_acct_holding PRIMARY KEY (customer_name, account_no));

create table deposit
(deposit_id number(10) not null primary key,
account_no varchar2(10) not null references account(account_no),
store varchar2(30) not null references store (store_location),
deposit number (10,2) not null,
customer varchar2(30) not null references customer (customer_name));

insert into store
values ('Durham','Durham', 7100000);
insert into store
values ('Jesmond','Newcastle', 9000000);
insert into store
values ('St. Peter''s','Sunderland', 1700000);
insert into store
values ('Seaham','Durham', 300000);
insert into store
values ('Scotswood','Newcastle', 2100000);
    
insert into account
values ('C-101','Jesmond', 10000);
insert into account
values ('C-102','Scotswood', 8000);
insert into account
values ('C-201','Durham', 18000);
insert into account
values ('C-305','Seaham', 4000);
insert into account
values ('C-222','Seaham', 16000);

insert into customer
values ('Ashley','Spring', 'Durham');
insert into customer
values ('Bonington','Senator', 'Sunderland');
insert into customer
values ('Christy','North', 'Newcastle');
insert into customer
values ('Harvard','Main', 'Durham');
insert into customer
values ('Jenkins','Alma', 'Sunderland');
insert into customer
values ('Thompson','Putnam', 'Newcastle');
insert into customer
values ('Jackson','Jarvis', 'Newcastle');
    
insert into acct_holding
values ('Harvard','C-102');
insert into acct_holding
values ('Jenkins','C-101');
insert into acct_holding
values ('Jenkins','C-201');
insert into acct_holding
values ('Thompson','C-305');
insert into acct_holding
values ('Jackson','C-222');
    
insert into deposit
values (1,'C-102', 'Seaham', 2500,'Ashley');
insert into deposit
values (2,'C-102', 'Seaham', 800,'Harvard');
insert into deposit
values (3,'C-305', 'St. Peter''s', 1500,'Christy');
insert into deposit
values (4,'C-222', 'Scotswood', 1200,'Jenkins');
    
COMMIT;