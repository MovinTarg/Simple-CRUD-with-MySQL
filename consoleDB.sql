-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema consoleDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema consoleDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `consoleDB` DEFAULT CHARACTER SET utf8 ;
USE `consoleDB` ;

-- -----------------------------------------------------
-- Table `consoleDB`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `consoleDB`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(255) NULL,
  `last_name` VARCHAR(255) NULL,
  `favorite_number` INT NULL,
  `favorite_color` VARCHAR(255) NULL,
  `favorite_language` VARCHAR(255) NULL,
  `favorite_pizza` VARCHAR(255) NULL,
  `created_at` DATETIME NULL,
  `updated_at` DATETIME NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
