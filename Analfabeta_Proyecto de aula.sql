use master;
go
create database analfabeta;
go
use analfabeta;
go
CREATE TABLE Libros (
    LibroID      INT IDENTITY(1,1) PRIMARY KEY,
    Codigo       VARCHAR(20)  NOT NULL UNIQUE,   -- consulta por código
    Titulo       VARCHAR(200) NOT NULL,          -- consulta por nombre
    Autor        VARCHAR(150) NOT NULL,
    Editorial    VARCHAR(100) NULL,
    AnioPublicacion INT NULL,
    Categoria    VARCHAR(80)  NULL,
    ISBN         VARCHAR(30)  NULL,
    ImagenRuta   VARCHAR(300) NULL,  -- ruta o URL de la imagen portada
    Stock        INT NOT NULL DEFAULT 1,   -- solo 1 ejemplar por libro
    Disponible   BIT NOT NULL DEFAULT 1,
    --FechaRegistro DATETIME NOT NULL DEFAULT GETDATE()
);
GO
create table Usuarios(
 UsuarioID     INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50)  NOT NULL UNIQUE,
    ContrasenaHash VARCHAR(255) NOT NULL,   -- Guardar HASH (BCrypt / SHA256)
	Contrasena VARCHAR(40) NOT NULL,
    Correo        VARCHAR(100) NOT NULL UNIQUE,
    RolID         INT NOT NULL,
    Activo        BIT NOT NULL DEFAULT 1,
    FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
	Rol NVARCHAR(15) NOT NULL
);
GO
create table Profesores(
    ProfesorID  INT IDENTITY(1,1) PRIMARY KEY,
    Cedula      VARCHAR(20)  NOT NULL UNIQUE,
    Nombre      VARCHAR(100) NOT NULL,
    Apellido    VARCHAR(100) NOT NULL,
    Correo      VARCHAR(100) NOT NULL UNIQUE,
    UsuarioID   INT NULL,   -- enlace con control de acceso
    Activo      BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Profesores_Usuarios FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);
GO
create table Estudiantes(
	EstudianteID INT  PRIMARY KEY,
    Carnet    INT IDENTITY(1,1)  NOT NULL UNIQUE,
    NombreCompleto       VARCHAR(150) NOT NULL,
    Correo       VARCHAR(100) NOT NULL UNIQUE,
    Curso        VARCHAR(50)  NULL,
    UsuarioID    INT NULL,
    Activo       BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Estudiantes_Usuarios FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);
CREATE TABLE Prestamos (
    PrestamoID     INT IDENTITY(1,1) PRIMARY KEY,
    LibroID        INT NOT NULL,
    EstudianteID   INT NULL,     -- puede ser estudiante
    ProfesorID     INT NULL,     -- o profesor (nunca ambos)
    FechaPrestamo  DATETIME NOT NULL DEFAULT GETDATE(),
    FechaDevolucionEsperada DATETIME NOT NULL,
    FechaDevolucionReal     DATETIME NULL,
    Estado         VARCHAR(20) NOT NULL DEFAULT 'Disponible',  -- Prestado, Devuelto, Atrasado
    Observaciones  VARCHAR(300) NULL,
    CONSTRAINT FK_Prestamos_Libros FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),
    CONSTRAINT FK_Prestamos_Estudiantes FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    CONSTRAINT FK_Prestamos_Profesores FOREIGN KEY (ProfesorID) REFERENCES Profesores(ProfesorID),
    CONSTRAINT CHK_Prestamo_Persona CHECK (
        (EstudianteID IS NOT NULL AND ProfesorID IS NULL) OR
        (EstudianteID IS NULL AND ProfesorID IS NOT NULL)
    )
);
GO
USE analfabeta;
GO

-- ============================================
-- 1) USUARIOS
-- ============================================
INSERT INTO Usuarios (NombreUsuario, ContrasenaHash, Contrasena, Correo, RolID, Rol, Activo)
VALUES
('admin',    '', 'Admin123',  'admin@analfabeta.edu',    1, 'Administrador', 1),
('biblio1',  '', 'Biblio123', 'biblio1@analfabeta.edu',  2, 'Bibliotecario', 1),
('biblio2',  '', 'Biblio123', 'biblio2@analfabeta.edu',  2, 'Bibliotecario', 1),
('jperez',   '', 'Profe123',  'jperez@analfabeta.edu',   3, 'Profesor',      1),
('mlopez',   '', 'Profe123',  'mlopez@analfabeta.edu',   3, 'Profesor',      1),
('argarcia', '', 'Profe123',  'argarcia@analfabeta.edu', 3, 'Profesor',      1),
('lcruz',    '', 'Estu1234',  'lcruz@analfabeta.edu',    4, 'Estudiante',    1),
('rmendoza', '', 'Estu1234',  'rmendoza@analfabeta.edu', 4, 'Estudiante',    1),
('sramirez', '', 'Estu1234',  'sramirez@analfabeta.edu', 4, 'Estudiante',    1),
('jtorres',  '', 'Estu1234',  'jtorres@analfabeta.edu',  4, 'Estudiante',    1),
('pvargas',  '', 'Estu1234',  'pvargas@analfabeta.edu',  4, 'Estudiante',    1),
('djimenez', '', 'Estu1234',  'djimenez@analfabeta.edu', 4, 'Estudiante',    1),
('fmorales', '', 'Estu1234',  'fmorales@analfabeta.edu', 4, 'Estudiante',    0);
GO
-- ============================================
-- 2) PROFESORES
-- ============================================
INSERT INTO Profesores (Cedula, Nombre, Apellido, Correo, UsuarioID, Activo)
VALUES
('101110111', 'Juan',   'Pérez',     'jperez@analfabeta.edu',          4,    1),
('202220222', 'María',  'López',     'mlopez@analfabeta.edu',          5,    1),
('303330333', 'Andrés', 'García',    'argarcia@analfabeta.edu',        6,    1),
('404440444', 'Carla',  'Rodríguez', 'carla.rodriguez@analfabeta.edu', NULL, 1),
('505550555', 'Pedro',  'Sánchez',   'pedro.sanchez@analfabeta.edu',   NULL, 0);
GO

