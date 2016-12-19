CREATE PROCEDURE [dbo].[AddOffice] @Район varchar(20), @Улица varchar(20), @Дом INT, @Офис INT, @Этаж INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
INSERT INTO offices(area,street,house,apartament,floor,S,ad_type,price,date,status)
VALUES(@Район, @Улица, @Дом, @Офис, @Этаж, @Площадь, @Тип_объявления, @Цена, @Дата, @Статус)