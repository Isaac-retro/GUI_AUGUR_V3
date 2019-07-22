create  database AUGUR;
use AUGUR;

---Tabla: Usuario
create table Usuario(
idUsuario int not null identity(1,1),
nombreUsuario varchar(30),
loggin varchar(6),
pass varchar(33),
bloqueado bit,
primary key (idUsuario) 
);

---Tabla: LogAcceso
create table LogAcceso(
idUsuario int not null,
fechaHoraAcceso datetime,
primary key (idUsuario)
)


---Tabla: Cliente
create table Cliente(
idCliente int not null identity(1,1),
nombreCliente varchar(50),
apellidoCliente varchar(50),
direccion varchar(50),
telefono varchar(10),
cedulaPass varchar(10),
activoCliente bit,
primary key(idCliente)
)

---Tabla: Plato_De_Comida
create table PlatoDeComida(
idPlatoDeComida int not null identity(1,1),
nombrePlato varchar(50),
precio money,
activoPlato bit,
primary key(idPlatoDeComida)
)



---Tabla: Factura
create table Factura(
idFactura int not null identity(1,1),
idCliente int,
totalFac money,
fechaHoraFac datetime,
primary key(idFactura),
foreign key(idCliente) references Cliente(idCliente)
)

---Tabla: Pedido
create table Pedido(
idPedido int not null identity(1,1),
idFactura int,
idUsuario int,
totalPedido money,
fechaHoraPedido datetime,
primary key(idPedido),
foreign key(idFactura) references Factura(idFactura),
foreign key(idUsuario) references Usuario(idUsuario)
)

---Tabla: Detalle_Pedido_Platos
create table DetallePedidoPlatos(
idPlatoDeComida int not null,
idPedido int not null,
cantidad int not null,
foreign key(idPlatoDeComida) references PlatoDeComida(idPlatoDeComida),
foreign key(idPedido) references Pedido(idPedido)
)

---Tabla: Ingrediente
create table Ingrediente(
idIngrediente int not null identity(1,1),
nombreIngrediente varchar(50),
precio money,
activoIngrediente bit,
constraint pk_idIngrediente
primary key(idIngrediente)
)

---Tabla: Detalle_Plato_Ingrediente
create table DetallePlatoIngrediente(
idPlatoDeComida int,
idIngrediente int,
cantidadGramos float,
foreign key(idPlatoDeComida) references PlatoDeComida(idPlatoDeComida),
foreign key(idIngrediente) references Ingrediente(idIngrediente)
)

insert into usuario (nombreUsuario,loggin,pass,bloqueado) values ('Alvaro','admin','0B718FAD51831A032DB50D6B400E2AED',1); -- adminAugur0
insert into usuario (nombreUsuario,loggin,pass,bloqueado) values ('Christian','manag','C247CF6289521E990636035B8B2C878D',1); -- managAugur0
insert into usuario (nombreUsuario,loggin,pass,bloqueado) values ('Michelle','user1','E10B1C9E3AF815F9C4B022CAA5943828',1); --userAugur1
insert into usuario (nombreUsuario,loggin,pass,bloqueado) values ('Diana','user2','BF5FD321E42D604BA444CA51CB0DA219',1); --userAguru2