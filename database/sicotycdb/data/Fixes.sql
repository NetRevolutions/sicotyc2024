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

--SELECT * FROM SCT.DRIVER