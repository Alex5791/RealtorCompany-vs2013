CREATE PROCEDURE [dbo].[LoadGarages]
AS
BEGIN
	SELECT area AS Район, street AS Улица, S AS Площадь, ad_type AS Тип_объявления, price AS Цена FROM garages	
END