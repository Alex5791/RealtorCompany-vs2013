CREATE PROCEDURE [dbo].[LoadLots]
AS
BEGIN
	SELECT lot_id AS N, area AS Район, street AS Улица, S AS Площадь, ad_type AS Тип_объявления, price AS Цена, date AS Дата, status AS Статус FROM lots	
END