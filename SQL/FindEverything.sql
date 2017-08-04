/*
	NOTE:
			- You don't need to use the % for your input. Just what you want to search for.
			- You can turn off certain search functions by changing their variable char to N
			- Values that aren't Y or N will default to N
*/

/*			  INPUT					*/
--------------------------------------
USE Windward_Government
DECLARE @search VARCHAR(100) = 'claim' 

DECLARE @columns CHAR(1) = 'Y'
DECLARE @tables  CHAR(1) = 'Y'
DECLARE @views   CHAR(1) = 'Y'
DECLARE @objects CHAR(1) = 'Y'
--------------------------------------


-- Default Value Declaring 
DECLARE @like VARCHAR(102) = '%' + @search + '%'

IF @columns <> 'Y' AND @columns <> 'N' 
SELECT @columns = 'N'

IF @tables <> 'Y' AND @tables <> 'N' 
SELECT @tables = 'N'

IF @views <> 'Y' AND @tables <> 'N' 
SELECT @views = 'N'

IF @objects <> 'Y' AND @objects <> 'N' 
SELECT @objects = 'N'


--Searching for COLUMNS
IF @columns = 'Y' 
SELECT	'Columns' AS [Search],
        s.name AS [Schema], 
        t.name AS [Table Name], 
        c.name AS [Column Name] 
FROM sys.tables t 
INNER JOIN sys.columns c ON T.OBJECT_ID = C.OBJECT_ID 
INNER JOIN sys.schemas s ON T.[schema_id] = S.[schema_id] 
WHERE C.name LIKE @like 
ORDER BY [Schema],[Table Name];

--Searching for TABLES
IF @tables = 'Y' 
SELECT  'Tables' AS [Search],
        s.name AS [Schema], 
        t.name AS [Table Name],
		t.create_date AS [Created Date],
		t.modify_date AS [Last Modified]
FROM   sys.tables AS t 
INNER JOIN sys.schemas s ON T.[schema_id] = S.[schema_id]
WHERE t.name LIKE @like 
ORDER BY [Schema],[Table Name];

--Searching for VIEWS
IF @views = 'Y'
SELECT 'Views' AS [Search],
		s.name AS [Schema],
		v.name AS [View Name],
		v.create_date AS [Created Date],
		v.modify_date AS [Last Modified]
FROM sys.Views AS V
INNER JOIN sys.schemas S ON V.[schema_id] = S.[schema_id]
WHERE v.name LIKE @like
ORDER BY [Schema],[View Name];

--Searching For OBJECTS
IF @objects = 'Y' 
SELECT  'Objects' AS [Search],
		s.name AS [Schema],
		o.name AS [Proc Name],
		o.type AS [Type Abbreviation],
		CASE 
			WHEN o.type = 'P' THEN 'Stored Procedure'
			WHEN o.type = 'AF' THEN 'Aggregated Function'
			WHEN o.type = 'PK' THEN 'Primary Key Constraint'
			WHEN o.type = 'F' THEN 'Foreign Key Constraint'
			WHEN o.type = 'FN' THEN 'SQL Scalar Function'
		END AS [Object Type],
		o.create_date AS [Created Date],
		o.modify_date AS [Last Modified]
FROM sys.objects AS o
INNER JOIN sys.schemas S ON O.[schema_id] = S.[schema_id] 
WHERE o.type IN ('P', 'AF', 'F', 'FN', 'PK')
AND o.name LIKE @like
ORDER BY [Type Abbreviation],[Schema],[Proc Name];