-- ============================================
-- 3) ESTUDIANTES
-- ============================================
INSERT INTO Estudiantes (EstudianteID, NombreCompleto, Correo, Curso, UsuarioID, Activo)
VALUES
(1, 'Luis Cruz',        'lcruz@analfabeta.edu',     '10A', 7,    1),
(2, 'Rosa Mendoza',     'rmendoza@analfabeta.edu',  '10A', 8,    1),
(3, 'Sofía Ramírez',    'sramirez@analfabeta.edu',  '10B', 9,    1),
(4, 'Jorge Torres',     'jtorres@analfabeta.edu',   '11A', 10,   1),
(5, 'Paula Vargas',     'pvargas@analfabeta.edu',   '11A', 11,   1),
(6, 'Diego Jiménez',    'djimenez@analfabeta.edu',  '11B', 12,   1),
(7, 'Fernanda Morales', 'fmorales@analfabeta.edu',  '11B', 13,   0),
(8, 'Carlos Rojas',     'crojas@analfabeta.edu',    '9A',  NULL, 1);
GO

-- ============================================
-- 4) LIBROS
-- ============================================
INSERT INTO Libros (Codigo, Titulo, Autor, Editorial, AnioPublicacion, Categoria, ISBN, ImagenRuta, Stock, Disponible)
VALUES
('LIB-001', 'Cien Años de Soledad',             'Gabriel García Márquez',  'Sudamericana',        1967, 'Novela',          '978-84-376-0494-7', '/imgs/lib001.jpg', 1, 1),
('LIB-002', 'Don Quijote de la Mancha',         'Miguel de Cervantes',     'Francisco de Robles', 1605, 'Clásico',         '978-84-376-0495-4', '/imgs/lib002.jpg', 1, 1),
('LIB-003', 'La Casa de los Espíritus',         'Isabel Allende',          'Plaza & Janés',       1982, 'Novela',          '978-84-01-33456-1', '/imgs/lib003.jpg', 1, 1),
('LIB-004', 'El Principito',                    'Antoine de Saint-Exupéry','Reynal & Hitchcock',  1943, 'Infantil',        '978-84-376-0496-1', '/imgs/lib004.jpg', 1, 1),
('LIB-005', '1984',                             'George Orwell',           'Secker & Warburg',    1949, 'Distopía',        '978-84-376-0497-8', '/imgs/lib005.jpg', 1, 1),
('LIB-006', 'Rayuela',                          'Julio Cortázar',          'Sudamericana',        1963, 'Novela',          '978-84-376-0498-5', '/imgs/lib006.jpg', 1, 1),
('LIB-007', 'Ficciones',                        'Jorge Luis Borges',       'Sur',                 1944, 'Cuento',          '978-84-376-0499-2', '/imgs/lib007.jpg', 1, 1),
('LIB-008', 'Pedro Páramo',                     'Juan Rulfo',              'Fondo de Cultura',    1955, 'Novela',          '978-84-376-0500-5', '/imgs/lib008.jpg', 1, 1),
('LIB-009', 'La Ciudad y los Perros',           'Mario Vargas Llosa',      'Seix Barral',         1963, 'Novela',          '978-84-376-0501-2', '/imgs/lib009.jpg', 1, 1),
('LIB-010', 'El Amor en los Tiempos del Cólera','Gabriel García Márquez',  'Oveja Negra',         1985, 'Novela',          '978-84-376-0502-9', '/imgs/lib010.jpg', 1, 1),
('LIB-011', 'Breve Historia del Tiempo',        'Stephen Hawking',         'Bantam Books',        1988, 'Ciencia',         '978-84-376-0503-6', '/imgs/lib011.jpg', 1, 1),
('LIB-012', 'Sapiens',                          'Yuval Noah Harari',       'Debate',              2011, 'Historia',        '978-84-376-0504-3', '/imgs/lib012.jpg', 1, 1),
('LIB-013', 'El Hobbit',                        'J.R.R. Tolkien',          'George Allen',        1937, 'Fantasía',        '978-84-376-0505-0', '/imgs/lib013.jpg', 1, 1),
('LIB-014', 'Harry Potter y la Piedra Filosofal','J.K. Rowling',           'Bloomsbury',          1997, 'Fantasía',        '978-84-376-0506-7', '/imgs/lib014.jpg', 1, 1),
('LIB-015', 'Los Juegos del Hambre',            'Suzanne Collins',         'Scholastic',          2008, 'Juvenil',         '978-84-376-0507-4', '/imgs/lib015.jpg', 1, 1),
('LIB-016', 'Matar a un Ruiseñor',              'Harper Lee',              'J.B. Lippincott',     1960, 'Novela',          '978-84-376-0508-1', '/imgs/lib016.jpg', 1, 1),
('LIB-017', 'Orgullo y Prejuicio',              'Jane Austen',             'T. Egerton',          1813, 'Romance',         '978-84-376-0509-8', '/imgs/lib017.jpg', 1, 1),
('LIB-018', 'Frankenstein',                     'Mary Shelley',            'Lackington',          1818, 'Terror',          '978-84-376-0510-4', '/imgs/lib018.jpg', 1, 1),
('LIB-019', 'Drácula',                          'Bram Stoker',             'Archibald',           1897, 'Terror',          '978-84-376-0511-1', '/imgs/lib019.jpg', 1, 1),
('LIB-020', 'Neuromante',                       'William Gibson',          'Ace Books',           1984, 'Ciencia Ficción', '978-84-376-0512-8', '/imgs/lib020.jpg', 1, 1);
GO

