select 'public ' + a.Csharp + ' ' + b.COLUMN_NAME + ' { get; set; }'
from _TypesConvert a left join INFORMATION_SCHEMA.COLUMNS b on a.[Sql] = b.DATA_TYPE
Where B.TABLE_NAME = 'Status'