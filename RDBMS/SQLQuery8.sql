CREATE TABLE petTable
(petId int,
petNAME VARCHAR(200),
petAge int);

CREATE TABLE petDetails
(petId int,
petType VARCHAR(200),
OWNERID int);

CREATE TABLE petMed
(petId int,
visited date,
procpet VARCHAR(200));