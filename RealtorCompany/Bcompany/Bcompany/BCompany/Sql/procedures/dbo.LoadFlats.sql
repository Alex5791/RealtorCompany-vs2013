CREATE PROCEDURE [dbo].[LoadFlats]
AS
BEGIN
	SELECT flat_id AS N, area AS Район, street AS Улица, house AS Дом, apartament AS Квартира, floor AS Этаж, numrooms AS Комнат, S AS Площадь, ad_type AS Тип_объявления, price AS Цена, date AS Дата, status AS Статус FROM flats	
END