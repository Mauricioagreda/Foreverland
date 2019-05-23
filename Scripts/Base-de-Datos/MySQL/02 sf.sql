Delimiter $$
CREATE FUNCTION recargasEntre(unIdCliente int, cotaInferior DATETIME,
                            cotaSuperior DATETIME) returns float
                            
                            Begin
                            Declare Resultado float;
                            select Sum(MontoRecargado) into Resultado
                            from Recarga 
                            where idCliente = unIdCliente
                            and fechayHora between cotaInferior and cotaSuperior;
                            return Resultado;
end $$

CREATE FUNCTION recaudadoEntre(unIdFichin int, cotaInferior DATETIME,
                            cotaSuperior DATETIME) returns float
Begin
                            Declare Resultado float;
                            select Sum(Precio) into Resultado
                            from Jugada 
                            where idFichin = unIdFichin
                            
                            and FechaHora between cotaInferior and cotaSuperior;
                            return Resultado;
end$$