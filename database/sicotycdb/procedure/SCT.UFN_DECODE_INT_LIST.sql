USE SicotycDB
GO

/***************************************************************************************************************
**	File			:	SCT.UFN_DECODE_INT_LIST.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 17, 2024
**	Description		:	Return list of Int values based in string list
****************************************************************************************************************
**  PARAMETERS		:	@List_String VARCHAR(MAX)

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
DECLARE 
@List_String VARCHAR(MAX) = '1;2;3;4;5;6;7;8;9;10;'
SELECT Item FROM SCT.UFN_DECODE_INT_LIST(@List_String) 

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-17-2024	Jose Rodriguez A.	Initial Version
**
****************************************************************************************************************/

CREATE OR ALTER FUNCTION [SCT].[UFN_DECODE_INT_LIST]
(
	@List_String VARCHAR(MAX)
)
RETURNS @List_Table TABLE (Item INT NOT NULL)
AS
BEGIN
	DECLARE @Pos INT, @NextPos INT

	SELECT @Pos = 1

	WHILE 1 = 1
	BEGIN
		SELECT @NextPos = CHARINDEX(';', @List_String, @Pos)
		IF (@NextPos <= 0)
			BREAK
		INSERT @List_Table (Item) VALUES (CONVERT(INT, SUBSTRING(@List_String, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos + 1
	END
	RETURN
END;