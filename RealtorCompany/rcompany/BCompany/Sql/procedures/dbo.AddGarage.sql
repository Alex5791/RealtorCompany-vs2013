CREATE PROCEDURE [dbo].[AddGarage] @Район varchar(20), @Улица varchar(20), @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20)  AS
INSERT INTO garages(area,street,S,ad_type,price)
VALUES(@Район, @Улица, @Площадь, @Тип_объявления, @Цена)