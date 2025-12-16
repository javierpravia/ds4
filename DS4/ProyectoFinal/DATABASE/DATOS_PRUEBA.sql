-- Selecciona la base de datos
USE GymProgressTracker;
GO

-- Insertar Rutinas
INSERT INTO Rutinas (Nombre, Descripcion) VALUES
('Full Body', 'Rutina de cuerpo completo'),
('Pecho Lunes', 'Ejercicios de pecho para los lunes'),
('Piernas Viernes', 'Rutina de piernas para los viernes');
GO

-- Insertar Ejercicios
INSERT INTO Ejercicios (Nombre, GrupoMuscular, Descripcion) VALUES
('Press Banca', 'Pecho', 'Ejercicio básico para pectoral mayor'),
('Sentadilla', 'Piernas', 'Ejercicio fundamental de pierna'),
('Dominadas', 'Espalda', 'Ejercicio para dorsal ancho'),
('Press Militar', 'Hombros', 'Trabajo primario de hombro'),
('Curl Bíceps', 'Bíceps', 'Ejercicio de aislamiento');
GO

-- Insertar RutinaEjercicios (asociar ejercicios a rutinas con orden)
INSERT INTO RutinaEjercicios (RutinaId, EjercicioId, Orden) VALUES

(1, 1, 1),
(1, 2, 2),
(1, 3, 3), 

(2, 1, 1), 
(2, 4, 2), 

(3, 2, 1),
(3, 5, 2); 
GO

-- Insertar algunos Registros de Entrenamiento
INSERT INTO RegistrosEntrenamiento (EjercicioId, Fecha, Peso, Series, Repeticiones, Notas) VALUES
(1, '2024-12-12', 60, 4, 10, 'Buena sesión'),     
(2, '2024-12-12', 80, 4, 8,  'Costó la última serie'),
(3, '2024-12-13', 0, 3, 8,   'Dominadas asistidas'),
(1, '2024-12-19', 65, 4, 8,  'Aumenté el peso');    
GO