CREATE PROCEDURE [dbo].[LoadHouses]
AS
BEGIN
	SELECT area AS Район, street AS Улица, house AS Дом, numfloors AS Этажей, numrooms AS Комнат, S AS Площадь, ad_type AS Тип_объявления, price AS Цена FROM houses
END