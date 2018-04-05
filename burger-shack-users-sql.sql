-- CREATE TABLE users (
--   id VARCHAR(255) NOT NULL,
--   name VARCHAR(255) NOT NULL,
--   email VARCHAR(255) NOT NULL,
--   password VARCHAR(255) NOT NULL,
--   PRIMARY KEY (id),
--   UNIQUE KEY email (email)
-- )


-- CREATE TABLE orders (
--   id VARCHAR(255) NOT NULL,
--   userId VARCHAR(255) NOT NULL,
--   price DOUBLE (40, 2) NOT NULL,
--   INDEX userId (userId),
--   FOREIGN KEY (userId)
--     REFERENCES users(id)
--     -- Not needed here, but this would delete anything attached. Similar to schema post Delete
--     ON DELETE CASCADE,
--   PRIMARY KEY (id)
-- )

-- CREATE TABLE orderburgers (
--   id VARCHAR(255) NOT NULL,
--   orderId VARCHAR(255) NOT NULL,
--   burgerId int NOT NULL,
--   userId VARCHAR(255) NOT NULL,
--   quantity int NOT NULL,

--   PRIMARY KEY (id),
--   INDEX (orderId, burgerId),
--   INDEX (userId),

--   FOREIGN KEY (userId)
--     REFERENCES users(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (orderId)
--     REFERENCES orders(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (burgerId)
--     REFERENCES burgers(id)
--     ON DELETE CASCADE
-- )

-- INSERT INTO orders (
--   id,
--   userId,
--   price
-- ) VALUES (
--   "004",
--   "81f9031c-a555-45f6-bfac-5a4f9aeed8d3",
--   33.99
-- );


-- INSERT INTO orderburgers (
--   id,
--   userId,
--   orderId,
--   burgerId,
--   quantity
-- ) VALUES (
--   "600",
--   "81f9031c-a555-45f6-bfac-5a4f9aeed8d3",
--   "004",
--   1,
--   3
-- );

-- SELECT * FROM orderburgers
-- JOIN users ON users.id = orderburgers.userId
-- WHERE userId = "81f9031c-a555-45f6-bfac-5a4f9aeed8d3";

