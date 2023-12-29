CREATE DATABASE EnsayoBasededatos3;
use [EnsayoBasededatos3];

CREATE TABLE Usuarios(
		NombreUsuario varchar(50) primary key,
		ClaveUsuario varchar(50) not null,
		TipoUsuario varchar(50)
);
-------------------------------------------
CREATE TABLE Proveedor(
		RUTProveedor varchar(50) primary key,
		NombreProveedor char (30) not null,
		ApellidoPaProveedor char (30) not null,
		ApellidoMaProveedor char(30) not null,
		DireccionProveedor char(30) not null,
		TelefonoProveedor int not null
);
------------------------------------------------
CREATE TABLE Factura(
		NumerodeFactura int IDENTITY(23647347,1) primary key,
		RUTProveedor varchar(50) not null,
		PrecioFactura decimal not null,
		FechaFacturaProveedor date not null,
		--foreign key(RUTProveedor) references Proveedor(RUTProveedor)
);
------------------------------------------------
CREATE TABLE Producto_Factura(
		IDProducto int not null,
		NumerodeFactura int not null,
		CantidadFacturap int not null,
		PesoFacturap varchar(30) not null,
		--foreign key(NumerodeFactura) references Factura(NumerodeFactura)
);
------------------------------------------------
CREATE TABLE Producto(
		IDProducto int IDENTITY(31,1) primary key,
		IDCategoria int not null,
		StockProducto int not null,
		ValorProducto decimal not null,
		NombreProducto char(30) not null,
		FechaVencimiento datetime,
		--foreign key(IDCategoria) references Categoria(IDCategoria)
);
------------------------------------------------
CREATE TABLE Categoria(
		IDCategoria int IDENTITY(31,1) primary key,
		DescripcionCategoria varchar(50) not null,
);
------------------------------------------------
CREATE TABLE Producto_Venta(
		NumerodeBoleta int not null,
		IDProducto int not null,
		CantidadCliente int not null,
		--foreign key(IDProducto) references Producto(IDProducto),
		--foreign key(NumerodeBoleta) references Venta(NumerodeBoleta)
);
------------------------------------------------
CREATE TABLE Venta(
		NumerodeBoleta int IDENTITY(10887667,1) primary key,
		IDSucursal int not null,
		RUTVendedor varchar(50) not null,
		RUTCliente varchar(50),
		--NumerodeSeguimiento int,
		PesoVenta varchar(30) not null,
		NumerodePedido int,
		FechaVenta date not null,
		TotalVenta decimal not null,
		HoraVenta time not null,
		
);
------------------------------------------------
CREATE TABLE Sucursal(
		IDSucursal int IDENTITY(1,1) primary key,
		HorarioSucursal varchar(50) not null,
		NombreSucursal char(30) not null,
		DireccionSucursal varchar(50) not null,
		TelefonoSucursal int not null,
		TipodeSucursal varchar(10) not null
);
------------------------------------------------
CREATE TABLE Vendedor(
		RUTVendedor varchar(50) primary key,
		NombreVendedor char(30) not null,
		ApellidopaVendedor char(30) not null,
		ApellidomaVendedor char(30) not null,
		DireccionVendedor varchar(50) not null,
		HorarioVendedor varchar(50) not null,
		CargoVendedor char(30) not null,
		TelefonoVendedor int not null,
		FechadeCumpleaños int not null,
);
------------------------------------------------
CREATE TABLE Cliente(
		RUTCliente varchar(50) primary key not null,
		TipodeCliente char(20) not null,
		DireccionCliente varchar(50),
		Telefono int not null,
		NombreCliente char(20) not null,
		ApellidoPaterno char(20),
		ApellidoMaterno char(20),
		CorreoCliente varchar(30),
);
------------------------------------------------
CREATE TABLE Despacho(
		NumerodeSeguimiento int IDENTITY(401,1) primary key not null,
		FechaEstimadaEnvio smalldatetime not null,
		CargoEmpresaEnvio char(20) not null,
		--foreign key(NumerodeBoleta) references Venta(NumerodeBoleta)
);
------------------------------------------------
CREATE TABLE Tarjeta(
		NumerodeTarjeta varchar(50) primary key,
		RUTCliente varchar(50) not null,
		CodigodeSeguridad int not null,
		NombredelaTarjeta char(50) not null,
		FechadeVencimiento datetime not null,
		--foreign key(RUTCliente) references Cliente(RUTCliente)
);
------------------------------------------------
--conexion de tablas
ALTER TABLE Factura
	add constraint fk_1
	foreign key(RUTProveedor)
	references Proveedor(RUTProveedor);
	
