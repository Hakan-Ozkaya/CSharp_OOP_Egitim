/* Satışlardaki Nakliye Ücretini Kullanıyoruz*/

USE Northwind /* Kullanacağım Veritabanını belirttim*/
GO

/*SELECT SevkUlkesi FROM Satislar ORDER BY SevkUlkesi DESC /* ACS --- Ascending Sıralama Bicimi default halidir*/ /* DESC -- Desecending  Ters sıralama z den a ya şeklinde */ */
SELECT * FROM Satislar ORDER BY NakliyeUcreti DESC,SevkUlkesi DESC /* ORDER Y İle sıralama işlemi yaptık*/ /* Burada nakliye ücreti aynı olanlar kendi içerisinde ülkeler sıralancak alfabe Tersine Göre göre*/