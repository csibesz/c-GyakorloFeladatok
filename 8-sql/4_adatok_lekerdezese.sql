use[testdb];

--Kérdezzük le az összes adatot
--SELECT * FROM VEVOK;

--Kérdezzünk le csak 3 mezőt
--SELECT ID, NEV, BER FROM VEVOK;

--Lekérdezés feltétel alapján
--SELECT ID, NEV, BER FROM VEVOK WHERE BER > 150000;

--Kérdezzünk le személy alapján
--SELECT ID, NEV, BER FROM VEVOK WHERE NEV = 'Pityu';

--Összetett lekérdezés (Konjuktív operátorok AND OR)
--SELECT ID, NEV, BER FROM VEVOK WHERE BER > 150000 AND KOR < 25;