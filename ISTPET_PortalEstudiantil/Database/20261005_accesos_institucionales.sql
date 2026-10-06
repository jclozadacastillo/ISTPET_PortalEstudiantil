-- Ejecutar en la base de datos sigafi_es antes de desplegar el portal actualizado.
-- Se puede ejecutar nuevamente: conserva las columnas y tablas que ya existan.
-- visibleCredenciales es el nombre definitivo. Una antigua columna
-- viableCredenciales se conserva sin modificarla; el portal no la utiliza.

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'ALTER TABLE periodos ADD COLUMN visibleCredenciales TINYINT NULL DEFAULT 0',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'periodos'
      AND COLUMN_NAME = 'visibleCredenciales'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'ALTER TABLE periodos ADD COLUMN fechaLimiteCredenciales DATETIME NULL',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'periodos'
      AND COLUMN_NAME = 'fechaLimiteCredenciales'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'ALTER TABLE alumnos ADD COLUMN claveTemporalEmail VARCHAR(50) NULL',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'alumnos'
      AND COLUMN_NAME = 'claveTemporalEmail'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'ALTER TABLE alumnos ADD COLUMN usuarioEva VARCHAR(100) NULL',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'alumnos'
      AND COLUMN_NAME = 'usuarioEva'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

CREATE TABLE IF NOT EXISTS enlacesChatConduccion (
    idEnlace INT PRIMARY KEY AUTO_INCREMENT,
    idPeriodo VARCHAR(7) NULL,
    idNivel INT NULL,
    idModalidad INT NULL,
    idSeccion INT NULL,
    paralelo VARCHAR(2) NULL,
    enlace VARCHAR(100) NULL,
    activo TINYINT NULL DEFAULT 1,
    fechaRegistro DATETIME NULL DEFAULT CURRENT_TIMESTAMP
);

SET @sql = (
    SELECT IF(
        COUNT(*) = 0,
        'CREATE INDEX IX_enlacesChatConduccion_grupo ON enlacesChatConduccion (idPeriodo, idNivel, idModalidad, idSeccion, paralelo, activo)',
        'SELECT 1'
    )
    FROM INFORMATION_SCHEMA.STATISTICS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'enlacesChatConduccion'
      AND INDEX_NAME = 'IX_enlacesChatConduccion_grupo'
);
PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

-- Configuracion administrativa (ejemplos comentados; reemplazar periodo y fecha).
-- La fecha limite se interpreta en la hora de Ecuador (America/Guayaquil).
-- Solo se muestran las credenciales con visibleCredenciales = 1 y fecha vigente.
-- Una fecha limite NULL no habilita su visualizacion.
-- UPDATE periodos
-- SET visibleCredenciales = 1,
--     fechaLimiteCredenciales = '2026-10-10 23:59:59'
-- WHERE idPeriodo = 'PERIODO';
--
-- Para deshabilitar inmediatamente:
-- UPDATE periodos SET visibleCredenciales = 0 WHERE idPeriodo = 'PERIODO';
