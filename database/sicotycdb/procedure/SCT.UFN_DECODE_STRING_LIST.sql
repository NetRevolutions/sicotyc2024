USE SicotycDB
GO
/****** Object:  UserDefinedFunction [SCT].[UFN_DECODE_STRING_LIST]    Script Date: 4/17/2024 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/***************************************************************************************************************
**	File			:	SCT.UFN_DECODE_STRING_LIST.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 17, 2024
**	Description		:	Return list of string values based in string list
****************************************************************************************************************
**  PARAMETERS		:	@List_String VARCHAR(MAX)

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
DECLARE 
@List_String VARCHAR(MAX) = 'abc;133;Jose R.;'
SELECT Item FROM SCT.UFN_DECODE_STRING_LIST(@List_String) 

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-17-2024	Jose Rodriguez A.	Initial Version
**
****************************************************************************************************************/

CREATE OR ALTER FUNCTION [SCT].[UFN_DECODE_STRING_LIST]
(
	@List_String VARCHAR(MAX)
)
RETURNS @List_Table TABLE (Item NVARCHAR(250) NOT NULL)
AS
BEGIN
	DECLARE @Pos INT, @NextPos INT

	SELECT @Pos = 1

	WHILE 1 = 1
	BEGIN
		SELECT @NextPos = CHARINDEX(';', @List_String, @Pos)
		IF (@NextPos <= 0)
			BREAK
		INSERT @List_Table (Item) VALUES (SUBSTRING(@List_String, @Pos, @NextPos - @Pos))
		SELECT @Pos = @NextPos + 1
	END
	RETURN
END;