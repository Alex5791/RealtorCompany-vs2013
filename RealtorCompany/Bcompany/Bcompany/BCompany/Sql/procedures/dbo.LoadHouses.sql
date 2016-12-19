CREATE PROCEDURE [dbo].[LoadHouses]
AS
BEGIN
	SELECT house_id AS N, area AS Район, street AS Улица, house AS Дом, numfloors AS Этажей, numrooms AS Комнат, S AS Площадь, ad_type AS Тип_объявления, price AS Цена, date AS Дата, status AS Статус FROM houses
END