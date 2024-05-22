USE Sicotyc2023
GO

/***************************************************************************************************************
*	File			:	MenuOptions.sql
*	Author			:	Jose Rodriguez A.
*	Creation Date	:	April 10, 2024
*	Description		:	Generate the options for menu
****************************************************************************************************************/

/*** INSERT OPTIONS FOR LEVEL 1 ***/
IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Dashboard' AND OptionLevel = 1)
INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
VALUES (NEWID(), 'Dashboard', 'mdi mdi-gauge', NULL, 1, 1, NULL, 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Operaciones' AND OptionLevel = 1)
INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
VALUES (NEWID(), 'Operaciones', 'mdi mdi-memory', NULL, 2, 1, NULL, 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Mantenimientos' AND OptionLevel = 1)
INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
VALUES (NEWID(), 'Mantenimientos', 'mdi mdi-folder-lock-open', NULL, 3, 1, NULL, 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Tutoriales' AND OptionLevel = 1)
INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
VALUES (NEWID(), 'Tutoriales', 'mdi mdi-folder-lock-open', NULL, 4, 1, NULL, 'SYSTEM', GETUTCDATE())
GO

--=================================================================================================================

/*** INSERT OPTIONS FOR LEVEL 2 ***/
DECLARE @parentOptionID UNIQUEIDENTIFIER
DECLARE @maxOrderNum INT

-------------------------------------------------------------------------------------------------------------------
-- Dashboard options
SELECT @parentOptionID = OptionID FROM SCT.OPTIONS WHERE Title = 'Dashboard' AND OptionLevel = 1
SELECT @maxOrderNum = ISNULL(MAX(OptionOrder), 0) FROM SCT.OPTIONS WHERE OptionParentId = @parentOptionID AND OptionLevel = 2

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Main' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Main', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'ProgressBar' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ProgressBar', NULL, '/dashboard/progress', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Graficas' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Graficas', NULL, '/dashboard/grafica1', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Promesas' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Promesas', NULL, '/dashboard/promesas', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Juegos Azar' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Juegos Azar', NULL, '/dashboard/juegos-azar', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'rxJS' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'rxJS', NULL, '/dashboard/rxjs', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END
-------------------------------------------------------------------------------------------------------------------
-- Operaciones options
SELECT @parentOptionID = OptionID FROM SCT.OPTIONS WHERE Title = 'Operaciones' AND OptionLevel = 1
SELECT @maxOrderNum = ISNULL(MAX(OptionOrder), 0) FROM SCT.OPTIONS WHERE OptionParentId = @parentOptionID AND OptionLevel = 2

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Calculo de Tarifas' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Calculo de Tarifas', NULL, '/operaciones/calculo-tarifas', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Evaluacion de Servicio' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Evaluacion de Servicio', NULL, '/operaciones/evaluacion-servicio', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Creacion de Servicio' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Creacion de Servicio', NULL, '/operaciones/creacion-servicio', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END
-------------------------------------------------------------------------------------------------------------------
-- Mantenimientos options
SELECT @parentOptionID = OptionID FROM SCT.OPTIONS WHERE Title = 'Mantenimientos' AND OptionLevel = 1
SELECT @maxOrderNum = ISNULL(MAX(OptionOrder), 0) FROM SCT.OPTIONS WHERE OptionParentId = @parentOptionID AND OptionLevel = 2

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Usuarios' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Usuarios', NULL, '/mantenimientos/users', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Lookup Code Groups' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Lookup Code Groups', NULL, '/mantenimientos/lookupCodeGroups', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Lookup Codes' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Lookup Codes', NULL, '/mantenimientos/lookupCodeGroups/lookupCodes', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Menu' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Menu', NULL, '/mantenimientos/menu', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END
-------------------------------------------------------------------------------------------------------------------
-- Tutoriales options
SELECT @parentOptionID = OptionID FROM SCT.OPTIONS WHERE Title = 'Tutoriales' AND OptionLevel = 1
SELECT @maxOrderNum = ISNULL(MAX(OptionOrder), 0) FROM SCT.OPTIONS WHERE OptionParentId = @parentOptionID AND OptionLevel = 2

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Conociendo SICOTYC' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Conociendo SICOTYC', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Solicitar Servicios' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Solicitar Servicios', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Seguimiento de Operaciones' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Seguimiento de Operaciones', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Buscar Transporte' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Buscar Transporte', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Registar Choferes' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Registar Choferes', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Registrar Unidades y/o Complementos' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Registrar Unidades y/o Complementos', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Solicitar SCTR' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Solicitar SCTR', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Tramites DPW' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Tramites DPW', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.OPTIONS WHERE Title = 'Tramites APM' AND OptionParentId = @parentOptionID AND OptionLevel = 2)
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.OPTIONS (OptionId, Title, Icon, Url, OptionOrder, OptionLevel, OptionParentId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Tramites APM', NULL, '/', @maxOrderNum, 2, @parentOptionID, 'SYSTEM', GETUTCDATE())
END
-------------------------------------------------------------------------------------------------------------------
GO


SELECT * FROM SCT.OPTIONS
--TRUNCATE TABLE SCT.OPTIONS
