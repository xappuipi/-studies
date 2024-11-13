create database [nazwa_jakas];

use [nazwa_jakas];

/* TUTAJ WCZYTAJ TABLICE Z PLIKU Z DANYMI DO TEGO ZADANIA */

alter table [dbo].[EMPLOYEE]
add ID_EMPLOYEE int identity primary key,
wiek int;

/* w szukaniu najstarszej osoby wazna jest cala data urodzenia
	SELECT GROUPBY ORDERBY
	GRUPY WIEKOWE:
	ILOSC LAT PO PROSTU
	np ile osob ma 2 lata itp
*/

/* OBLICZANIE WIEKU */
UPDATE [dbo].[EMPLOYEE]
SET wiek = DATEDIFF(yy, BirthDate, GETDATE());

select * from [dbo].[EMPLOYEE];

/* najstarsza osoba */

SELECT TOP 1 ID_EMPLOYEE, FirstName, LastName, BirthDate as BD, wiek
FROM [dbo].[EMPLOYEE]
GROUP BY ID_EMPLOYEE, FirstName, LastName, wiek, BirthDate
ORDER BY BD ASC;

/* najmolodsza osoba */

SELECT TOP 1 ID_EMPLOYEE, FirstName, LastName, BirthDate as BD, wiek
FROM [dbo].[EMPLOYEE]
GROUP BY ID_EMPLOYEE, FirstName, LastName, wiek, BirthDate
ORDER BY BD DESC;

/* KAZDA GRUPA WIEKOWA */

SELECT COUNT(ID_EMPLOYEE) as liczba_osob, wiek
from [dbo].[EMPLOYEE]
GROUP BY wiek;

/* kopiowanie 10 najstarszych */

/*
DO TESTOW WYSWIETLANIE NAJSTARSZYCH OSOB

SELECT TOP 10 ID_EMPLOYEE, FirstName, LastName, BirthDate, wiek
FROM [dbo].[EMPLOYEE]
ORDER BY BirthDate ASC;
*/

SELECT TOP 10 ID_EMPLOYEE, FirstName, LastName, BirthDate, wiek
INTO [dbo].[OLD_EMPLOYEE]
FROM [dbo].[EMPLOYEE]
ORDER BY BirthDate ASC;

SELECT * FROM OLD_EMPLOYEE;