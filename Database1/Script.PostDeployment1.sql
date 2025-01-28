IF NOT EXISTS(SELECT TOP 1 1 FROM [User])
INSERT INTO [User]
(Id, Name) 
VALUES 
(1, 'Alice'), 
(2, 'Bob'),
(3, 'Charlie');