------------------------------------------------
ALTER TABLE Producto_Factura
		add constraint fk_2
		foreign key(NumerodeFactura)
		references Factura(NumerodeFactura);
------------------------------------------------
ALTER TABLE Producto_Factura
		add constraint fk_3
		foreign key(IDProducto)
		references Producto(IDProducto);
-----------------------------------------------	
ALTER TABLE Producto
		add constraint fk_4
		foreign key(IDCategoria)
		references Categoria(IDCategoria);
------------------------------------------------
ALTER TABLE Producto_Venta
		add constraint fk_5
		foreign key(IDProducto)
		references Producto(IDProducto);
----------------------------------------------
ALTER TABLE Producto_Venta
		add constraint fk_6
		foreign key(NumerodeBoleta)
		references Venta(NumerodeBoleta);
---------------------------------------------
ALTER TABLE Venta
		add constraint fk_7
		foreign key(IDSucursal)
		references Sucursal(IDSucursal);
---------------------------------------------
ALTER TABLE Venta
		add constraint fk_8
		foreign key(RUTVendedor)
		references Vendedor(RUTVendedor);
--------------------------------------------
ALTER TABLE Venta
		add constraint fk_9
		foreign key (RUTCliente)
		references Cliente(RUTCliente);
-------------------------------------------	
ALTER TABLE Venta
		add constraint fk_10
		foreign key (NumerodePedido)
		references Despacho(NumerodeSeguimiento);
---------------------------------------------
ALTER TABLE Tarjeta
		add constraint fk_11
		foreign key(RUTCliente)
		references Cliente(RUTCliente);
