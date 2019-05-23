delimiter $$

create procedure altaCliente (unDNI int,
							  unNombre varchar(45),
                              unApellido varchar(45),
                              unMail varchar(45),
                              unaTarjeta int)
begin
	insert into Cliente (DNI, Nombre, Apellido, Mail, Tarjeta)
    values (unDMI, unNombre, unApellido, unMail, unaTarjeta);
end $$

create procedure altaFichin (unIdFichin tinyint,
                             unNombre varchar(45), 
                             unAnho smallint,
                             unPrecio float)
begin
	insert into Fichin (IdFichin, Nombre, Anho, Precio)
    values (unIdFichin, unNombre, unAnho, unPrecio);
end $$

create procedure altaJugada (unIdJugadas int, 
                             unaFechaHora datetime,
                             unDNI int,
                             unCredito float, 
                             unIdFichin tinyint)
begin
	insert into Jugada (IdJugadas, FechaHora, DNI, Credito, IdFichin)
    values (unIdJugadas, unaFechaHora, unDNI, unIdFichin);
end $$

create procedure altaRecarga (unIdRecarga int,
                              unaFechayHora datetime,
                              unDNI int,
                              unMontoTecargado float)
begin
	insert into Recarga (IdRecarga, FechayHora, DNI, MontoRecargado)
    values (unIdRecarga, unaFechayHora, unDNI, unMontoRecargado);
end $$