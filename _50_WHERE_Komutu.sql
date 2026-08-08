USE Northwind
GO

SELECT * FROM Kategoriler WHERE KategoriAdi='Seafood'/* KatagoriAdi Seafood olan veriyi getirdik*/


SELECT * FROM [Satis Detaylari] ORDER BY BirimFiyati DESC /* Tablo isminde boşluk olduğu için [ ] kullandık ve birim fiyatına göre sıraladık*/


SELECT COUNT(*),BirimFiyati FROM [Satis Detaylari]
WHERE BirimFiyati>=200
GROUP BY BirimFiyati /* COUNT Kullanmak için GROUP BY Kullandık Count Group olmazsa kullanılamaz Count kaç adet olduğunu söyler*/


SELECT * FROM [Satis Detaylari]
WHERE SatisID=11077

SELECT * FROM Urunler
WHERE UrunID=13 or UrunID=20 or UrunID=30/* OR kullanımı WHERE içerisinde*/

SELECT * FROM [Satis Detaylari]  /* Alttaki blog ile aynı sonuç ancak farlı kod*/
WHERE BirimFiyati>150 and BirimFiyati<250
ORDER BY BirimFiyati DESC


SELECT * FROM [Satis Detaylari]
WHERE BirimFiyati BETWEEN 150 and 250
ORDER BY BirimFiyati DESC