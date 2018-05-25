-- MySQL Script generated by MySQL Workbench
-- 05/24/18 21:13:05
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema docitaBD
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema docitaBD
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `docitaBD` DEFAULT CHARACTER SET utf8 ;
USE `docitaBD` ;

-- -----------------------------------------------------
-- Table `docitaBD`.`unidade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`unidade` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`produtos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idUnidade` INT NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `marca` VARCHAR(50) NOT NULL,
  `precoCusto` FLOAT NOT NULL,
  `quantidade` FLOAT NOT NULL,
  `quantidadeMax` FLOAT NOT NULL,
  `quantidadeMin` FLOAT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `unidade`
    FOREIGN KEY (`idUnidade`)
    REFERENCES `docitaBD`.`unidade` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`fornecedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`fornecedores` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `nomeFantasia` VARCHAR(100) NOT NULL,
  `cnpj` VARCHAR(14) NOT NULL,
  `inscEstadual` VARCHAR(9) NOT NULL,
  `responsavel` VARCHAR(50) NOT NULL,
  `celularResp` VARCHAR(14) NOT NULL,
  `rua` VARCHAR(100) NOT NULL,
  `numero` INT NOT NULL,
  `bairro` VARCHAR(100) NOT NULL,
  `cidade` VARCHAR(100) NOT NULL,
  `uf` VARCHAR(2) NOT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `site` VARCHAR(200) NOT NULL,
  `email` VARCHAR(120) NOT NULL,
  `telefone` VARCHAR(14) NOT NULL,
  `fax` VARCHAR(14) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`entradaProdutos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`entradaProdutos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idProduto` INT NOT NULL,
  `idFornecedor` INT NOT NULL,
  `qtdEntrada` FLOAT NOT NULL,
  `dataFabric` DATE NOT NULL,
  `dataValid` DATE NOT NULL,
  `dataEntrada` DATE NOT NULL,
  `diasParaVenc` INT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `entradaProdutos`
    FOREIGN KEY (`idProduto`)
    REFERENCES `docitaBD`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fornecedores`
    FOREIGN KEY (`idFornecedor`)
    REFERENCES `docitaBD`.`fornecedores` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`saidaProdutos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`saidaProdutos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idProduto` INT NOT NULL,
  `qtdSaida` FLOAT NOT NULL,
  `dataSaida` DATE NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `saidaProdutos`
    FOREIGN KEY (`idProduto`)
    REFERENCES `docitaBD`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`login`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`login` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `senha` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`receitas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`receitas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nomeReceita` VARCHAR(80) NOT NULL,
  `modoPreparo` MEDIUMTEXT NOT NULL,
  `imgProduto` LONGBLOB NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`ingredientesReceitas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`ingredientesReceitas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idProduto` INT NOT NULL,
  `idReceita` INT NOT NULL,
  `quantidade` FLOAT NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `produtos`
    FOREIGN KEY (`idProduto`)
    REFERENCES `docitaBD`.`produtos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `receitas`
    FOREIGN KEY (`idReceita`)
    REFERENCES `docitaBD`.`receitas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `docitaBD`.`saidaReceitas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `docitaBD`.`saidaReceitas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `idIngrediente` INT NOT NULL,
  `qtdReceita` FLOAT NOT NULL,
  `dataSaida` DATE NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `ingredientesReceitas`
    FOREIGN KEY (`idIngrediente`)
    REFERENCES `docitaBD`.`ingredientesReceitas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;