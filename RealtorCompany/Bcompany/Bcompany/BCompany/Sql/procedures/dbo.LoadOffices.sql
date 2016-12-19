CREATE PROCEDURE [dbo].[LoadOffices]
AS
BEGIN
	SELECT office_id AS N, area AS Район, street AS Улица, house AS Дом, apartament AS Офис, floor AS Этаж, S AS Площадь, ad_type AS Тип_объявления, price AS Цена, date AS Дата, status AS Статус FROM offices	
END