---------------------------------------------
--Insertar Valores
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('21070478-7','Sebastian','Acuña','Camus','Timaukel 15559','946573440');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('12946504-5','Pablo','Wilde','Ramos','Franklin 1254','965432312');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('13543215-2','Javier','Santibañez','Vasconcellos','Islas Bahamas 12','954323232');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('15426573-7','Sara','Mora','Loyola','Tortel 765','949087201');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('22766456-0','Joao','Lagos','Molina','Martin de solis 1213','953413211');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('21267943-6','Yesenia','Macias','Ramos','Manuel Montt 12','990270301');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('21013211-7','Pedro','Aguirre','Cerda','Alessandri 155','990842320');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('11536889-1','Camila','Sanchez','Puerto','Rosenbaum 33514','923762327');
INSERT INTO Proveedor(RUTProveedor,NombreProveedor,ApellidoPaProveedor,ApellidoMaProveedor,DireccionProveedor,TelefonoProveedor)
VALUES('10786789-3','Julia','Cid','Carrero','Carissa 32416','947371212');
--1-----------------------------------------------------------------------------------------------
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('21013211-7',15000,'1994-08-04 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('21267943-6',11000,'2022-02-22 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('22766456-0',10000,'2022-01-21 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('15426573-7',3000,'2022-09-22 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('13543215-2',3500,'2022-11-21 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('12946504-5',15000,'2022-02-22 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('12946504-5',11000,'2022-09-22 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('12946504-5',11000,'2022-09-22 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('11536889-1',3000,'2022-10-11 00:00:00');
INSERT INTO Factura(RUTProveedor,PrecioFactura,FechaFacturaProveedor)
VALUES('10786789-3',3500,'2022-09-21 00:00:00');
---2-------------------------------------------------------------------------------------------
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(31,23647347,15,'12KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(32,23647348,20,'25KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(33,23647349,10,'9KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(34,23647350,150,'100KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(35,23647351,80,'50KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(36,23647352,90,'180KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(37,23647353,40,'65KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(38,23647354,45,'47KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(39,23647355,41,'50KG');
INSERT INTO Producto_Factura(IDProducto,NumerodeFactura,CantidadFacturap,PesoFacturap)
VALUES(40,23647356,34,'43KG');
----3-----------------------------------------------------------------
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(31,5,5000,'Almendras','2023-02-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(32,15,3000,'Almendras','2023-02-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(33,55,1500,'Almendras','2023-02-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(31,21,3000,'Avellanas','2023-09-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(32,51,1500,'Avellanas','2023-09-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(34,42,800,'Avellanas','2023-09-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(33,45,2000,'Castañas','2023-01-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(32,23,1000,'Castañas','2023-01-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(33,10,600,'Castañas','2023-01-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(34,4,1000,'Nueces','2023-11-24 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(32,7,10000,'Pistacho','2023-09-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(33,55,1000,'Pipas de calabaza','2023-05-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(31,70,500,'Piñones','2023-06-24 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(32,10,5000,'Anacardos','2022-12-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(34,150,600,'Cacahuetes','2023-05-23 00:00:00');
INSERT INTO Producto(IDCategoria,StockProducto,ValorProducto,NombreProducto,FechaVencimiento)
VALUES(31,70,500,'Nueces de Macadamia','2023-11-23 00:00:00');
-----4------------------------------------------------------------------------
INSERT INTO Categoria(DescripcionCategoria)
VALUES('Bolsa Grande');
INSERT INTO Categoria(DescripcionCategoria)
VALUES('Bolsa Mediana');
INSERT INTO Categoria(DescripcionCategoria)
VALUES('Bolsa Pequeña');
INSERT INTO Categoria(DescripcionCategoria)
VALUES('Por KG');
-----5---------------------------------------------------------------
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('11111111-1','Persona','San alberto 0235','955364356','Sebastian','Figueroa','Peña','sebap@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('22222222-2','Empresa','San alberto 0236',
'964324671','Juan','Perez','Santibañez','juanp@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('8123643-3','Empresa','San alberto 0237',
'932454267','Pedro','Laplace','Gil','pedrp@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('21424654-9','Persona','San alberto 0238',
'932562588','Gonzalo','Contreras','Soto','gonzp@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('7132457-4','Persona','San alberto 0239',
'935121477','Catalina','Garrido','Soto','catap@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('19234574-7','Persona','San alberto 0240',
'943222593','Ricardo','Manriquez','Solar','ricap@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('15874423-1','Empresa','San alberto 0241',
'977437473','Claudia','Celsius','Claro','claup@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('12423155-8','Empresa','San alberto 0242',
'982017492','Simonet','Torres','Pedrero','simop@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('6666666-6','Persona','San alberto 0243',
'955362718','Bastian','Mendoza','Rodriguez','bastp@gmail.com');
INSERT INTO Cliente(RUTCliente,TipodeCliente,DireccionCliente,Telefono,NombreCliente,ApellidoPaterno,ApellidoMaterno,CorreoCliente)
VALUES('17223453-6','Persona','San alberto 0244',
'988462728','Abraham','Sanchez','Acuña','abrap@gmail.com');
------6---------------------------------------------------------------
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(5412341478926390,'11111111-1',532,
'Sebastian Peña Figueroa','2023-05-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(5551779059069430,'22222222-2',112,
'Juan Perez Figueroa','2023-08-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(5197658670866270,'8123643-3',605,
'Pedro Laplace Gil','2023-05-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(5256340453230870,'21424654-9',192,
'Gonzalo Contreras Soto','2024-11-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(4893155378689310,'7132457-4',415,
'Catalina Garrido Perez','2023-09-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(4111918999703800,'19234574-7',305,
'Ricardo Manriquez','2024-04-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(4018106537188640,'15874423-1',294,
'Ricardo Manriquez','2023-03-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(342201722450328,'12423155-8',585,
'Simonet Torres Pedrero','2027-06-01 00:00:00');
INSERT INTO Tarjeta(NumerodeTarjeta,RUTCliente,CodigodeSeguridad,NombredelaTarjeta,FechadeVencimiento)
VALUES(6011905950999260,'17223453-6',927,
'Abraham Sanchez Acuña','2024-01-01 00:00:00');
-----7------------------------------------------------------------------------
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('13605842-8','Carlos','Goñi','Mayo','Feest Valleys 2281',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Reponedor','946573444',54);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('12686124-9','Francisco','Guevara','Zamora','Feest Valleys 2282',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Gerente','982340890',
24);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('20086335-6','Bianca','Casals','Vegas','Feest Valleys 2283',
'Sabado y Domingo de 08:00 AM a 18:00 PM','Reponedor','963274566',
42);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('17619448-3','Juan','Perez','Salgado','Feest Valleys 2284',
'Sabado y Domingo de 08:00 AM a 18:00 PM','Gerente','962341627',
22);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('17285786-8','Christopher','Cornejo','Holgado','Feest Valleys 2285',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Vendedor','913244353',
21);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('13605842-8','Melanie','Rodriguez','Osorio','Feest Valleys 2286',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Vendedor','947312334',
23);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('14588827-1','Jose','Baeza','Miranda','Feest Valleys 2287',
'Sabado y Domingo de 08:00 AM a 18:00 PM','Vendedor','951133123',
54);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('20086335-6','Gisela','Roman','Alcantara','Feest Valleys 2288',
'Sabado y Domingo de 08:00 AM a 18:00 PM','Reponedor','925467123',
54);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('19897109-2','Roberto','Medina','Sans','Feest Valleys 2289',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Gerente','987634724',
21);
INSERT INTO Vendedor(RUTVendedor,NombreVendedor,ApellidopaVendedor,
ApellidomaVendedor,DireccionVendedor,HorarioVendedor,CargoVendedor,
TelefonoVendedor,FechadeCumpleaños)
VALUES('18752630-2','Lorenza','Bernal','Contreras','Feest Valleys 2291',
'Lunes a Viernes de 08:00 AM a 18:00 PM','Vendedor','991346234',
33);
-----8------------------------------------------------------------
INSERT INTO Sucursal(HorarioSucursal,NombreSucursal,DireccionSucursal,TelefonoSucursal,TipodeSucursal)
VALUES('Lunes a Viernes de 08:00 AM a 18:00 PM','FS CHILL-E CE','Manuel Montt 367','925600000','Retiro');
INSERT INTO Sucursal(HorarioSucursal,NombreSucursal,DireccionSucursal,TelefonoSucursal,TipodeSucursal)
VALUES('Lunes a Viernes de 08:00 AM a 18:00 PM','FS CHILL-E CE','Barros Arana 746','925600000','Tienda');
INSERT INTO Sucursal(HorarioSucursal,NombreSucursal,DireccionSucursal,TelefonoSucursal,TipodeSucursal)
VALUES('Lunes a Domingos de 08:00 AM a 18:00 PM','FS CHILL-E CE','Madrid Osorio 123','925600000','Bodega');
INSERT INTO Sucursal(HorarioSucursal,NombreSucursal,DireccionSucursal,TelefonoSucursal,TipodeSucursal)
VALUES('Lunes a Domingos de 08:00 AM a 18:00 PM','FS CHILL-E CE','San jose 069','925600000','Tienda');
INSERT INTO Sucursal(HorarioSucursal,NombreSucursal,DireccionSucursal,TelefonoSucursal,TipodeSucursal)
VALUES('Lunes a Domingos de 08:00 AM a 18:00 PM','FS CHILL-E CE','Timaukel 1213','925600000','Retiro');
--------9--------------------------------------------------------------
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(1,'13605842-8','11111111-1','200G',401,
'2021-04-28 00:00:00',5000,'13:25:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(2,'12686124-9','22222222-2','300G',402,
'2020-02-24 00:00:00',5000,'09:51:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(3,'20086335-6','8123643-3','3KG',403,
'2021-05-28 00:00:00',25000,'08:52:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(3,'17619448-3','21424654-9','2.5KG',404,
'2020-03-14 00:00:00',23000,'15:32:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(2,'17285786-8','7132457-4','500G',406,
'2021-12-05 00:00:00',5000,'16:32:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(3,'13605842-8','19234574-7','800G',407,
'2021-07-21 00:00:00',6000,'18:00:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(1,'14588827-1','15874423-1','100G',408,
'2021-01-31 00:00:00',1000,'09:10:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(2,'20086335-6','12423155-8','10KG',409,
'2021-06-08 00:00:00',40000,'10:30:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(2,'19897109-2','6666666-6','2KG',410,
'2022-02-26 00:00:00',10000,'10:30:00');
INSERT INTO Venta(IDSucursal,RUTVendedor,RUTCliente,PesoVenta,
NumerodePedido,FechaVenta,TotalVenta,HoraVenta)
VALUES(1,'18752630-2','17223453-6','400G',' ',
'2021-03-11 00:00:00',4000,'14:23:00');
--------10------------------------------------------------------------
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887667,31,4);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887668,32,2);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887669,33,5);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887670,34,2);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887671,35,3);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887672,36,3);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887673,31,3);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887674,32,3);
INSERT INTO Producto_Venta(NumerodeBoleta,IDProducto,CantidadCliente)
VALUES(10887675,33,5);
---------------11-------------------------------------------------------------
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2021-04-28 00:00:00',100);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2020-02-26 00:00:00',80);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2021-05-30 00:00:00',70);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2020-03-16 00:00:00',80);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2021-07-12 00:00:00',80);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2020-07-24 00:00:00',100);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2022-02-03 00:00:00',80);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2021-05-10 00:00:00',70);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2022-02-28 00:00:00',80);
INSERT INTO Despacho(FechaEstimadaEnvio,CargoEmpresaEnvio)
VALUES('2022-03-16 00:00:00',80);
--------------------------------------------------------
INSERT INTO Usuarios(NombreUsuario,ClaveUsuario,TipoUsuario)
VALUES('SEBA','1234','ADMIN');
INSERT INTO Usuarios(NombreUsuario,ClaveUsuario,TipoUsuario)
VALUES('BASTI','1234','CLIENTE');
