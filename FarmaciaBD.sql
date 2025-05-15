CREATE DATABASE FarmaciaDB;
GO

USE FarmaciaDB;
GO



-- Tabla de Usuarios
CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL,
    Contrase�a VARCHAR(255) NOT NULL,
    Rol VARCHAR(20) NOT NULL
);
GO

-- Tabla de Productos
CREATE TABLE Productos (
    ProductoID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Precio DECIMAL(10,2) NOT NULL,
    CantidadStock INT NOT NULL,
    StockMinimo INT NOT NULL
);
GO

-- Tabla de Ventas
CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioID INT NOT NULL,
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    TotalVenta DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);
GO

-- Tabla de Detalles de Venta
CREATE TABLE DetalleVenta (
    DetalleID INT IDENTITY(1,1) PRIMARY KEY,
    VentaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO

-- Tabla de Proveedores
CREATE TABLE Proveedores (
    ProveedorID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Contacto VARCHAR(100)
);
GO

-- Tabla intermedia: ProveedorProducto
CREATE TABLE ProveedorProducto (
    ProveedorID INT NOT NULL,
    ProductoID INT NOT NULL,
    PRIMARY KEY (ProveedorID, ProductoID),
    FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO

-- SP Insertar Usuario
CREATE PROCEDURE sp_insertarUsuario
	@NombreUsuario VARCHAR(50),
    @Contrase�a VARCHAR(255),
    @Rol VARCHAR(20)
AS
BEGIN
	INSERT INTO Usuarios (NombreUsuario, Contrase�a, Rol) 
	VALUES(@NombreUsuario, @Contrase�a, @Rol)
END
GO


-- SP Actualizar Usuario
CREATE PROCEDURE sp_actualizarUsuario
	@UsuarioID INT,
	@NombreUsuario VARCHAR(50),
    @Contrase�a VARCHAR(255),
    @Rol VARCHAR(20)
AS
BEGIN
	UPDATE Usuarios
	SET NombreUsuario = @NombreUsuario,
		Contrase�a = @Contrase�a,
		Rol = @Rol
	WHERE UsuarioID = @UsuarioID;
END
GO

-- SP Borrar Usuario
CREATE PROCEDURE sp_BorrarUsuario
	@UsuarioID INT
AS
BEGIN
 	DELETE Usuarios WHERE UsuarioID = @UsuarioID;
END
GO

-- SP Consultar Usuario Por Id
CREATE PROCEDURE sp_ConsultarUsuarioPorId
	@UsuarioID INT
AS
BEGIN
	SELECT UsuarioID, NombreUsuario, Contrase�a, Rol FROM Usuarios WHERE UsuarioID = @UsuarioID;
END
GO

-- SP Consultar todos los usuarios

CREATE PROCEDURE sp_ConsultarUsuariosTodos
AS
SELECT UsuarioID, NombreUsuario, Contrase�a, Rol FROM Usuarios;
GO


-- SP Insertar Producto
CREATE PROCEDURE sp_InsertarProducto
    @Nombre VARCHAR(100),
    @Descripcion TEXT,
    @Precio DECIMAL(10,2),
    @CantidadStock INT,
    @StockMinimo INT
AS
BEGIN
    INSERT INTO Productos (Nombre, Descripcion, Precio, CantidadStock, StockMinimo)
    VALUES (@Nombre, @Descripcion, @Precio, @CantidadStock, @StockMinimo);
END
GO

-- SP Actualizar Producto
CREATE PROCEDURE sp_ActualizarProducto
    @ProductoID INT,
    @Nombre VARCHAR(100),
    @Descripcion TEXT,
    @Precio DECIMAL(10,2),
    @CantidadStock INT,
    @StockMinimo INT
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre,
        Descripcion = @Descripcion,
        Precio = @Precio,
        CantidadStock = @CantidadStock,
        StockMinimo = @StockMinimo
    WHERE ProductoID = @ProductoID;
END
GO

-- SP Borrar Producto
CREATE PROCEDURE sp_BorrarProducto
    @ProductoID INT
AS
BEGIN
    DELETE FROM Productos WHERE ProductoID = @ProductoID;
END
GO

-- SP Consultar Producto
CREATE PROCEDURE sp_ConsultarProductos
AS
BEGIN
    SELECT * FROM Productos;
END
GO

-- SP Insertar Proveedor
CREATE PROCEDURE sp_InsertarProveedor
    @Nombre VARCHAR(100),
    @Contacto VARCHAR(100)
AS
BEGIN
    INSERT INTO Proveedores (Nombre, Contacto)
    VALUES (@Nombre, @Contacto);
END
GO

-- SP Actualizar Proveedor
CREATE PROCEDURE sp_ActualizarProveedor
    @ProveedorID INT,
    @Nombre VARCHAR(100),
    @Contacto VARCHAR(100)
AS
BEGIN
    UPDATE Proveedores
    SET Nombre = @Nombre,
        Contacto = @Contacto
    WHERE ProveedorID = @ProveedorID;
END
GO

-- SP Borrar Proveedor
CREATE PROCEDURE sp_BorrarProveedor
    @ProveedorID INT
AS
BEGIN
    DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID;
END
GO

-- SP Consultar Proveedor por id
CREATE PROCEDURE sp_ConsultarProveedorPorId
	@ProveedorID INT
AS
BEGIN
    SELECT  ProveedorID, Nombre, Contacto FROM Proveedores
	WHERE ProveedorID = @ProveedorID;
END
GO

-- SP Consultar Todos los Proveedores
CREATE PROCEDURE sp_ConsultarProveedoresTodos
AS
BEGIN
    SELECT  ProveedorID, Nombre, Contacto FROM Proveedores;
END
GO

-- SP Insertar Ventas
CREATE PROCEDURE sp_InsertarVenta
    @UsuarioID INT,
    @FechaVenta DATETIME,
    @TotalVenta DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Ventas (UsuarioID, FechaVenta, TotalVenta)
    VALUES (@UsuarioID, @FechaVenta, @TotalVenta);
END
GO

-- SP Actualizar Ventas
CREATE PROCEDURE sp_ActualizarVenta
    @VentaID INT,
    @UsuarioID INT,
    @FechaVenta DATETIME,
    @TotalVenta DECIMAL(10,2)
AS
BEGIN
    UPDATE Ventas
    SET UsuarioID = @UsuarioID,
        FechaVenta = @FechaVenta,
        TotalVenta = @TotalVenta
    WHERE VentaID = @VentaID;
END
GO

-- SP Borrar Ventas
CREATE PROCEDURE sp_BorrarVenta
    @VentaID INT
AS
BEGIN
    DELETE FROM Ventas WHERE VentaID = @VentaID;
END
GO

-- SP Consultar Ventas por Id
CREATE PROCEDURE sp_ConsultarVentaPorId
@VentaID INT
AS
BEGIN
    SELECT * FROM Ventas WHERE VentaID = @VentaID;
END
GO

-- SP Consultar todas las Ventas 
CREATE PROCEDURE sp_ConsultarVentasTodas
AS
BEGIN
    SELECT  VentaID, UsuarioID, FechaVenta, TotalVenta  FROM Ventas;
END
GO

--SP Consultar VentaId con los dem�s datos
CREATE PROCEDURE sp_ConsultarVentaID
 
    @UsuarioID INT,
    @FechaVenta DATETIME,
    @TotalVenta DECIMAL(10,2)
AS
BEGIN
	SELECT VentaID FROM Ventas 
	WHERE UsuarioID = @UsuarioID AND FechaVenta = @FechaVenta AND TotalVenta = @TotalVenta;
END
GO

-- SP Insertar DetalleVenta
CREATE PROCEDURE sp_InsertarDetalleVenta
    @VentaID INT,
    @ProductoID INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario)
    VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario);
