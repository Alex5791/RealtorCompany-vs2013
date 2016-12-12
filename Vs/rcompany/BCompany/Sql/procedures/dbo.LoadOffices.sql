CREATE PROCEDURE [dbo].[LoadOffices]
AS
BEGIN
	SELECT area AS Район, street AS Улица, house AS Дом, apartament AS Офис, floor AS Этаж, S AS Площадь, ad_type AS Тип_объявления, price AS Цена FROM offices	
END