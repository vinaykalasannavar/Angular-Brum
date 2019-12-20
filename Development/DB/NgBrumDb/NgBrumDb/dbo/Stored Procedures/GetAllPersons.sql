-- =============================================
-- Author:		Vinay Kalasannavar
-- Create date: 19-Aug-2019
-- Description:	A sproc to read all Persons
-- =============================================
CREATE PROCEDURE dbo.GetAllPersons
	
AS
BEGIN
	SELECT	[Id]
		,	[Name]
		,	[Age]
		,	[FavouriteColour]
	FROM	[dbo].[Person]
END