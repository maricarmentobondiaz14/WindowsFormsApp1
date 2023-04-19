create procedure spAgregar
@nombre varchar(255),
@descripcion varchar(255)

 as
 DECLARE @codigoRetorno int
 DECLARE @descripcionRetorno varchar(255)

  BEGIN TRY

    INSERT INTO tblExamen VALUES( @nombre, @descripcion);
    PRINT 'Registro insertado satisfactoriamente';
	SET @codigoRetorno=0;
	SET @descripcionRetorno ='Registro insertado satisfactoriamente';
	Return @codigoRetorno
  END TRY
  
  BEGIN CATCH
  SET @descripcionRetorno = 'Error ' + CONVERT(VARCHAR, ERROR_NUMBER(), 1) + ': '+ ERROR_MESSAGE();
  SET @codigoRetorno = ERROR_NUMBER();
  	Return @codigoRetorno

  END CATCH
GO

create procedure spActualizar
@id int,
@nombre varchar(255),
@descripcion varchar(255)

 as
 DECLARE @codigoRetorno int
 DECLARE @descripcionRetorno varchar(255)

  BEGIN TRY

    UPDATE tblExamen SET nombre= @nombre, descripcion=@descripcion WHERE idExamen=@id;
    PRINT 'Registro insertado satisfactoriamente';
	SET @codigoRetorno=0;
	SET @descripcionRetorno ='Registro insertado satisfactoriamente';
	Return @codigoRetorno
  END TRY
  
  BEGIN CATCH
  SET @descripcionRetorno = 'Error ' + CONVERT(VARCHAR, ERROR_NUMBER(), 1) + ': '+ ERROR_MESSAGE();
  SET @codigoRetorno = ERROR_NUMBER();
  	Return @codigoRetorno

  END CATCH
GO

create procedure spEliminar
@id int

 as
 DECLARE @codigoRetorno int
 DECLARE @descripcionRetorno varchar(255)

  BEGIN TRY

    DELETE FROM tblExamen WHERE idExamen=@id;
    PRINT 'Registro insertado satisfactoriamente';
	SET @codigoRetorno=0;
	SET @descripcionRetorno ='Registro eliminado correctamente';
	Return @codigoRetorno
  END TRY
  
  BEGIN CATCH
  SET @descripcionRetorno = 'Error ' + CONVERT(VARCHAR, ERROR_NUMBER(), 1) + ': '+ ERROR_MESSAGE();
  SET @codigoRetorno = ERROR_NUMBER();
  	Return @codigoRetorno

  END CATCH
GO
create procedure spConsultar
@id int,
@nombre VARCHAR(255)
 as
 DECLARE @codigoRetorno int
 DECLARE @descripcionRetorno varchar(255)

  BEGIN TRY

    SELECT idExamen, nombre, descripcion from tblExamen where idExamen=@id and nombre=@nombre;
    PRINT 'Registros consultados correctamente';
	SET @codigoRetorno=0;
	SET @descripcionRetorno ='Registros consultados correctamente';
  END TRY
  
  BEGIN CATCH
  SET @descripcionRetorno = 'Error ' + CONVERT(VARCHAR, ERROR_NUMBER(), 1) + ': '+ ERROR_MESSAGE();
  SET @codigoRetorno = ERROR_NUMBER();

  END CATCH
GO

