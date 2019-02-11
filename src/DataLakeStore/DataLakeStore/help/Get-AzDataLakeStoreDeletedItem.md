﻿---
external help file: Microsoft.Azure.PowerShell.Cmdlets.DataLakeStore.dll-Help.xml
Module Name: Az.DataLakeStore
ms.assetid: ECA70C6C-E0B0-445D-BCAD-041625FAC632
online version: https://docs.microsoft.com/en-us/powershell/module/az.datalakestore/get-azdatalakestoredeleteditem
schema: 2.0.0
---

# Get-AzDataLakeStoreDeletedItem

## SYNOPSIS
Searches for deleted entries in trash which match the filter.

## SYNTAX

```
Get-AzDataLakeStoreDeletedItem [-Account] <String> [-Filter] <String> [-Count] <UInt32> [-AsJob]
```

## DESCRIPTION
The **Get-AzDataLakeStoreDeletedItem** cmdlet searches the deleted file or folder in Data Lake Store which match the given filter.
Displays the following attributes of the deleted items - OriginalPath, TrashDirPath, Type, CreationTime.
This could be a long running operation as it may have to search through millions of files in trash and could be run as a job.

## EXAMPLES

### Example: Get details of a file from the Data Lake Store
```
PS> Get-AzDataLakeStoreDeletedItem -Account ml1ptrashtest -Filter test0/file_123

TrashDirPath                                                                                                                      OriginalPath                                          Type CreationTime
------------                                                                                                                      ------------                                          ---- ------------
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_0a7b9a4a-7dc0-4ddb-aa6c-6d55dca8e770 adl://ml1ptrashtest.azuredatalake.com/test0/file_1230 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_17327024-4718-4950-bde3-beaea76c9aa7 adl://ml1ptrashtest.azuredatalake.com/test0/file_1232 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_2371fbef-a2ac-4db9-b780-9f305ebc8750 adl://ml1ptrashtest.azuredatalake.com/test0/file_1237 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_3f1af771-834f-4ec8-a03a-b41c5e0cc58b adl://ml1ptrashtest.azuredatalake.com/test0/file_123  FILE 2/8/2019 8:12:04 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_4d1017de-610b-437c-9cf8-049d81e18bbd adl://ml1ptrashtest.azuredatalake.com/test0/file_1239 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_7a2d905e-9dcb-464a-9b82-782dfa845613 adl://ml1ptrashtest.azuredatalake.com/test0/file_1234 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_9e6b91d9-3568-4cdd-934c-1f40868fefe2 adl://ml1ptrashtest.azuredatalake.com/test0/file_1231 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_acd6b81f-e534-47ff-a296-95b379d64286 adl://ml1ptrashtest.azuredatalake.com/test0/file_1238 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_bde2cd57-1220-44ce-bfbc-024ca30c0aaf adl://ml1ptrashtest.azuredatalake.com/test0/file_1236 FILE 2/8/2019 8:12:18 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_c15c0329-d670-4ae7-9101-0c9342b188c6 adl://ml1ptrashtest.azuredatalake.com/test0/file_1235 FILE 2/8/2019 8:12:19 AM
adl://ml1ptrashtest.azuredatalake.com/$temp/trash/131940576000000000/me1sch201110222/deleted_fca49a14-0fd8-4d56-a482-edeae3f93846 adl://ml1ptrashtest.azuredatalake.com/test0/file_1233 FILE 2/8/2019 8:12:18 AM
```

## PARAMETERS

### -Account
Specifies the name of the Data Lake Store account.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: AccountName

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Filter
Specifies the search query. A more specific value gives more relevant results.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: 

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Count
Specifies the number of results the user wants to find. The query runs until it finds Count results or it searches through entire trash, whichever happens first.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: 

Required: False
Position:
Default value: 1
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```
### -AsJob
Run cmdlet in the background.

Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False

## INPUTS

### System.String

## OUTPUTS

### System.Collections.Generic.List<Microsoft.Azure.Commands.DataLakeStore.Models.DataLakeStoreDeletedItem>

## NOTES

## RELATED LINKS

[Restore-AzDataLakeStoreDeletedItem](./Restore-AzDataLakeStoreDeletedItem.md)