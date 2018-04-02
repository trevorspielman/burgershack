-- -- Create table in DB
-- CREATE TABLE burgers(
--   id int NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL,
--   description VARCHAR(255),
--   price DOUBLE(40, 2) NOT NULL,
--   kcal int,
--   PRIMARY KEY (id)
-- );

-- -- Add item to DB-table
-- INSERT INTO burgers (
--   name,
--   description,
--   price,
--   kcal
-- ) VALUES (
--   "Big Mac",
--   "McDonalds Signature Burger",
--   15.99,
--   2000000
-- );

-- -- get from DB-table
-- SELECT * FROM burgers;

-- -- edit record
-- UPDATE burgers SET
-- name = "Small Bun Burger"
-- WHERE name = "The Big Bun Burger";

-- -- Remove Record
-- DELETE FROM burgers WHERE id = 1;