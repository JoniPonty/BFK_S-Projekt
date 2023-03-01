```sql
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;

SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;

SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';



CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;

USE `mydb` ;



-- -----------------------------------------------------

-- Table `mydb`.`Spieler`

-- -----------------------------------------------------

DROP TABLE IF EXISTS `mydb`.`Spieler` ;



CREATE  TABLE IF NOT EXISTS `mydb`.`Spieler` (

  `idSpieler` INT NOT NULL AUTO_INCREMENT ,

  `spieler_vorname` VARCHAR(45) NOT NULL ,

  `spieler_nachname` VARCHAR(45) NOT NULL ,

  `spieler_sperre` TINYINT(1) NOT NULL ,

  `spieler_karten` INT NOT NULL ,

  PRIMARY KEY (`idSpieler`) )

ENGINE = InnoDB;





-- -----------------------------------------------------

-- Table `mydb`.`Trainer`

-- -----------------------------------------------------

DROP TABLE IF EXISTS `mydb`.`Trainer` ;



CREATE  TABLE IF NOT EXISTS `mydb`.`Trainer` (

  `idTrainer` INT NOT NULL AUTO_INCREMENT ,

  `trainer_vorname` VARCHAR(45) NOT NULL ,

  `trainer_nachname` VARCHAR(45) NOT NULL ,

  `trainer_sperre` TINYINT(1) NOT NULL ,

  `trainer_alter` INT NOT NULL ,

  PRIMARY KEY (`idTrainer`) )

ENGINE = InnoDB;





-- -----------------------------------------------------

-- Table `mydb`.`Club`

-- -----------------------------------------------------

DROP TABLE IF EXISTS `mydb`.`Club` ;



CREATE  TABLE IF NOT EXISTS `mydb`.`Club` (

  `idClub` INT NOT NULL AUTO_INCREMENT ,

  `club_name` VARCHAR(45) NULL ,

  `Trainer_idTrainer` INT NOT NULL ,

  PRIMARY KEY (`idClub`) ,

  INDEX `fk_Club_Trainer1_idx` (`Trainer_idTrainer` ASC) ,

  CONSTRAINT `fk_Club_Trainer1`

    FOREIGN KEY (`Trainer_idTrainer` )

    REFERENCES `mydb`.`Trainer` (`idTrainer` )

    ON DELETE NO ACTION

    ON UPDATE NO ACTION)

ENGINE = InnoDB;





-- -----------------------------------------------------

-- Table `mydb`.`Club_has_Spieler`

-- -----------------------------------------------------

DROP TABLE IF EXISTS `mydb`.`Club_has_Spieler` ;



CREATE  TABLE IF NOT EXISTS `mydb`.`Club_has_Spieler` (

  `idChs` INT NOT NULL AUTO_INCREMENT ,

  `Club_idClub` INT NOT NULL ,

  `Spieler_idSpieler` INT NOT NULL ,

  INDEX `fk_Club_has_Spieler_Spieler1_idx` (`Spieler_idSpieler` ASC) ,

  INDEX `fk_Club_has_Spieler_Club_idx` (`Club_idClub` ASC) ,

  PRIMARY KEY (`idChs`) ,

  CONSTRAINT `fk_Club_has_Spieler_Club`

    FOREIGN KEY (`Club_idClub` )

    REFERENCES `mydb`.`Club` (`idClub` )

    ON DELETE NO ACTION

    ON UPDATE NO ACTION,

  CONSTRAINT `fk_Club_has_Spieler_Spieler1`

    FOREIGN KEY (`Spieler_idSpieler` )

    REFERENCES `mydb`.`Spieler` (`idSpieler` )

    ON DELETE NO ACTION

    ON UPDATE NO ACTION)

ENGINE = InnoDB;



USE `mydb` ;





SET SQL_MODE=@OLD_SQL_MODE;

SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;

SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

```
