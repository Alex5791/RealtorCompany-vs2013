CREATE PROCEDURE [dbo].[AddFlat] @Район varchar(20), @Улица varchar(20), @Дом INT, @Квартира INT, @Этаж INT, @Комнат INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20)  AS
INSERT INTO flats(area,street,house,apartament,floor,numrooms,S,ad_type,price)
VALUES(@Район, @Улица, @Дом, @Квартира, @Этаж, @Комнат, @Площадь, @Тип_объявления, @Цена)