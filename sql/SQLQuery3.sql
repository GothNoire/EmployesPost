CREATE VIEW Employes_view 
AS
SELECT *, ROW_NUMBER () 
OVER (ORDER BY id ASC) AS row_id
FROM  Employes e

CREATE TRIGGER IUEmployes
ON Employes
AFTER 
INSERT, UPDATE
AS
BEGIN
  UPDATE Employes
  SET DateModified = GETDATE(),
  UserModified = CURRENT_USER
  FROM Employes e
  JOIN inserted i ON e.id = i.id; 
END

CREATE TRIGGER IEmployes
ON Employes
AFTER
INSERT
AS
BEGIN
UPDATE Employes
SET id = NEXT VALUE FOR idEmployes
FROM Employes e
JOIN inserted i ON e.id = i.id; 
END

CREATE TRIGGER IUPost
ON Post
AFTER 
INSERT, UPDATE
AS
BEGIN
  UPDATE Post
  SET DateModified = GETDATE(),
  UserModified = CURRENT_USER
  FROM Post p
  JOIN inserted i ON p.id = i.id; 
END;

CREATE SEQUENCE idPost
  START WITH 1
  INCREMENT BY 1

CREATE SEQUENCE idEmployes
  START WITH 1
  INCREMENT BY 1
