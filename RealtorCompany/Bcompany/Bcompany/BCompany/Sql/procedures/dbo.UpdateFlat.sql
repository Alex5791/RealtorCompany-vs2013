CREATE PROCEDURE [dbo].[UpdateFlat] @N int, @Район varchar(20), @Улица varchar(20), @Дом INT, @Квартира INT, @Этаж INT, @Комнат INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
UPDATE flats
SET area=@Район, street=@Улица, house=@Дом, apartament=@Квартира, floor=@Этаж, numrooms=@Комнат, S=@Площадь, ad_type=@Тип_объявления, price=@Цена, date=@Дата, status=@Статус
Where flat_id = @N