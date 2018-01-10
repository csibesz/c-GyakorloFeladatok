use[testdb];

--SQL és a JOIN
--Simán:
--SELECT NEV, KOR, OSSZEG FROM VEVOK, MEGRENDELESEK WHERE VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--INNER JOIN: A két táblában, az egymással kapcsolatban lévõ rekordokat adja vissza
--SELECT NEV, KOR, OSSZEG FROM VEVOK INNER JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--LEFT JOIN: A bal tábla összes elemét visszaadja, illetve a jobb táblából csak azokat ami ezekkel az értékekkel kapcsolatban áll
--SELECT NEV, KOR, OSSZEG FROM VEVOK LEFT JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--RIGHT JOIN: A jobb tábla összes elemét visszaadja, illetve a bal táblából csak azokat ami ezekkel az értékekkel kapcsolatban áll
--SELECT NEV, KOR, OSSZEG FROM VEVOK RIGHT JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--FULL JOIN: Minden elemet kiválaszt minden táblából
--SELECT NEV, KOR, OSSZEG FROM VEVOK FULL JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--CROSS JOIN: Összeköti az egyik tábla minden rekordot a másik táblában található mezõvel
--SELECT NEV, KOR, OSSZEG FROM VEVOK CROSS JOIN MEGRENDELESEK;