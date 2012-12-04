SELECT 
  p.[Name],
  p.[Title],
  p.[Guid],
  parentPage.[Name] as [ParentPage],
  parentPage.[Guid] as [ParentPageGuid]
FROM 
  [Page] p
join [Page] parentPage on p.ParentPageId = parentPage.Id
order by ParentPage.Name


