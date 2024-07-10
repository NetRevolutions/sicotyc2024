USE SicotycDB
GO

/***************************************************************************************************************
*	File			:	Lookups.sql
*	Author			:	Jose Rodriguez A.
*	Creation Date	:	June 23, 2024
*	Description		:	Generate the Lookups (LookupCodeGroups and LookupCode) for the System
****************************************************************************************************************/

/*** INSERT OPTIONS FOR LOOKUP CODE GROUPS ***/
IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE PAGO PEAJE')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'TIPO DE PAGO PEAJE', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'ESTADO EMPRESA')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'ESTADO EMPRESA', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CONDICION EMPRESA')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'CONDICION EMPRESA', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE DOC. IDENTIDAD')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'TIPO DE DOC. IDENTIDAD', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CLAIMS PERMITIDOS')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'CLAIMS PERMITIDOS', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE LICENCIA DE CONDUCIR')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'TIPO DE LICENCIA DE CONDUCIR', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CATEGORIA VEHICULOS')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'CATEGORIA VEHICULOS', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE EMPRESA')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'TIPO DE EMPRESA', 'SYSTEM', GETUTCDATE())
GO

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE SERVICIO')
INSERT INTO SCT.LOOKUP_CODE_GROUP (LookupCodeGroupId, LookupCodeGroupName, CreatedBy, CreatedOn)
VALUES (NEWID(), 'TIPO DE SERVICIO', 'SYSTEM', GETUTCDATE())
GO

--=================================================================================================================
/*** INSERT OPTIONS FOR LOOKUP CODE ***/
DECLARE @lookupCodeGroupID UNIQUEIDENTIFIER
DECLARE @maxOrderNum INT

