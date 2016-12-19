CREATE PROCEDURE [dbo].[AddLot] @Район varchar(20), @Улица varchar(20), @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
INSERT INTO lots(area,street,S,ad_type,price,date,status)
VALUES(@Район, @Улица, @Площадь, @Тип_объявления, @Цена, @Дата, @Статус)