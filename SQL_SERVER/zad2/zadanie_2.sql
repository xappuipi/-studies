create database [nazwa_jakas];

use [nazwa_jakas];

create table osoba(
	id_osoba int identity primary key,
	imie varchar(20),
	nazwisko varchar(40)
);

alter table osoba 
add id_gender int;


alter table osoba alter column imie varchar(20) not null;
alter table osoba alter column nazwisko varchar(40) not null;
alter table osoba alter column id_gender int not null;

create table adres(
	id_adres int identity primary key,
	ulica varchar(40),
	kod char(6),
	miasto varchar(40),
	id_osoba int
);

alter table adres alter column ulica varchar(40) not null;
alter table adres alter column kod char(6) not null;
alter table adres alter column miasto varchar(40) not null;
alter table adres alter column id_osoba int not null;

select * from osoba;

alter table adres
add constraint FK_ID_OSOBA_ADRES FOREIGN KEY (id_osoba)
references osoba(id_osoba);

create table osoba_stanowisko(
	id_osoba_stanowisko int identity primary key,
	id_osoba int not null,
	id_stanowisko int not null,
);

alter table osoba_stanowisko
add constraint FK_OSOBA_DO_OSOBA_STANOWISKO FOREIGN KEY (id_osoba)
references osoba(id_osoba);

create table stanowisko(
	id_stanowisko int identity primary key,
	nazwa varchar(20)
	);

alter table osoba_stanowisko
add constraint FK_STANOWISKO_DO_OSOBA_STANOWISKO FOREIGN KEY (id_stanowisko)
references stanowisko(id_stanowisko);

create table gender (
	id_gender int identity primary key,
	nazwa varchar(20) not null
);

create table telefon(
	id_telefon int identity primary key,
	marka varchar(20),
	id_osoba int
	);

create table emial(
	id_email int identity primary key,
	adres varchar(40),
	dostawca varchar(20),
	id_osoba int,
);

create table tytul(
	id_tytul int identity primary key,
	nazwa varchar(20)
	);

create table osoba_tytul(
	id_osoba_tytul int identity primary key,
	id_tytul int,
	id_osoba int,
	);

alter table telefon add constraint FK_OSOBA_TELEFON foreign key (id_osoba) references osoba(id_osoba);
alter table emial add constraint FK_OSOBA_EMAIL foreign key (id_osoba) references osoba(id_osoba);
alter table osoba_tytul add constraint FK_OSOBA_OSOBA_TYTUL foreign key (id_osoba) references osoba(id_osoba);
alter table osoba_tytul add constraint FK_TYTUL_OSOBA_TYTUL foreign key (id_tytul) references tytul(id_tytul);