-- ============================================
-- 5) PRÉSTAMOS
-- ============================================
INSERT INTO Prestamos (LibroID, EstudianteID, ProfesorID, FechaPrestamo, FechaDevolucionEsperada, FechaDevolucionReal, Estado, Observaciones)
VALUES
(5,  1,    NULL, DATEADD(DAY, -5,  GETDATE()), DATEADD(DAY, 10,  GETDATE()), NULL,                          'Prestado',  'Entrega en buen estado'),
(10, NULL, 1,    DATEADD(DAY, -3,  GETDATE()), DATEADD(DAY, 12,  GETDATE()), NULL,                          'Prestado',  NULL),
(3,  2,    NULL, DATEADD(DAY, -30, GETDATE()), DATEADD(DAY, -15, GETDATE()), DATEADD(DAY, -16, GETDATE()), 'Devuelto',  'Devuelto con 1 día de anticipación'),
(7,  NULL, 2,    DATEADD(DAY, -45, GETDATE()), DATEADD(DAY, -30, GETDATE()), DATEADD(DAY, -30, GETDATE()), 'Devuelto',  NULL),
(13, 3,    NULL, DATEADD(DAY, -20, GETDATE()), DATEADD(DAY, -5,  GETDATE()), NULL,                          'Atrasado',  'Se le notificó por correo'),
(14, 4,    NULL, DATEADD(DAY, -2,  GETDATE()), DATEADD(DAY, 13,  GETDATE()), NULL,                          'Prestado',  NULL),
(18, NULL, 3,    DATEADD(DAY, -7,  GETDATE()), DATEADD(DAY, 8,   GETDATE()), NULL,                          'Prestado',  'Profesor de Literatura'),
(1,  5,    NULL, DATEADD(DAY, -60, GETDATE()), DATEADD(DAY, -45, GETDATE()), DATEADD(DAY, -44, GETDATE()), 'Devuelto',  NULL),
(20, 6,    NULL, DATEADD(DAY, -25, GETDATE()), DATEADD(DAY, -10, GETDATE()), NULL,                          'Atrasado',  'Segundo aviso enviado'),
(9,  8,    NULL, DATEADD(DAY, -1,  GETDATE()), DATEADD(DAY, 14,  GETDATE()), NULL,                          'Prestado',  NULL);
GO

-- ============================================
-- 6) ACTUALIZAR DISPONIBILIDAD
-- ============================================
UPDATE Libros
SET Disponible = 0
WHERE LibroID IN (
    SELECT LibroID FROM Prestamos
    WHERE Estado IN ('Prestado', 'Atrasado') AND FechaDevolucionReal IS NULL
);
GO

-- ============================================
-- 7) VERIFICACIÓN
-- ============================================
SELECT 'Usuarios' AS Tabla, COUNT(*) AS Total FROM Usuarios
UNION ALL SELECT 'Profesores',  COUNT(*) FROM Profesores
UNION ALL SELECT 'Estudiantes', COUNT(*) FROM Estudiantes
UNION ALL SELECT 'Libros',      COUNT(*) FROM Libros
UNION ALL SELECT 'Prestamos',   COUNT(*) FROM Prestamos;
GO

SELECT LibroID, Codigo, Titulo, Disponible
FROM Libros WHERE Disponible = 0;
GO
update Libros set ImagenRuta='100_anos_soledad.jpeg' where LibroID=1;