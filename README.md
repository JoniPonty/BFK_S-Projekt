# BFK_S-Projekt

- In db_model findet man das Datenbank model dieses muss auf einen MySql Server geforwarded werden (Anleitung: https://www.youtube.com/watch?v=gEuFBDHnz1w ab Minute 3:39).

- Ich habe hierbei XAMP als MySql Server benutzt. 

- Der Server muss ohne Passwort und auf den localhost konfiguriert sein (Sonst muss der Code dafür angepasst werden).

- Das Forwarden hat bei der Version 5.2 der Workbench Funktioniert. Bei der Version 8.0 nicht mehr. Sonst wurde es bei keiner anderen Version getestet.

- Das Projekt wurde auf der .net 6.0 Version aufgebaut und mit Visual Studio 2022 Programmiert.

- Als Nuget Paket wird nur MySql.Data auf der Version (8.0.32) Benutzt





## Benutzte SQL-Befehle

### Trainer
- Select Befehle
  - SELECT `club`.`club_name`, CONCAT(`trainer`.`trainer_vorname`, ' ',`trainer`.`trainer_nachname`) AS Trainer FROM `mydb`.`club` INNER JOIN `mydb`.`trainer` ON `club`.`Trainer_idTrainer` = `trainer`.`idTrainer`;

  - SELECT `trainer_vorname`, `trainer_nachname` FROM `mydb`.`trainer`;

  - SELECT `idTrainer` FROM `mydb`.`trainer` WHERE concat(`trainer_vorname`, ' ', `trainer_nachname`)='{`name`}'

  - SELECT `idClub` FROM `mydb`.`club` WHERE `club_name`='{`name`}';


  
- Insert Into Befehl
  - INSERT INTO `mydb`.`Club` (`idClub`, `club_name`, `Trainer_idTrainer`) VALUES ({data});



- Update Befehl
  - UPDATE Club SET {`dataClub`}, `Trainer_idTrainer`='{`idNew`}' WHERE `idClub`={`clubId`}; / UPDATE `Club` SET {`dataClub`}, `Trainer_idTrainer`='{`idOld`}' WHERE `idClub`={`clubId`}


 
- Delete Befehl
  - DELETE FROM `club_has_spieler` WHERE `Club_idClub`={`id`}

  - DELETE FROM `Club` WHERE `idClub`={`id`}



### Club
- Select Befehl
  - SELECT `trainer_vorname`, `trainer_nachname`, `trainer_sperre`, `trainer_alter` FROM `mydb`.`trainer`;

  - SELECT `idTrainer` FROM `mydb`.`trainer` WHERE concat(`trainer_vorname`, ' ', `trainer_nachname`)='{`name`}';


- Insert Into
  - INSERT INTO `mydb`.`Trainer` (`idTrainer`, `trainer_vorname`, `trainer_nachname`, `trainer_sperre`, `trainer_alter`) VALUES ({data});


- Update Befehl
  - UPDATE `Trainer` SET {`data`} WHERE `idTrainer`={`id`};


- Delete Befehl
  - DELETE FROM `Trainer` WHERE `idTrainer`={`id`};


### Spieler
- Select Befehl
  - SELECT `spieler`.`spieler_vorname`, `spieler`.`spieler_nachname`, `spieler`.`spieler_sperre`, `spieler`.`spieler_karten`, `club`.`club_name` FROM `mydb`.`spieler` INNER JOIN `mydb`.`club_has_spieler` ON `spieler`.`idSpieler`=`club_has_spieler`.`Spieler_idSpieler` INNER JOIN `mydb`.`club` ON `club_has_spieler`.`club_idClub` = `club`.`idClub`;
  
  - SELECT `idClub` FROM `mydb`.`club` WHERE `club_name`='{`clubData`}';

  - SELECT `idClub` FROM `mydb`.`club` WHERE `club_name`='{`dataClub`}';

  - SELECT `idSpieler` FROM `mydb`.`spieler` WHERE concat(`spieler_vorname`, ' ', `spieler_nachname`)='{`name`}';

  - SELECT club_name FROM mydb.club;


- Insert Into
  - INSERT INTO `mydb`.`Spieler` (`idSpieler`, `spieler_vorname`, `spieler_nachname`, `spieler_sperre`, `spieler_karten`) VALUES ({`spielerData`});


- Update Befehl
  - UPDATE `Spieler` SET {`dataSpieler`} WHERE `idSpieler`={`id`}; UPDATE `Club_has_Spieler` SET `Club_idClub`={`clubId`} WHERE `Spieler_idSpieler`={`id`};

  - UPDATE `Spieler` SET {dataSpieler} WHERE `idSpieler`={`id`};


- Delete Befehl
  - DELETE FROM `club_has_spieler` WHERE `Spieler_idSpieler`={`id`};

  - DELETE FROM `Spieler` WHERE `idSpieler`={`id`};