END
GO

-- SP Actualizar DetalleVenta
CREATE PROCEDURE sp_ActualizarDetalleVenta
    @DetalleID INT,
    @VentaID INT,
    @ProductoID INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(10,2)
AS
BEGIN
    UPDATE DetalleVenta
    SET VentaID = @VentaID,
        ProductoID = @ProductoID,
        Cantidad = @Cantidad,
        PrecioUnitario = @PrecioUnitario
    WHERE DetalleID = @DetalleID;
END
GO
-- SP Borrar DetalleVenta
CREATE PROCEDURE sp_BorrarDetalleVenta
    @DetalleID INT
AS
BEGIN
    DELETE FROM DetalleVenta WHERE DetalleID = @DetalleID;
END
GO

-- SP Consultar DetalleVenta
CREATE PROCEDURE sp_ConsultarDetalleVenta
AS
BEGIN
    SELECT * FROM DetalleVenta;
END
GO

-- SP Consultar DetalleVenta Por VentaID
CREATE PROCEDURE sp_ConsultarDetalleVentaPorVentaID
@VentaID INT
AS
BEGIN
    SELECT * FROM DetalleVenta WHERE VentaID = @VentaID;
END
GO

-- Insertar relaci�n Proveedor - Producto
CREATE PROCEDURE sp_InsertarProveedorProducto
    @ProveedorID INT,
    @ProductoID INT
AS
BEGIN
    INSERT INTO ProveedorProducto (ProveedorID, ProductoID)
    VALUES (@ProveedorID, @ProductoID);
