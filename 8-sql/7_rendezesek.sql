use[testdb];

--Rendez�sek
--SELECT * FROM VEVOK ORDER BY NEV; -->ABC szerint
--SELECT * FROM VEVOK ORDER BY NEV ASC; -->ABC szerint
--SELECT * FROM VEVOK ORDER BY NEV DESC;

--�sszead�s, �s csoportos�t�s
--SELECT NEV, SUM(BER) FROM VEVOK GROUP BY NEV;

--Dupluk�ci� sz�r�se
--SELECT DISTINCT BER FROM VEVOK ORDER BY BER;

--Tetsz�leges sorrend/sorbarendez�s be�ll�t�sa
--SELECT * FROM VEVOK ORDER BY CIM DESC; --sim�n
/*SELECT * FROM VEVOK ORDER BY
	(CASE CIM
		WHEN 'Gy�r' THEN 1
		WHEN 'Miskolc' THEN 2
		ELSE 4 END) ASC;
*/
--SQL Megk�t�sek
--NOT NULL megk�t�s -> Nem lehet �res �rt�k (El�z� p�lda)
--Default megk�t�s -> Megadjuk hogy mi legyen az alap�rt�k ami a mez�be ker�l, ha nincs kit�ltve
/*
CREATE TABLE VEVOK (
			ID INT NOT NULL,
			NEV VARCHAR(20) NOT NULL,
			KOR INT,
			CIM VARCHAR(30),
			BER DECIMAL(18,2) DEFAULT 300000,
			PRIMARY KEY(ID) );	
*/
-- Egyedi megk�t�s -> Az egyedi mez�k �rt�kei, nem lehetnek  egyform�k
--M�dos�tsuk a t�bl�t
--ALTER TABLE VEVOK ADD CONSTRAINT egyediMegkotesNeve UNIQUE(KOR,BER); -> Hib�val elsz�ll, mert a kor �s a b�r mez�kben vannak duplik�tumok

--Idegen kulcs: Ha 2 t�bl�t veszek fel az adatb�zisban, �sszek�thetem �ket, az idegen kulcs megad�s�val
/*CREATE TABLE MEGRENDELESEK (
		ID INT NOT NULL,
		DATUM DATETIME,
		VEVO_ID INT references VEVOK(ID),
		OSSZEG INT,
		PRIMARY KEY(ID)
);*/
--Ha elfelejtett�k be�ll�tani, akkor m�dos�thatok
--ALTER TABLE MEGRENDELESEK ADD FOREIGN KEY(VEVO_ID) REFERENCES VEVOK(ID);
--K�ls� kulcs t�rl�se
--ALTER TABLE MEGRENDELESEK DROP FOREIGN KEY;

--Ellen�rz� megk�t�s: (Ellen�rizz�k az adatokat miel�tt mentj�k)
/*
CREATE TABLE VEVOK (
			ID INT NOT NULL,
			NEV VARCHAR(20) NOT NULL,
			KOR INT CHECK(KOR >= 18),
			CIM VARCHAR(30),
			BER DECIMAL(18,2) DEFAULT 300000,
			PRIMARY KEY(ID) );	
*/
--Ha m�r egy l�trej�tt t�bl�ban szeretn�nk m�dos�tani
--ALTER TABLE VEVOK ADD CONSTRAINT ellenorzoMegkotes CHECK(KOR >= 18);

--Indexel�s: Az adatok gyors el�r�s�hez a kiv�lasztott mez�ket indexelhetj�k
--Szintaktika: CREATE INDEX index_neve ON t�blaneve (oszlop1, oszlop2..);
--CREATE INDEX kor_index ON VEVOK(KOR);
