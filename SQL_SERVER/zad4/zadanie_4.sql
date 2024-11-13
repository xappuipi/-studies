CREATE DATABASE [nazwa_jakas];
USE [nazwa_jakas];

/* TUTAJ WCZYTAJ TABLICE Z PLIKU Z DANYMI DO TEGO ZADANIA */

/* KASOWANIE NA SAM KONIEC A KLUCZE OBCE PRZED OSTATNIE */

ALTER TABLE pracownik ADD ID_PRACOWNIK INT IDENTITY PRIMARY KEY;

SELECT * FROM pracownik;

CREATE TABLE imie(
	ID_IMIE INT IDENTITY PRIMARY KEY,
	imie varchar(15) not null,
	CONSTRAINT UNI_IMIE UNIQUE (imie)
);

INSERT INTO imie (imie)
SELECT DISTINCT IMIE
FROM pracownik;

SELECT * FROM imie;

CREATE TABLE nazwisko(
	ID_NAZWISKO INT IDENTITY PRIMARY KEY,
	nazwisko varchar(50) not null,
	CONSTRAINT UNI_NAZW UNIQUE (nazwisko)
);

INSERT INTO nazwisko (nazwisko)
SELECT DISTINCT NAZWISKO
FROM pracownik;

SELECT * FROM nazwisko;

CREATE TABLE tytul_zawodowy(
	ID_TYTUL_ZAWODOWY INT IDENTITY PRIMARY KEY,
	tytul_zawodowy varchar(50) not null,
	CONSTRAINT UNI_TYTUL UNIQUE (tytul_zawodowy)
);

INSERT INTO tytul_zawodowy(tytul_zawodowy)
SELECT DISTINCT TYTUL_ZAWODOWY
FROM pracownik;

SELECT * FROM tytul_zawodowy;

/*
stworzone zostaly tabele imie, nazwisko oraz tytul_zawodowy
*/

ALTER TABLE pracownik ADD
ID_IMIE INT,
ID_NAZWISKO INT,
ID_TYTUL_ZAWODOWY INT;

SELECT * FROM imie;

ALTER TABLE pracownik ADD
CONSTRAINT FK_IMIE FOREIGN KEY (ID_IMIE) REFERENCES imie(ID_IMIE),
CONSTRAINT FK_NAZWISKO FOREIGN KEY (ID_NAZWISKO) REFERENCES nazwisko(ID_NAZWISKO),
CONSTRAINT FK_TYTUL_ZAWODOWY FOREIGN KEY (ID_TYTUL_ZAWODOWY) REFERENCES tytul_zawodowy(ID_TYTUL_ZAWODOWY);

UPDATE pracownik
SET pracownik.ID_IMIE = imie.ID_IMIE
FROM pracownik
JOIN imie ON pracownik.IMIE = imie.imie;

SELECT * FROM pracownik;

UPDATE pracownik
SET pracownik.ID_NAZWISKO = nazwisko.ID_NAZWISKO
FROM pracownik
JOIN nazwisko ON pracownik.NAZWISKO = nazwisko.nazwisko;

UPDATE pracownik
SET pracownik.ID_TYTUL_ZAWODOWY = tytul_zawodowy.ID_TYTUL_ZAWODOWY
FROM pracownik
JOIN tytul_zawodowy ON pracownik.TYTUL_ZAWODOWY = tytul_zawodowy.tytul_zawodowy;

SELECT * FROM pracownik;

/* usuwanie zbednych tabel */

ALTER TABLE pracownik
DROP COLUMN 
IMIE,
NAZWISKO,
TYTUL_ZAWODOWY;