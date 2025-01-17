USE SicotycDB
GO

/***************************************************************************************************************
**	File			:	SCT.USP_GET_MENU_OPTIONS_BY_ROLE.sql
**	Author			:	Jose Rodriguez A.
**	Creation Date	:	April 10, 2024
**	Description		:	Select the options for menu sorted filter by role
****************************************************************************************************************
**  PARAMETERS		:	@ROLE_ID NVARCHAR(450)

**  RETURN VALUE	:	TABLE

**  DEPENDENCIES	:	NONE

**  TEST CODE
DECLARE @ROLE_NAME NVARCHAR(450) = 'Administrator'
--DECLARE @ROLE_NAME NVARCHAR(450) = 'Pepito'
EXEC [SCT].[USP_GET_MENU_OPTIONS_BY_ROLE] @ROLE_NAME 

****************************************************************************************************************
Change History
****************************************************************************************************************
**	VER		Date		Author				Description
**	---		---------	-----------------	-------------------------------------------------------------------
**	1		04-11-2024	Jose Rodriguez A.	Initial Version
**	2		04-12-2024	Jose Rodriguez A.	Change parameter (@ROLE_ID by @ROLE_NAME)
**	3		04-13-2024	Jose Rodriguez A.	Add OptionParentId field
****************************************************************************************************************/

CREATE OR ALTER PROCEDURE [SCT].[USP_GET_MENU_OPTIONS_BY_ROLE]
(
	@ROLE_NAME NVARCHAR(450)
)
AS
BEGIN
	DECLARE @ROLE_ID NVARCHAR(450) 
	SELECT @ROLE_ID = R.Id FROM dbo.AspNetRoles R WHERE R.[Name] = @ROLE_NAME	

	DECLARE @MenuOptions TABLE
	(
		[OptionId] UNIQUEIDENTIFIER NULL,
		[Title] NVARCHAR(100) NULL,
		[Icon] NVARCHAR(100) NULL,
		[URL] NVARCHAR(MAX),
		[OptionLevel] INT NULL,
		[OptionOrder] INT NULL,
		[OptionParentId] UNIQUEIDENTIFIER NULL
	)

	DECLARE @MenuParents TABLE
	(
		[OptionId] UNIQUEIDENTIFIER NULL,
		[Title] NVARCHAR(100) NULL,
		[Icon] NVARCHAR(100) NULL,
		[URL] NVARCHAR(MAX),
		[OptionLevel] INT NULL,
		[OptionOrder] INT NULL,
		[OptionParentId] UNIQUEIDENTIFIER NULL
	)

	INSERT INTO @MenuParents ([OptionId], [Title], [Icon], [Url], [OptionLevel], [OptionOrder], [OptionParentId])
	SELECT [OptionId]
		 , [Title]
		 , [Icon]
		 , [Url]
		 , [OptionLevel]
		 , [OptionOrder]
		 , [OptionParentId]
	FROM SCT.OPTIONS
	WHERE OptionLevel = 1
	ORDER BY OptionOrder ASC

	--SELECT * FROM @MenuParents

	DECLARE @COUNTER_PARENT INT = 1
	DECLARE @TOTAL_PARENT_ROWS INT
	DECLARE @OptionId UNIQUEIDENTIFIER

	SELECT @TOTAL_PARENT_ROWS = COUNT(1) FROM @MenuParents

	WHILE @COUNTER_PARENT <= @TOTAL_PARENT_ROWS
	BEGIN
		SELECT @OptionId = OptionId FROM SCT.OPTIONS WHERE OptionOrder = @COUNTER_PARENT AND OptionLevel = 1
		IF EXISTS (SELECT * FROM SCT.OPTIONS WHERE OptionParentId = @OptionId AND OptionLevel = 2)
		BEGIN
			-- INSERT Parent row
			INSERT INTO @MenuOptions ([OptionId], [Title], [Icon], [Url], [OptionLevel], [OptionOrder], [OptionParentId])
			SELECT [OptionId]
				 , [Title]
				 , [Icon]
				 , [Url]
				 , [OptionLevel]
				 , [OptionOrder]
				 , [P].[OptionParentId]
			FROM SCT.OPTIONS P
			WHERE P.OptionId = @OptionId
				AND P.OptionLevel = 1

			-- INSERT Child rows
			INSERT INTO @MenuOptions ([OptionId], [Title], [Icon], [Url], [OptionLevel], [OptionOrder], [OptionParentId])
			SELECT [OptionId]
				 , [Title]
				 , [Icon]
				 , [Url]
				 , [OptionLevel]
				 , [OptionOrder]
				 , [OptionParentId]
			FROM SCT.OPTIONS
			WHERE OptionParentId = @OptionId
				AND OptionLevel = 2
			ORDER BY OptionOrder ASC	
	
			SET @COUNTER_PARENT = @COUNTER_PARENT + 1
		END
	END

	SELECT O.OptionId
		 , O.Title
		 , O.Icon
		 , O.[Url]
		 , O.OptionOrder
		 , O.OptionLevel
		 , O.OptionParentId
		 , IsEnabled = (CASE
			   WHEN R.Id IS NULL THEN CAST(0 AS BIT)
			   ELSE CAST(1 AS BIT)
		   END)
	FROM @MenuOptions O
		LEFT JOIN SCT.OPTIONS_ROLE R ON O.OptionId = R.OptionId
			AND R.Id = @ROLE_ID
END