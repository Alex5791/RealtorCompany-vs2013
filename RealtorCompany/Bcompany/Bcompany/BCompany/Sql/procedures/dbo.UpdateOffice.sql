CREATE PROCEDURE [dbo].[UpdateOffice] @N int, @Район varchar(20), @Улица varchar(20), @Дом INT, @Офис INT, @Этаж INT, @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
UPDATE offices
SET area=@Район, street=@Улица, house=@Дом, apartament=@Офис, floor=@Этаж, S=@Площадь, ad_type=@Тип_объявления, price=@Цена, date=@Дата, status=@Статус
Where office_id = @N