-------------------------------------------------------------------------------------------------------------------
-- TIPO DE PAGO PEAJE options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE PAGO PEAJE'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ByAxis')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ByAxis', 'Por Eje', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ByAxis2')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ByAxis2', 'Por Eje2', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ByAxis3')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ByAxis3', 'Por Eje3', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ByAxis4')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ByAxis4', 'Por Eje4', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ByAxis5')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ByAxis5', 'Por Eje5', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- ESTADO EMPRESA options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'ESTADO EMPRESA'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ACTIVO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ACTIVO', 'Activo', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'OBLIGADO_LLEVAR_CONTABILIDAD')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'OBLIGADO_LLEVAR_CONTABILIDAD', 'Obligado a llevar Contabilidad', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'BAJA_TEMPORAL')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'BAJA_TEMPORAL', 'Baja Temporal', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'BAJA_DEFINITIVA')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'BAJA_DEFINITIVA', 'Baja Definitiva', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'OMISO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'OMISO', 'Omiso', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'OBLIGADO_EMITIR_COMPROBANTE_ELECTRONICO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'OBLIGADO_EMITIR_COMPROBANTE_ELECTRONICO', 'Obligado a emitir comprobantes electronicos', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- CONDICION EMPRESA options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CONDICION EMPRESA'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'HABIDO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'HABIDO', 'Habido', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'NO_HABIDO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'NO_HABIDO', 'No Habido', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- TIPO DE DOC. IDENTIDAD options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE DOC. IDENTIDAD'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'DNI')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'DNI', 'Documento Nacional de Identidad', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'CEX')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'CEX', 'Carnet de Extranjería', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'PASS')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'PASS', 'Pasaporte', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'CPP')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'CPP', 'Carnet Temporal de Permanencia', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'PNAC')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'PNAC', 'Partida de Nacimiento', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'PASSD')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'PASSD', 'Pasaporte Diplomatico', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- CLAIMS PERMITIDOS options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CLAIMS PERMITIDOS'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'UserName')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'UserName', 'USERNAME', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'FirstName')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'FirstName', 'FIRSTNAME', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'LastName')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'LastName', 'LASTNAME', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'Email')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Email', 'EMAIL', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'Id')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Id', 'ID', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'PhoneNumber')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'PhoneNumber', 'PHONENUMBER', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'Role')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Role', 'ROLE', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'Img')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'Img', 'IMG', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- TIPO DE LICENCIA DE CONDUCIR options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE LICENCIA DE CONDUCIR'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A1')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A1', 'A-I', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A2A')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A2A', 'A-IIa', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A2B')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A2B', 'A-IIb', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A3A')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A3A', 'A-IIIa', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A3B')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A3B', 'A-IIIb', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A3C')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A3C', 'A-IIIc', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'B1')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'B1', 'B-I', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'B2A')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'B2A', 'B-IIa', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'B2B')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'B2B', 'B-IIb', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'B2C')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'B2C', 'B-IIc', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'A4')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'A4', 'A-IV o Especial', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- CATEGORIA VEHICULOS options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'CATEGORIA VEHICULOS'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'L2')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'L2', 'L2 - Tres Ruedas - Hasta 50 cm3 - Vel. Max. 50 km/h', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'L3')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'L3', 'L3 - Dos Ruedas - Mas de 50 cm3 - Vel. Mayor 50 km/h', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'L4')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'L4', 'L4 - Tres Ruedas Asimetricas al Eje Longitudinal', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'L5')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'L5', 'L5 - Tres Ruedas Simetricas al Eje Longitudinal, Peso menor a 1 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'M1')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'M1', 'M1 - Hasta 9 Asientos (Inc. conductor)', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'M2')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'M2', 'M2 - Mas de 9 asientos - PBV Maximo 5 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'M3')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'M3', 'M3 - Mas de 9 asientos - PBV Mayor 5 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'N1')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'N1', 'N1 - De PBV de 3.5 TN o menos', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'N2')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'N2', 'N2 - De PBV mayor a 3.5 TN hasta 12 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'N3')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'N3', 'N3 - De PBV mayor a 12 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'O1')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'O1', 'O1 - Remolques de PBV de 0.75 TN o menos', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'O2')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'O2', 'O2 - Remolques de PBV mayor a 0.75 TN hasta 3.5 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'O3')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'O3', 'O3 - Remolques de PBV mayor a 3.5 TN hasta 10 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'O4')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'O4', 'O4 - Remolques de PBV mayor a 10 TN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SA')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SA', 'SA - Casas Rodantes', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SB')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SB', 'SB - Vehiculos Blindados para el transporte de Valores', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SC')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SC', 'SC - Ambulancias', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SD')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SD', 'SD - Vehiculos Funerarios', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SE')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SE', 'SE - Bomberos', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SF')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SF', 'SF - Vehiculos Celulares', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'SG')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'SG', 'SG - Porta Tropas', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- TIPO DE EMPRESA options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE EMPRESA'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'ET')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'ET', 'Empresa de Transporte', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'OT')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'OT', 'Otros', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

-------------------------------------------------------------------------------------------------------------------
-- TIPO DE SERVICIO options
SELECT @lookupCodeGroupID = LookupCodeGroupId FROM SCT.LOOKUP_CODE_GROUP WHERE LookupCodeGroupName = 'TIPO DE SERVICIO'
SELECT @maxOrderNum = ISNULL(MAX(LookupCodeOrder), 0) FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'IMPO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'IMPO', 'IMPORTACION', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'EXPO')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'EXPO', 'EXPORTACION', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'CSP')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'CSP', 'CARGA SUELTA - PLATAFORMA', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'DV')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'DV', 'DEVOLUCIÓN DE VACÍO', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'TX')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'TX', 'TRACCIÓN', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'CB')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'CB', 'CAMA BAJA', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'IMPOF')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'IMPOF', 'IMPORTACION - FURGON', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'EXPOF')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'EXPOF', 'EXPORTACION - FURGON', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END

IF NOT EXISTS (SELECT * FROM SCT.LOOKUP_CODE WHERE LookupCodeGroupId = @lookupCodeGroupID AND LookupCodeValue = 'CSF')
BEGIN
	SET @maxOrderNum = @maxOrderNum + 1
	INSERT INTO SCT.LOOKUP_CODE (LookupCodeId, LookupCodeValue, LookupCodeName, LookupCodeOrder, LookupCodeGroupId, CreatedBy, CreatedOn)
	VALUES (NEWID(), 'CSF', 'CARGA SUELTA - FURGON', @maxOrderNum, @lookupCodeGroupID, 'SYSTEM', GETUTCDATE())
END