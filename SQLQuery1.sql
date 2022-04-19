/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Jméno]
      ,[Příjmení]
      ,[RokNarození]
      ,[Ročník]
  FROM [names1].[dbo].[Table1]

  DELETE FROM [names1].[dbo].[Table1]	