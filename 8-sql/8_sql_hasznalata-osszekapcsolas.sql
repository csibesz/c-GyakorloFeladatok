use[testdb];

--SQL �s a JOIN
--Sim�n:
--SELECT NEV, KOR, OSSZEG FROM VEVOK, MEGRENDELESEK WHERE VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--INNER JOIN: A k�t t�bl�ban, az egym�ssal kapcsolatban l�v� rekordokat adja vissza
--SELECT NEV, KOR, OSSZEG FROM VEVOK INNER JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--LEFT JOIN: A bal t�bla �sszes elem�t visszaadja, illetve a jobb t�bl�b�l csak azokat ami ezekkel az �rt�kekkel kapcsolatban �ll
--SELECT NEV, KOR, OSSZEG FROM VEVOK LEFT JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--RIGHT JOIN: A jobb t�bla �sszes elem�t visszaadja, illetve a bal t�bl�b�l csak azokat ami ezekkel az �rt�kekkel kapcsolatban �ll
--SELECT NEV, KOR, OSSZEG FROM VEVOK RIGHT JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--FULL JOIN: Minden elemet kiv�laszt minden t�bl�b�l
--SELECT NEV, KOR, OSSZEG FROM VEVOK FULL JOIN MEGRENDELESEK ON VEVOK.ID = MEGRENDELESEK.VEVO_ID;
--CROSS JOIN: �sszek�ti az egyik t�bla minden rekordot a m�sik t�bl�ban tal�lhat� mez�vel
--SELECT NEV, KOR, OSSZEG FROM VEVOK CROSS JOIN MEGRENDELESEK;