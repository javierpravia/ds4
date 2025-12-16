CREATE DATABASE GymProgressTracker;
GO

USE GymProgressTracker;
GO

-- Tabla de Rutinas
CREATE TABLE Rutinas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255)
);
GO

-- Tabla de Ejercicios
CREATE TABLE Ejercicios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    GrupoMuscular NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(255)
);
GO

-- Tabla intermedia de Rutinas y Ejercicios (con orden)
CREATE TABLE RutinaEjercicios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RutinaId INT NOT NULL,
    EjercicioId INT NOT NULL,
    Orden INT NOT NULL,
    CONSTRAINT FK_RutinaEjercicios_Rutina FOREIGN KEY (RutinaId) 
        REFERENCES Rutinas(Id),
    CONSTRAINT FK_RutinaEjercicios_Ejercicio FOREIGN KEY (EjercicioId) 
        REFERENCES Ejercicios(Id)
);
GO

-- Tabla de registros de entrenamientos
CREATE TABLE RegistrosEntrenamiento (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    EjercicioId INT NOT NULL,
    Fecha DATE NOT NULL,
    Peso FLOAT NOT NULL,
    Series INT NOT NULL,
    Repeticiones INT NOT NULL,
    Notas NVARCHAR(255),
    CONSTRAINT FK_RegistrosEntrenamiento_Ejercicio FOREIGN KEY (EjercicioId)
        REFERENCES Ejercicios(Id)
);
GO