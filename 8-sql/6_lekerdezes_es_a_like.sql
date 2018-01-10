use[testdb];
--SQL �s Like
/*
Szintaktika

SELECT FROM tablaneve WHERE oszlop LIKE 'cica%'; -> a sz�veg cica-val kezd�dik, �s tetsz�leges sz�m� karakter j�het ut�na 
SELECT FROM tablaneve WHERE oszlop LIKE '%cica%'; -> A sz�vegben ak�rhol szerepel a cica
SELECT FROM tablaneve WHERE oszlop LIKE 'cica_'; -> Minden olyan 5 karakteres sz�veg, ami cic�val kezd�dik
SELECT FROM tablaneve WHERE oszlop LIKE '_cica'; -> Minden olyan 5 karakteres sz�veg, ami cic�ra v�gz�dik
SELECT FROM tablaneve WHERE oszlop LIKE '_cica_'; -> Minden olyan 6 karakteres sz�veg, amiben benne van a cica
*/

--V�lasszunk ki minden olyan �rt�ket, ami 200-al kezd�dik
--SELECT * FROM VEVOK WHERE BER LIKE '200%';

--V�lasszunk ki minden olyan �rt�ket, amiben szerepel a 900
--SELECT * FROM VEVOK WHERE BER LIKE '%900%';

--V�lasszunk ki minden olyan �rt�ket, amiben a 00 a 2. �s a 3. helyen szerepel
--SELECT * FROM VEVOK WHERE BER LIKE '_00%';

--V�lasszunk ki minden olyan �rt�ket, ami 2-vel kezd�dik, minimum 3 karakter hossz�, �s a 3 karakter el�tt �s ut�n b�rmi �llhat
--SELECT * FROM VEVOK WHERE BER LIKE '2_%_%';

--V�lasszunk ki minden olyan �rt�ket, ami 0-ra v�gz�dik
--SELECT * FROM VEVOK WHERE BER LIKE '%0';

--V�lasszunk ki minden olyan �rt�ket, aminek a 2. poz�ci�j�ban a 8as szerepel, �s az utols� helyen a 0
--SELECT * FROM VEVOK WHERE BER LIKE '_8%0';

--V�lasszuk ki a legels� 3 elemet
SELECT TOP 3 * FROM VEVOK;
--MYSQL: SELECT * FROM VEVOK LIMIT 3;