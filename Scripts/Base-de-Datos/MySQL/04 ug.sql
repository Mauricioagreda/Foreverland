create user 'Administrador'@'%' identified by 'contraAdmin';

create user 'Componente'@'10.120.0.%' identified by 'contraComponente';

create user 'Cliente'@'%' identified by 'contraCliente';

grant select,insert,update (precio) on Fichin to 'Administrador'@'%';

grant select,insert on Cliente to 'Administrador'@'%';

grant select,insert on Cliente to 'Administrador'@'%';

grant insert on Jugada to 'Componente'@'10.120.0.%';

grant update (saldo) on Cliente to 'Componente'@'10.120.0.%';

grant select on Cliente to 'Cliente'@'%';

grant select on Tarjeta to 'Cliente'@'%';

grant select on Jugada to 'Cliente'@'%';

grant insert 