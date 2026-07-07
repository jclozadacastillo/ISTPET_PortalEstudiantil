CREATE TABLE IF NOT EXISTS Terminos_Condiciones (
    idTermino INT PRIMARY KEY AUTO_INCREMENT,
    versionTermino VARCHAR(20),
    contenido TEXT,
    fechaPublicacion DATE,
    fechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    archivoHtml VARCHAR(100),
    esVigente TINYINT DEFAULT 1
);

CREATE TABLE IF NOT EXISTS Aceptaciones_Usuarios (
    idAceptacionUsuario INT PRIMARY KEY AUTO_INCREMENT,
    idUsuario VARCHAR(14),
    idTermino INT,
    esAlumno TINYINT DEFAULT 0,
    esDocente TINYINT DEFAULT 0,
    sistema VARCHAR(100),
    fechaRegistro DATETIME DEFAULT CURRENT_TIMESTAMP,
    ipOrigen VARCHAR(50),
    dispositivo VARCHAR(200),
    UNIQUE INDEX UX_Aceptaciones_Usuarios_idUsuario (idUsuario),
    INDEX IX_Aceptaciones_Usuarios_Usuario_Termino (idUsuario, idTermino)
);

CREATE TABLE IF NOT EXISTS Tipos_Apoyo_Financiero (
    idTipoApoyo INT PRIMARY KEY AUTO_INCREMENT,
    nombreApoyo VARCHAR(200),
    esBeca TINYINT DEFAULT 0,
    esAyudaEconomica TINYINT DEFAULT 0,
    activo TINYINT DEFAULT 1
);

CREATE TABLE IF NOT EXISTS Motivos_Becas (
    idMotivo INT PRIMARY KEY AUTO_INCREMENT,
    idTipoApoyo INT,
    motivo VARCHAR(200),
    activo TINYINT DEFAULT 1,
    fechaRegistro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO Terminos_Condiciones
    (versionTermino, contenido, fechaPublicacion, archivoHtml, esVigente)
SELECT
    'DP-2026-001',
    'Directiva institucional de tratamiento de datos personales ISTPET',
    '2026-07-06',
    'directiva-datos-personales-v1.html',
    1
WHERE NOT EXISTS (
    SELECT 1
    FROM Terminos_Condiciones
    WHERE versionTermino = 'DP-2026-001'
);

UPDATE Terminos_Condiciones
SET contenido = 'Directiva institucional de tratamiento de datos personales ISTPET',
    archivoHtml = 'directiva-datos-personales-v1.html',
    esVigente = 1
WHERE versionTermino = 'DP-2026-001';
