CREATE PROCEDURE [dbo].[UpdateHouse] @N int, @Район varchar(20), @Улица varchar(20), @Дом INT, @Этажей INT, @Комнат INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
UPDATE houses 
SET area=@Район, street=@Улица, house=@Дом, numfloors=@Этажей, numrooms=@Комнат, S=@Площадь, ad_type=@Тип_объявления, price=@Цена, date=@Дата, status=@Статус
Where house_id = @N