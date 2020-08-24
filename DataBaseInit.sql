CREATE DATABASE ANTIQUEStoreDb;

USE ANTIQUEStoreDb;

CREATE TABLE Items(
Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
Name VARCHAR(50) NOT NULL,
Description VARCHAR(300),
Price DOUBLE,
Year VARCHAR(30),
IsDeleted BOOLEAN
);

INSERT INTO Items (Name, Description, Price, Year, IsDeleted) values
    ("Ru Guanyao Brush Washer Bowl", "A little dish like this used for washing small brushes might not look like much, but it set a world record for Chinese porcelain in 2017.", 37680000, "900 a.C", 0),
    ("Record-Breaking Persian Rug", "With a pre-auction estimate of $5 to $7 million, this antique rug far exceeded sale expectations.", 33760000, "300 a.C", 0),
    ("Patek Philippe Supercomplication Pocket Watch", "This rare pocket watch made by Patek Philippe in 1932 broke its own world record. Known as the Henry Graves Jr.", 24000000, "1999 d.C", 0),
    ("Elizabeth Taylor's La Peregrina Pearl Necklace", "It was made by Cartier, a name known for producing some of the world's finest and most coveted jewelry.", 11842000, "1969 d.C", 0);