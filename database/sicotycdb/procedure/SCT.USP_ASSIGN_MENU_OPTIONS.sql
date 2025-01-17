USE SicotycDB
GO

/***************************************************************************************************************
**	File			:	SCT.USP_ASSIGN_MENU_OPTIONS.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 10, 2024
**	Description		:	Asign all menu options to Rol selected
****************************************************************************************************************
**  PARAMETERS		:	

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
DECLARE 
@roleName NVARCHAR(256) = 'Forwarder',
@strOptionIds VARCHAR(MAX) = '84742A3D-29F0-4E55-B47B-6420F47FA2CF;35A95AFE-D92C-4584-A5E8-7A4561F0CDCF;26208AFE-C521-4DA1-8EF2-7FF703A526BC;DD615B59-E269-4C45-BA3F-54FE39424AEF;'
EXEC SCT.USP_ASSIGN_MENU_OPTIONS @roleName, @strOptionIds

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-16-2024	Jose Rodriguez A.	Initial Version
**
****************************************************************************************************************/
CREATE OR ALTER PROCEDURE [SCT].[USP_ASSIGN_MENU_OPTIONS]
(
	@roleName NVARCHAR(256),
	@strOptionIds VARCHAR(MAX)
)
AS
BEGIN
	DECLARE @ROL_ID NVARCHAR(450)
	SELECT @ROL_ID = ID FROM dbo.AspNetRoles WHERE [Name] = @roleName
	IF (@ROL_ID IS NOT NULL)
	BEGIN
		DELETE SCT.OPTIONS_ROLE
		WHERE Id = @ROL_ID

		INSERT INTO SCT.OPTIONS_ROLE (Id, OptionId)
		SELECT @ROL_ID, Item FROM SCT.UFN_DECODE_UNIQUEIDENTIFIER_LIST(@strOptionIds)

		SELECT Id, OptionId FROM SCT.OPTIONS_ROLE WHERE Id = @ROL_ID
	END	
END