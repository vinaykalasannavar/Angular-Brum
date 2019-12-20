CREATE TABLE [dbo].[Person]
(
	[Id]				INT			NOT NULL PRIMARY KEY	IDENTITY(1,1)	,
	[Name]				VARCHAR		(200)									,
	[Age]				DECIMAL		(4, 2)									,
	[FavouriteColour]	VARCHAR		(200)									
)
 