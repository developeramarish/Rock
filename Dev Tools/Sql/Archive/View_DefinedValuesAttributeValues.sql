/* List each DefinedValue's Attributes' Values */
SELECT 
    [dt].[Name] as [DefinedType.Name],
    [dv].[Value] as [DefinedValue.Name],      
    [a].[Key] [AttributeKey],       
    [a].[Guid] [Attribute.Guid],
    [v].[Value] [AttributeValue.Value],
    [v].[Guid] [AttributeValue.Guid],
    [ft].[Name] [FieldType.Name],       
    [ft].[Guid] [FieldType.Guid]
  FROM [AttributeValue] [v]
  join [Attribute] [a] on [a].[Id] = [v].[AttributeId]
  left join [EntityType] [e] on [e].[Id] = [a].[EntityTypeId]
  join [FieldType] [ft] on [ft].[Id] = [a].[FieldTypeId]
  left join [DefinedValue] [dv] on [dv].[id] = [v].[EntityId]
  left join [DefinedType] [dt] on [dt].[id] = [dv].[DefinedTypeId]
where [e].[Name] = 'Rock.Model.DefinedValue'
order by [dt].[Name], [dv].[Value], [a].[Key]

