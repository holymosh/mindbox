SELECT p.Name,c.Name FROM Product p 
JOIN ProductToCategory ptc on p.ID = ptc.ProdId 
left JOIN Category c on ptc.CatId = c.ID
