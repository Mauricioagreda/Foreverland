create user IF NOT exists'Gerente'@'%' identified by 'contraGerente';
create user IF NOT exists 'Componente'@'10.120.0.%' identified by 'contraComponente';
create user IF NOT exists 'Cliente'@'%' identified by 'contraCliente';

# Gerente

grant select,insert,update(precio) on Fichin to 'Gerente'@'%';
grant select,insert on Tarjeta to 'Gerente'@'%';
grant select,insert on Cliente to 'Gerente'@'%';
grant select on Jugada to 'Gerente'@'%';

#Componente

grant insert on Jugada to 'Componente'@'10.120.0.%';
grant update(saldo) on Tarjeta to 'Componente'@'10.120.0.%';

# Cliente
grant select on Cliente to 'Cliente'@'%';
grant select, update(saldo) on Tarjeta to 'Cliente'@'%';
grant select,insert on recarga to 'Cliente'@'%';
grant select on Fichin  to 'Cliente'@'%';
grant select,insert on Jugada to 'Cliente'@'%';


