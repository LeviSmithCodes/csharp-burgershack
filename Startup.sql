-- Backup if connected to server but not db
USE burgershack17;

-- CREATE TABLE burgers(
--   id int NOT NULL AUTO_INCREMENT, 
--   name  VARCHAR(255) NOT NULL,
--   ingredients VARCHAR(255),
--   cost DECIMAL DEFAULT 0,
--   description VARCHAR(255),
--   PRIMARY KEY (id)
-- );

-- Add to table (Create)
  -- INSERT INTO burgers (name, ingredients, cost, description) VALUES ("Impossible Burger", "Impossible Patty Lettuce Extra Pickles Onion Fry Sauce", 12.99, "Delicious and vegitarian");

-- Altering table
-- ALTER TABLE burgers ADD price DECIMAL;
-- ALTER TABLE burgers ALTER COLUMN price DECIMAL DEFAULT 0
ALTER TABLE burgers MODIFY COLUMN cost DECIMAL(5,2)

SELECT *
FROM burgers;

-- WHERE id = 1;

-- Edit
-- UPDATE burgers SET name = "IMPOSSIBLE LEVI" WHERE id = 1;

-- delete
-- DELETE FROM burgers WHERE id = 2;

-- ----------- DANGER ZONEEEEE --------------
-- little bobby tables
-- DELETE FROM burgers -- drops data
-- DROP TABLE burgers -- drops table and data
-- DROP DATABASE 