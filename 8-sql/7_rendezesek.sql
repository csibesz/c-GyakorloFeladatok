use[testdb];

--Rendezések
--SELECT * FROM VEVOK ORDER BY NEV; -->ABC szerint
--SELECT * FROM VEVOK ORDER BY NEV ASC; -->ABC szerint
--SELECT * FROM VEVOK ORDER BY NEV DESC;

--Összeadás, és csoportosítás
--SELECT NEV, SUM(BER) FROM VEVOK GROUP BY NEV;

--Duplukáció szûrése
--SELECT DISTINCT BER FROM VEVOK ORDER BY BER;

--Tetszõleges sorrend/sorbarendezés beállítása
--SELECT * FROM VEVOK ORDER BY CIM DESC; --simán
/*SELECT * FROM VEVOK ORDER BY
	(CASE CIM
		WHEN 'Gyõr' THEN 1
		WHEN 'Miskolc' THEN 2
		ELSE 4 END) ASC;
*/
--SQL Megkötések
--NOT NULL megkötés -> Nem lehet üres érték (Elõzõ példa)
--Default megkötés -> Megadjuk hogy mi legyen az alapérték ami a mezõbe kerül, ha nincs kitöltve
/*
CREATE TABLE VEVOK (
			ID INT NOT NULL,
			NEV VARCHAR(20) NOT NULL,
			KOR INT,
			CIM VARCHAR(30),
			BER DECIMAL(18,2) DEFAULT 300000,
			PRIMARY KEY(ID) );	
*/
-- Egyedi megkötés -> Az egyedi mezõk értékei, nem lehetnek  egyformák
--Módosítsuk a táblát
--ALTER TABLE VEVOK ADD CONSTRAINT egyediMegkotesNeve UNIQUE(KOR,BER); -> Hibával elszáll, mert a kor és a bér mezõkben vannak duplikátumok

--Idegen kulcs: Ha 2 táblát veszek fel az adatbázisban, összeköthetem õket, az idegen kulcs megadásával
/*CREATE TABLE MEGRENDELESEK (
		ID INT NOT NULL,
		DATUM DATETIME,
		VEVO_ID INT references VEVOK(ID),
		OSSZEG INT,
		PRIMARY KEY(ID)
);*/
--Ha elfelejtettük beállítani, akkor módosíthatok
--ALTER TABLE MEGRENDELESEK ADD FOREIGN KEY(VEVO_ID) REFERENCES VEVOK(ID);
--Külsõ kulcs törlése
--ALTER TABLE MEGRENDELESEK DROP FOREIGN KEY;

--Ellenörzõ megkötés: (Ellenõrizzük az adatokat mielõtt mentjük)
/*
CREATE TABLE VEVOK (
			ID INT NOT NULL,
			NEV VARCHAR(20) NOT NULL,
			KOR INT CHECK(KOR >= 18),
			CIM VARCHAR(30),
			BER DECIMAL(18,2) DEFAULT 300000,
			PRIMARY KEY(ID) );	
*/
--Ha már egy létrejött táblában szeretnénk módosítani
--ALTER TABLE VEVOK ADD CONSTRAINT ellenorzoMegkotes CHECK(KOR >= 18);

--Indexelés: Az adatok gyors eléréséhez a kiválasztott mezõket indexelhetjük
--Szintaktika: CREATE INDEX index_neve ON táblaneve (oszlop1, oszlop2..);
--CREATE INDEX kor_index ON VEVOK(KOR);
