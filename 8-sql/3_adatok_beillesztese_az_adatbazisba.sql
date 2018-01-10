use[testdb];

--Adatok beillesztése az adatbázisba
INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(1,'Rudolf', 32, 'Budapest', 200000);

INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(2,'Kati', 28, 'Miskolc', 180000);

INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(3,'Csilla', 40, 'Győr', 280000);

INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(4,'Hugó', 35, 'Zalakaros', 310000);

INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(5,'Géza', 55, 'Miskolc', 380000);

INSERT INTO VEVOK(ID, NEV, KOR, CIM, BER) 
VALUES(6,'Pityu', 20, 'Budapest', 140000);

--Így is lehet
INSERT INTO VEVOK VALUES(7,'Feri', 30, 'Budapest', 170000);

