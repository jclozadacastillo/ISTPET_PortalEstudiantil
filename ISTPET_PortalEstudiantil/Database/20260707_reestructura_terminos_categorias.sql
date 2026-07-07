CREATE TABLE IF NOT EXISTS Categorias_Terminos_Condiciones (
    idCategoria INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(50),
    esAlumno TINYINT DEFAULT 0,
    esDocente TINYINT DEFAULT 0,
    esAdministrativo TINYINT DEFAULT 0,
    esExterno TINYINT DEFAULT 0,
    fechaRegistro DATE,
    activo TINYINT DEFAULT 1
);

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'ALTER TABLE Terminos_Condiciones ADD COLUMN idCategoria INT NULL AFTER idTermino',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'Terminos_Condiciones'
      AND COLUMN_NAME = 'idCategoria'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET @sql = (
    SELECT IF(
        COUNT(*) > 0,
        'ALTER TABLE Aceptaciones_Usuarios DROP COLUMN esAlumno',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'Aceptaciones_Usuarios'
      AND COLUMN_NAME = 'esAlumno'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET @sql = (
    SELECT IF(
        COUNT(*) > 0,
        'ALTER TABLE Aceptaciones_Usuarios DROP COLUMN esDocente',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'Aceptaciones_Usuarios'
      AND COLUMN_NAME = 'esDocente'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

INSERT INTO Categorias_Terminos_Condiciones
    (categoria, esAlumno, esDocente, esAdministrativo, esExterno, fechaRegistro, activo)
SELECT
    'Alumno',
    1,
    0,
    0,
    0,
    CURDATE(),
    1
WHERE NOT EXISTS (
    SELECT 1
    FROM Categorias_Terminos_Condiciones
    WHERE categoria = 'Alumno'
);

UPDATE Categorias_Terminos_Condiciones
SET esAlumno = 1,
    esDocente = 0,
    esAdministrativo = 0,
    esExterno = 0,
    activo = 1
WHERE categoria = 'Alumno';

INSERT INTO Terminos_Condiciones
    (idCategoria, versionTermino, contenido, fechaPublicacion, archivoHtml, esVigente)
SELECT
    idCategoria,
    'DP-2026-001',
    'Directiva institucional de tratamiento de datos personales ISTPET',
    '2026-07-06',
    'directiva-datos-personales-v1.html',
    1
FROM Categorias_Terminos_Condiciones
WHERE categoria = 'Alumno'
AND NOT EXISTS (
    SELECT 1
    FROM Terminos_Condiciones
    WHERE versionTermino = 'DP-2026-001'
);

UPDATE Terminos_Condiciones t
INNER JOIN Categorias_Terminos_Condiciones c ON c.categoria = 'Alumno'
SET t.idCategoria = c.idCategoria,
    t.contenido = 'Directiva institucional de tratamiento de datos personales ISTPET',
    t.archivoHtml = 'directiva-datos-personales-v1.html',
    t.esVigente = 1
WHERE t.versionTermino = 'DP-2026-001';

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'CREATE INDEX IX_Terminos_Condiciones_idCategoria ON Terminos_Condiciones (idCategoria)',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.STATISTICS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'Terminos_Condiciones'
      AND INDEX_NAME = 'IX_Terminos_Condiciones_idCategoria'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
