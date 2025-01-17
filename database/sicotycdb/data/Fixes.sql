USE SicotycDB
GO

/***************************************************************************************************************
*	File			:	Fixes.sql
*	Author			:	Jose Rodriguez A.
*	Creation Date	:	June 26, 2024
*	Description		:	Script to Fix data or strcuture in SQL DataBase using T-Sql script
****************************************************************************************************************/

-- Fix FirstName column in Driver Table
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='SCT' AND TABLE_NAME='DRIVER' AND COLUMN_NAME='FirsName')
BEGIN
	--PRINT 'EXIST COLUMN'
	EXEC sp_rename 'SCT.DRIVER.FirsName', 'FirstName', 'COLUMN';
END


-- Fix AntecedentesPolicialesExpiration column in Driver Table
IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='SCT' AND TABLE_NAME='DRIVER' AND COLUMN_NAME='AntecedentePolicialesExpiration')
BEGIN
	--PRINT 'EXIST COLUMN'
	EXEC sp_rename 'SCT.DRIVER.AntecedentePolicialesExpiration', 'AntecedentesPolicialesExpiration', 'COLUMN';
END

IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='SCT' AND TABLE_NAME='UNIT_TRANSPORT' AND COLUMN_NAME='AdditinalNotes')
BEGIN
	--PRINT 'EXIST COLUMN'
	EXEC sp_rename 'SCT.UNIT_TRANSPORT.AdditinalNotes', 'AdditionalNotes', 'COLUMN';	
END

IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='SCT' AND TABLE_NAME='UNIT_TRANSPORT' AND COLUMN_NAME='ModelYear' AND DATA_TYPE = 'Datetime2')
BEGIN
	ALTER TABLE SCT.UNIT_TRANSPORT
	ALTER COLUMN ModelYear NVARCHAR(10)
END

IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='SCT' AND TABLE_NAME='UNIT_TRANSPORT' AND COLUMN_NAME='FabricationYear' AND DATA_TYPE = 'Datetime2')
BEGIN
	ALTER TABLE SCT.UNIT_TRANSPORT
	ALTER COLUMN FabricationYear NVARCHAR(10)
END

-- Fix CompanyType Table
CREATE TABLE #TBL_COMPANY_TYPE (
	RUC NVARCHAR(20),
	TypeOfCompany NVARCHAR(5)
)

DELETE FROM SCT.COMPANY_TYPE

INSERT INTO #TBL_COMPANY_TYPE (RUC, TypeOfCompany)
SELECT RUC, 'OT' FROM SCT.COMPANY


INSERT INTO SCT.COMPANY_TYPE (RUC, TypeOfCompany)
SELECT RUC, TypeOfCompany FROM #TBL_COMPANY_TYPE

DROP TABLE #TBL_COMPANY_TYPE
