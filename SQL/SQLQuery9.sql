INSERT INTO petTable (petId ,petNAME ,petAge )
VALUES (246,'Rover',12);
INSERT INTO petTable (petId ,petNAME ,petAge )
VALUES (298,'Spot',2);
INSERT INTO petTable (petId ,petNAME ,petAge )
VALUES (341,'Morris',4);
INSERT INTO petTable (petId ,petNAME ,petAge )
VALUES (519,'Tweedy',2);

INSERT INTO petDetails (petId ,petType ,OWNERID )
VALUES (246,'Dog',1);
INSERT INTO petDetails (petId ,petType ,OWNERID )
VALUES (298,'Dog',2);
INSERT INTO petDetails (petId ,petType ,OWNERID )
VALUES (341,'Cat',1);
INSERT INTO petDetails (petId ,petType ,OWNERID )
VALUES (519,'Bird',2);

INSERT INTO petMed (petId ,visited ,procpet )
VALUES (246,'13-JAN-02','Rabies Vaccination');
INSERT INTO petMed (petId ,visited ,procpet )
VALUES (246,'27-MAR-02','Examine and treat');

INSERT INTO petMed (petId ,visited ,procpet )
VALUES (298,'21-JAN-02','Tetanus');
INSERT INTO petMed (petId ,visited ,procpet )
VALUES (298,'10-MAR-2002','Heart Worm Test');

INSERT INTO petMed (petId ,visited ,procpet )
VALUES (341,'23-JAN-2002','Rabies Vaccination');
INSERT INTO petMed (petId ,visited ,procpet )
VALUES (341,'13-JAN-2002','Rabies Vaccination');

INSERT INTO petMed (petId ,visited ,procpet )
VALUES (519,'30-APR-2002','Annual check up');
INSERT INTO petMed (petId ,visited ,procpet )
VALUES (519,'30-APR-2002','Eye Wash');

UPDATE petDetails
SET petType = 'Doggo'
WHERE petId = '246';

SELECT DISTINCT *
FROM petDetails;

ALTER TABLE petDetails
ALTER COLUMN   petId int NOT NULL;