END
GO

-- Borrar relaci�n Proveedor - Producto
CREATE PROCEDURE sp_BorrarProveedorProducto
    @ProveedorID INT,
    @ProductoID INT
AS
BEGIN
    DELETE FROM ProveedorProducto
    WHERE ProveedorID = @ProveedorID AND ProductoID = @ProductoID;
END
GO

-- Consultar relaciones Proveedor - Producto
CREATE PROCEDURE sp_ConsultarProveedorProducto
AS
BEGIN
    SELECT 
        pp.ProveedorID,
        p.Nombre AS NombreProveedor,
        pp.ProductoID,
        pr.Nombre AS NombreProducto
    FROM ProveedorProducto pp
    INNER JOIN Proveedores p ON pp.ProveedorID = p.ProveedorID
    INNER JOIN Productos pr ON pp.ProductoID = pr.ProductoID;
END
GO


--SP_ActualizarStock

CREATE PROCEDURE sp_ActualizarStock
    @ProductoID INT,
    @CantidadVendida INT
AS
BEGIN
    DECLARE @StockActual INT;

    SELECT @StockActual = CantidadStock FROM Productos WHERE ProductoID = @ProductoID;

    IF @StockActual >= @CantidadVendida
    BEGIN
        UPDATE Productos
        SET CantidadStock = CantidadStock - @CantidadVendida
        WHERE ProductoID = @ProductoID;
    END
    ELSE
    BEGIN
        RAISERROR('Stock insuficiente para el producto.', 16, 1);
    END
END
GO


--SP_GenerarAlertaStockMinimo
CREATE PROCEDURE sp_GenerarAlertaStockMinimo
AS
BEGIN
    SELECT ProductoID, Nombre, CantidadStock, StockMinimo
    FROM Productos
    WHERE CantidadStock < StockMinimo;
END
GO

--SP_CalcularDescuento -- Validar bien como es el funcionamiento del descuento para ver si es necesario crearle una tabla...




--SP_InsertarVenta

CREATE TYPE DetalleVentaTipo AS TABLE (
    ProductoID INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2)
);
GO

CREATE PROCEDURE sp_InsertarVentas
    @UsuarioID INT,
    @FechaVenta DATETIME,
    @DetalleVenta DetalleVentaTipo READONLY
AS
BEGIN
    DECLARE @TotalVenta DECIMAL(10,2) = 0;
    DECLARE @VentaID INT;

    BEGIN TRANSACTION;

    -- Calcular total
    SELECT @TotalVenta = SUM(Cantidad * PrecioUnitario)
    FROM @DetalleVenta;

    -- Insertar encabezado de venta
    INSERT INTO Ventas (UsuarioID, FechaVenta, TotalVenta)
    VALUES (@UsuarioID, @FechaVenta, @TotalVenta);

    SET @VentaID = SCOPE_IDENTITY();

    -- Insertar detalles y actualizar stock
    DECLARE @ProductoID INT, @Cantidad INT, @Precio DECIMAL(10,2);

    DECLARE detalle_cursor CURSOR FOR
    SELECT ProductoID, Cantidad, PrecioUnitario FROM @DetalleVenta;

    OPEN detalle_cursor;
    FETCH NEXT FROM detalle_cursor INTO @ProductoID, @Cantidad, @Precio;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Insertar detalle
        INSERT INTO DetalleVenta (VentaID, ProductoID, Cantidad, PrecioUnitario)
        VALUES (@VentaID, @ProductoID, @Cantidad, @Precio);

        -- Actualizar stock
        EXEC sp_ActualizarStock @ProductoID, @Cantidad;

        FETCH NEXT FROM detalle_cursor INTO @ProductoID, @Cantidad, @Precio;
    END

    CLOSE detalle_cursor;
    DEALLOCATE detalle_cursor;

    COMMIT TRANSACTION;
END
GO



--SP_ObtenerReporteVentas
CREATE PROCEDURE sp_ObtenerReporteVentas
    @FechaInicio DATE,
    @FechaFin DATE
AS
BEGIN
    SELECT 
        v.VentaID,
        v.FechaVenta,
        u.NombreUsuario,
        v.TotalVenta,
        dv.ProductoID,
        p.Nombre AS NombreProducto,
        dv.Cantidad,
        dv.PrecioUnitario
    FROM Ventas v
    INNER JOIN Usuarios u ON v.UsuarioID = u.UsuarioID
    INNER JOIN DetalleVenta dv ON v.VentaID = dv.VentaID
    INNER JOIN Productos p ON dv.ProductoID = p.ProductoID
    WHERE v.FechaVenta BETWEEN @FechaInicio AND @FechaFin
    ORDER BY v.FechaVenta;
END
GO
