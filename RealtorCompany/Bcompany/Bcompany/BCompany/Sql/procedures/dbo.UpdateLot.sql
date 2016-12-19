CREATE PROCEDURE [dbo].[UpdateLot] @N int, @Район varchar(20), @Улица varchar(20), @Площадь INT, @Тип_объявления varchar(20), @Цена varchar(20), @Дата Date, @Статус varchar(20)  AS
UPDATE lots
SET area=@Район, street=@Улица, S=@Площадь, ad_type=@Тип_объявления, price=@Цена, date=@Дата, status=@Статус
Where lot_id = @N