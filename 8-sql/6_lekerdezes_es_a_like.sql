use[testdb];
--SQL és Like
/*
Szintaktika

SELECT FROM tablaneve WHERE oszlop LIKE 'cica%'; -> a szöveg cica-val kezdõdik, és tetszõleges számú karakter jöhet utána 
SELECT FROM tablaneve WHERE oszlop LIKE '%cica%'; -> A szövegben akárhol szerepel a cica
SELECT FROM tablaneve WHERE oszlop LIKE 'cica_'; -> Minden olyan 5 karakteres szöveg, ami cicával kezdõdik
SELECT FROM tablaneve WHERE oszlop LIKE '_cica'; -> Minden olyan 5 karakteres szöveg, ami cicára végzõdik
SELECT FROM tablaneve WHERE oszlop LIKE '_cica_'; -> Minden olyan 6 karakteres szöveg, amiben benne van a cica
*/

--Válasszunk ki minden olyan értéket, ami 200-al kezdõdik
--SELECT * FROM VEVOK WHERE BER LIKE '200%';

--Válasszunk ki minden olyan értéket, amiben szerepel a 900
--SELECT * FROM VEVOK WHERE BER LIKE '%900%';

--Válasszunk ki minden olyan értéket, amiben a 00 a 2. és a 3. helyen szerepel
--SELECT * FROM VEVOK WHERE BER LIKE '_00%';

--Válasszunk ki minden olyan értéket, ami 2-vel kezdõdik, minimum 3 karakter hosszú, és a 3 karakter elõtt és után bármi állhat
--SELECT * FROM VEVOK WHERE BER LIKE '2_%_%';

--Válasszunk ki minden olyan értéket, ami 0-ra végzõdik
--SELECT * FROM VEVOK WHERE BER LIKE '%0';

--Válasszunk ki minden olyan értéket, aminek a 2. pozíciójában a 8as szerepel, és az utolsó helyen a 0
--SELECT * FROM VEVOK WHERE BER LIKE '_8%0';

--Válasszuk ki a legelsõ 3 elemet
SELECT TOP 3 * FROM VEVOK;
--MYSQL: SELECT * FROM VEVOK LIMIT 3;