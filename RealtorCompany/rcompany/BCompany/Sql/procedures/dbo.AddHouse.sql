CREATE PROCEDURE [dbo].[AddHouse] @Район varchar(20), @Улица varchar(20), @Дом INT, @Этажей INT, @Комнат INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20)  AS
INSERT INTO houses(area,street,house,numfloors,numrooms,S,ad_type,price)
VALUES(@Район, @Улица, @Дом, @Этажей, @Комнат, @Площадь, @Тип_объявления, @Цена)