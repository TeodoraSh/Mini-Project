SELECT TOP (1000) [firstName]
      ,[lastName]
      ,[email]
      ,[timeSlot]
  FROM [store].[dbo].[booking]

   ALTER TABLE booking DROP COLUMN timeSlot;