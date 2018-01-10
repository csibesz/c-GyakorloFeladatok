--Adatbázis használata
use [testdb];

--Tábla létrehozása az adatbázisban
--Szintaktika:
/*CREATE TABLE táblaneve(
			oszlop1 adattípusa,
			oszlop2 adattípusa,
			oszlop3......,
			PRIMARY KEY (egy vagy több oszlop));*/

CREATE TABLE VEVOK (
			ID INT NOT NULL,
			NEV VARCHAR(20) NOT NULL,
			KOR INT,
			CIM VARCHAR(30),
			BER DECIMAL(18,2),
			PRIMARY KEY(ID) );	


--Tábla törlése az adatbázisban
--DROP TABLE VEVOK;





			