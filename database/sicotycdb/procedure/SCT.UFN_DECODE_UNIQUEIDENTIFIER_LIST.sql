USE Sicotyc2023
GO

/***************************************************************************************************************
**	File			:	SCT.UFN_DECODE_UNIQUEIDENTIFIER_LIST.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 17, 2024
**	Description		:	Return list of UniqueIdentifier Ids based in string list
****************************************************************************************************************
**  PARAMETERS		:	@List_String VARCHAR(MAX)

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
DECLARE 
@List_String VARCHAR(MAX) = '84742A3D-29F0-4E55-B47B-6420F47FA2CF;35A95AFE-D92C-4584-A5E8-7A4561F0CDCF;26208AFE-C521-4DA1-8EF2-7FF703A526BC;'
SELECT Item FROM SCT.UFN_DECODE_UNIQUEIDENTIFIER_LIST(@List_String) 

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-17-2024	Jose Rodriguez A.	Initial Version
**
****************************************************************************************************************/

CREATE OR ALTER FUNCTION [SCT].[UFN_DECODE_UNIQUEIDENTIFIER_LIST]
(
	@List_String VARCHAR(MAX)
)
RETURNS @List_Table TABLE (Item UNIQUEIDENTIFIER NOT NULL)
AS
BEGIN
	DECLARE @Pos INT, @NextPos INT

	SELECT @Pos = 1

	WHILE 1 = 1
	BEGIN
		SELECT @NextPos = CHARINDEX(';', @List_String, @Pos)
		IF (@NextPos <= 0)
			BREAK
		INSERT @List_Table (Item) VALUES (CONVERT(UNIQUEIDENTIFIER, SUBSTRING(@List_String, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos + 1
	END
	RETURN
END;