USE Northwind
GO

SELECT DISTINCT Sehir FROM Musteriler/* DISTINCT Komutu ile aynı olanlar 1 defa getirir birden fazla getirmez*/

SELECT DISTINCT Sehir,MusteriAdi FROM Musteriler


SELECT  TOP 10 * FROM Musteriler  /* İlk 10 Kullanıcıları Göstermek*/ 
