CREATE PROCEDURE [dbo].[LoadFlats]
AS
BEGIN
	SELECT area AS Район, street AS Улица, house AS Дом, apartament AS Квартира, floor AS Этаж, numrooms AS Комнат, S AS Площадь, ad_type AS Тип_объявления, price AS Цена FROM flats	
END