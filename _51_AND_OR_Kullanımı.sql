Use Northwind
GO

Select * FROM Satislar
WHERE (NakliyeUcreti>100 And NakliyeUcreti<400) OR (NakliyeUcreti>700 and NakliyeUcreti<800)
ORDER BY NakliyeUcreti DESC