USE Sicotyc2023
GO

/***************************************************************************************************************
**	File			:	SCT.USP_ASSIGN_MENU_OPTIONS_ADMINISTRATOR.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 10, 2024
**	Description		:	Asign all menu options to Administrator Roles
****************************************************************************************************************
**  PARAMETERS		:	

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
EXEC SCT.USP_ASSIGN_MENU_OPTIONS_ADMINISTRATOR 

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-16-2024	Jose Rodriguez A.	Initial Version
**
****************************************************************************************************************/
CREATE OR ALTER PROCEDURE [SCT].[USP_ASSIGN_MENU_OPTIONS_ADMINISTRATOR]
AS
BEGIN
	DECLARE @ROL_ID NVARCHAR(450)
	SELECT
		@ROL_ID = ID
	FROM dbo.AspNetRoles
	WHERE NormalizedName = 'ADMINISTRATOR'

	TRUNCATE TABLE SCT.OPTIONS_ROLE

	INSERT INTO SCT.OPTIONS_ROLE (RoleId, OptionId)
		SELECT
			@ROL_ID
		   ,OptionId
		FROM SCT.OPTIONS

	SELECT
		RoleId
	   ,OptionId
	FROM SCT.OPTIONS_ROLE
END