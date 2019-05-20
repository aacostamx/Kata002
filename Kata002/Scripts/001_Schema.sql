CREATE TABLE Posts (
    ID INT PRIMARY KEY,
    Title varchar(40),
    Body varchar(255)
);

CREATE TABLE Comments (
	ID INT PRIMARY KEY,
	PostID INT FOREIGN KEY REFERENCES Posts(ID),
	Body varchar(255)
)