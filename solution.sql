USE FourthWallAcademy;

-- =====================================
-- View: StudentPowerView
-- =====================================

DROP VIEW IF EXISTS StudentPowerView;

CREATE VIEW StudentPowerView AS
SELECT
    s.StudentID,
    s.FirstName,
    s.LastName,
    s.Alias,
    p.PowerID,
    p.PowerName,
    sp.Rating
FROM Student s
INNER JOIN StudentPower sp
    ON s.StudentID = sp.StudentID
INNER JOIN Power p
    ON sp.PowerID = p.PowerID;

-- =====================================
-- Function: GetAveragePowerRating
-- =====================================

DROP FUNCTION IF EXISTS GetAveragePowerRating;

DELIMITER $$

CREATE FUNCTION GetAveragePowerRating
(
    pStudentID INT
)
RETURNS DECIMAL(5,2)
DETERMINISTIC
BEGIN
    DECLARE AvgRating DECIMAL(5,2);

    SELECT AVG(Rating)
    INTO AvgRating
    FROM StudentPower
    WHERE StudentID = pStudentID;

    RETURN AvgRating;
END $$

DELIMITER ;

-- =====================================
-- Stored Procedure: AddStudentWithPowers
-- =====================================

DROP PROCEDURE IF EXISTS AddStudentWithPowers;

DELIMITER $$

CREATE PROCEDURE AddStudentWithPowers
(
    IN pFirstName VARCHAR(25),
    IN pLastName VARCHAR(25),
    IN pAlias VARCHAR(50),
    IN pDoB DATE,
    IN pPowerID1 INT,
    IN pRating1 TINYINT,
    IN pPowerID2 INT,
    IN pRating2 TINYINT
)
BEGIN

    DECLARE NewStudentID INT;

    INSERT INTO Student
    (
        FirstName,
        LastName,
        Alias,
        DoB
    )
    VALUES
    (
        pFirstName,
        pLastName,
        pAlias,
        pDoB
    );

    SET NewStudentID = LAST_INSERT_ID();

    INSERT INTO StudentPower
    (
        StudentID,
        PowerID,
        Rating
    )
    VALUES
    (
        NewStudentID,
        pPowerID1,
        pRating1
    );

    INSERT INTO StudentPower
    (
        StudentID,
        PowerID,
        Rating
    )
    VALUES
    (
        NewStudentID,
        pPowerID2,
        pRating2
    );

END $$

DELIMITER ;