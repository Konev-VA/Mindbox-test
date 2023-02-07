SELECT p.ProductName, c.CategoryName FROM Products AS p
LEFT JOIN ProductsCategoriesLinks AS pcl ON pcl.ProductId = p.ProductId
LEFT JOIN Categories AS c ON c.CategoryId = pcl.CategoryId