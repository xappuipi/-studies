
/* Stworzenie bazy danych oraz zadeklarowanie ze w niej b�d� wykonywane komendy */
create database [nazwa_jakas];
use [nazwa_jakas];

/* Stworzenie w bazie danych tabeli o nazwie osoba */
create table osoba (
	nazwisko varchar(40),
	imie varchar(15)
);

select * from osoba;

/* Dodanie danych testowych */
insert into osoba (nazwisko, imie) values  
	('nazwisko0', 'imie0'),
	('nazwisko1', 'imie1'),
	('nazwisko2', 'imie2'),
	('nazwisko3', 'imie3')
;

select * from osoba;

/* 
zmiana nazwiska na not null 
gdyby w kolumnie nazwiosko istnia� rekord null trzebaby by�o go najpierw usunac
*/

alter table osoba alter column nazwisko varchar(40) not null;

/* ponowna modyfikacja tabeli - dodana zostaje kolumna ID_OSOBA */

alter table osoba add ID_OSOBA int;

select * from osoba;

/* ustawienie ID jako kolejne liczby oraz zmiana ID_OSOBA na not null */

update osoba set ID_OSOBA = 1 where nazwisko ='nazwisko0';
update osoba set ID_OSOBA = 2 where nazwisko ='nazwisko1';
update osoba set ID_OSOBA = 3 where nazwisko ='nazwisko2';
update osoba set ID_OSOBA = 4 where nazwisko ='nazwisko3';

select * from osoba;

alter table osoba alter column ID_OSOBA int not null;

/* zmiana typu danych kolumny ID_OSOBA na decimal(6,2) i spowrotem na int */

alter table osoba alter column ID_OSOBA decimal(6,2) not null;
select * from osoba;

alter table osoba alter column ID_OSOBA int not null;
select * from osoba;

/* dodanie ograniczenia na kolumne ID_OSOBA */

alter table osoba add constraint U_ID_OSOBA unique (ID_OSOBA);

/* Tworzenie nowej tabeli gender z ograniczeniami */
create table gender (
	ID_GENDER int,
	nazwa varchar(15)
);

alter table gender add constraint U_ID_GENDER unique (ID_GENDER);
alter table gender add constraint U_nazwa unique (nazwa);

/* dodanie przykladowych danych */

insert into gender (ID_GENDER, nazwa) values
	(1, 'mezczyzna'),
	(2, 'kobieta')
;

/* modyfikacja tabeli osoba */

alter table osoba add ID_GENDER int;

select * from osoba;

update osoba set ID_GENDER = 1 where nazwisko ='nazwisko0';
update osoba set ID_GENDER = 2 where nazwisko ='nazwisko1';
update osoba set ID_GENDER = 1 where nazwisko ='nazwisko2';
update osoba set ID_GENDER = 2 where nazwisko ='nazwisko3';

select * from osoba;

/* wypisywanie danych */

select * from osoba;
select * from gender;

/* wyswietlanie nazwiska i plci */

select o.nazwisko, g.nazwa 
from osoba o 
join gender g on o.ID_GENDER = g.ID_GENDER;