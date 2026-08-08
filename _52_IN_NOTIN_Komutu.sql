USE Northwind
GO

SELECT * FROM Satislar
WHERE MusteriID IN ('BLONP','HANAR','VINET')/* IN Komutu* içerisinde olanları getirir. altta ise mantıksız bir kullanım göstrildi*/
/* WHERE MusteriID='BLONP' OR MusteriID='HANAR' OR MusteriID='VINET' */


SELECT * FROM Satislar
WHERE MusteriID NOT IN ('BLONP','HANAR','VINET')/* NOT IN ile bunlar harici getirildi*/