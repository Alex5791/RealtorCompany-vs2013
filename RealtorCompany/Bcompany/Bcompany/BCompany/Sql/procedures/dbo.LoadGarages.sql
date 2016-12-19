CREATE PROCEDURE [dbo].[LoadGarages]
AS
BEGIN
	SELECT garage_id AS N, area AS Район, street AS Улица, S AS Площадь, ad_type AS Тип_объявления, price AS Цена, date AS Дата, status AS Статус FROM garages	
END