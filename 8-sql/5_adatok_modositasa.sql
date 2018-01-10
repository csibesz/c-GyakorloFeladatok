use[testdb];
--Adatok módosítása(frissítése)
UPDATE VEVOK SET CIM = 'Pozsony' WHERE ID = 6;

--Összetett módosítás
UPDATE VEVOK SET CIM='Miskolc', BER='199000' WHERE ID = 4;

--Adatok törlése
DELETE FROM VEVOK WHERE ID = 6;