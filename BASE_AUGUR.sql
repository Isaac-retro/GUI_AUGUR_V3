
/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE 
(
   IDCLIENTE            integer                        not null identity(1,1),
   NOMBRECLIENTE        varchar(45)                    not null,
   APELLIDOCLIENTE      varchar(45)                    not null,
   DIRECCION            varchar(45)                    not null,
   TELEFONO             varchar(45)                    not null,
   CEDULA               varchar(10)                    not null,
   ACTIVOCLIENTE        varchar(2)                     not null,
   constraint PK_CLIENTE primary key (IDCLIENTE)
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO 
(
   IDUSUARIO            integer                        not null,
   NOMBRENATURAL        varchar(15)                    not null,
   NOMBREUSUARIO        varchar(6)                     not null,
   PASS                 varchar(32)                    not null,
   CARGO                varchar(15)                    not null,
   ACTIVOUSUARIO        varchar(2)                     not null,
   constraint PK_USUARIO primary key (IDUSUARIO)
);


/*==============================================================*/
/* Table: FACTURA                                               */
/*==============================================================*/
create table FACTURA 
(
   IDFACTURA            integer                        not null identity(1,1),
   IDCLIENTE            integer                        not null,
   TOTALFACTURA         numeric(8,2)                   not null,
   FECHAHORAFACTURA     timestamp                      not null,
   ACTIVOFACTURA        varchar(2)                     null,
   constraint PK_FACTURA primary key (IDFACTURA)
);


/*==============================================================*/
/* Table: INGREDIENTES                                          */
/*==============================================================*/
create table INGREDIENTES 
(
   IDINGREDIENTE        integer                        not null identity(1,1),
   NOMBREINGREDIENTE    varchar(20)                    not null,
   PRECIOINGREDIENTE    numeric(8,2)                   not null,
   UNIDADMEDIDA         varchar(10)                    not null,
   ACTIVOPARAMETRO      varchar(2)                     not null,
   CANTIDADDISPONIBLE   float                          null,
   constraint PK_INGREDIENTES primary key (IDINGREDIENTE)
);


/*==============================================================*/
/* Table: LOGACCESO                                             */
/*==============================================================*/
create table LOGACCESO 
(
   IDUSUARIO            integer                        not null,
   FECHAHORAACCESO      timestamp                      not null
);



/*==============================================================*/
/* Table: PARAMETRO                                             */
/*==============================================================*/
create table PARAMETRO 
(
   IDPARAMETRO          integer                        not null,
   NOMBREPARAMETRO      varchar(10)                    not null,
   VALORPARAMETRO       numeric(8,2)                   not null,
   ACTIVOPARAMETRO      varchar(2)                     not null,
   constraint PK_PARAMETRO primary key (IDPARAMETRO)
);


/*==============================================================*/
/* Table: PEDIDO                                                */
/*==============================================================*/
create table PEDIDO 
(
   IDPEDIDO             integer                        not null,
   IDUSUARIO            integer                        not null,
   IDFACTURA            integer                        null,
   TOTAL                numeric(8,2)                   not null,
   FECHAHORAPEDIDO      timestamp                      not null,
   ACTIVOPEDIDO         varchar(2)                     not null,
   constraint PK_PEDIDO primary key (IDPEDIDO)
);



/*==============================================================*/
/* Table: PLATODECOMIDA                                         */
/*==============================================================*/
create table PLATODECOMIDA 
(
   IDPLATO              integer                        not null,
   NOMBREPLATO          varchar(20)                    not null,
   PRECIOPLATO          numeric(8,2)                   not null,
   TIPOPLATO            varchar(10)                    not null,
   ACTIVOPLATO          varchar(2)                     not null,
   constraint PK_PLATODECOMIDA primary key (IDPLATO)
);



/*==============================================================*/
/* Table: ULTIMACONTRASENA                                      */
/*==============================================================*/
create table ULTIMACONTRASENA 
(
   IDUSUARIO            integer                        not null,
   ULTIMOPASS           varchar(33)                    not null,
   FECHAHORAUC          timestamp                      not null
);



/*==============================================================*/
/* Table: ULTIMOPARAMETRO                                       */
/*==============================================================*/
create table ULTIMOPARAMETRO 
(
   IDPARAMETRO          integer                        not null,
   VALORPATAMETRO       numeric(8,2)                   not null,
   FECHAHORAPARAMETRO   timestamp                      not null
);



/*==============================================================*/
/* Table: ULTIMOPRECIOINGREDIENTE                               */
/*==============================================================*/
create table ULTIMOPRECIOINGREDIENTE 
(
   IDINGREDIENTE        integer                        not null,
   ULTIMPRECIOINGREDIENTE numeric(8,2)                   not null,
   FECHAHORAUPI         timestamp                      null
);

/*==============================================================*/
/* Table: ULTIMOPRECIOPLATO                                     */
/*==============================================================*/
create table ULTIMOPRECIOPLATO 
(
   IDPLATO              integer                        not null,
   ULTIMOPRECIOPLATO    numeric(8,2)                   not null,
   FECHAHORAUPP         timestamp                      not null
);

/*==============================================================*/
/* Table: DETALLE_PEDIDO_PLATO                                  */
/*==============================================================*/
create table DETALLE_PEDIDO_PLATO 
(
   IDPLATO              integer                        not null,
   IDPEDIDO             integer                        not null,
   CANTIDADPLATO        integer                        not null,
   constraint PK_DETALLE_PEDIDO_PLATO primary key (IDPLATO, IDPEDIDO)
);


/*==============================================================*/
/* Table: DETALLE_PLATO_INGREDIENTE                             */
/*==============================================================*/
create table DETALLE_PLATO_INGREDIENTE 
(
   IDPLATO              integer                        not null,
   IDINGREDIENTE        integer                        not null,
   CANTIDAD             float                          not null,
   constraint PK_DETALLE_PLATO_INGREDIENTE primary key (IDPLATO, IDINGREDIENTE)
);





alter table DETALLE_PEDIDO_PLATO
   add constraint FK_DETALLE__RELATIONS_PEDIDO foreign key (IDPEDIDO)
      references PEDIDO (IDPEDIDO)


alter table DETALLE_PEDIDO_PLATO
   add constraint FK_DETALLE__RELATIONS_PLATODECP foreign key (IDPLATO)
      references PLATODECOMIDA (IDPLATO)


alter table DETALLE_PLATO_INGREDIENTE
   add constraint FK_DETALLE__RELATIONS_PLATODECI foreign key (IDPLATO)
      references PLATODECOMIDA (IDPLATO)


alter table FACTURA
   add constraint FK_FACTURA_COMPRA_CLIENTE foreign key (IDCLIENTE)
      references CLIENTE (IDCLIENTE)


alter table LOGACCESO
   add constraint FK_LOGACCES_TIENE_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)

alter table PEDIDO
   add constraint FK_PEDIDO_RELATIONS_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)


alter table PEDIDO
   add constraint FK_PEDIDO_RELATIONS_FACTURA foreign key (IDFACTURA)
      references FACTURA (IDFACTURA)


alter table ULTIMACONTRASENA
   add constraint FK_ULTIMACO_TIENECONT_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)


alter table ULTIMOPARAMETRO
   add constraint FK_ULTIMOPA_RELATIONS_PARAMETR foreign key (IDPARAMETRO)
      references PARAMETRO (IDPARAMETRO)


alter table ULTIMOPRECIOINGREDIENTE
   add constraint FK_ULTIMOPR_TIENEPREC_INGREDIE foreign key (IDINGREDIENTE)
      references INGREDIENTES (IDINGREDIENTE)


alter table ULTIMOPRECIOPLATO
   add constraint FK_ULTIMOPR_TIENEPREC_PLATODEC foreign key (IDPLATO)
      references PLATODECOMIDA (IDPLATO)

