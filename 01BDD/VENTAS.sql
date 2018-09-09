/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     19/02/2015 9:53:53                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_DETALLES_DE_VENTAS') and o.name = 'FK_TAB_DETA_REFERENCE_TAB_VENT')
alter table TAB_DETALLES_DE_VENTAS
   drop constraint FK_TAB_DETA_REFERENCE_TAB_VENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_DETALLES_DE_VENTAS') and o.name = 'FK_TAB_DETA_REFERENCE_TAB_PROD')
alter table TAB_DETALLES_DE_VENTAS
   drop constraint FK_TAB_DETA_REFERENCE_TAB_PROD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PRODUCTOS') and o.name = 'FK_TAB_PROD_REFERENCE_TAB_TIPO')
alter table TAB_PRODUCTOS
   drop constraint FK_TAB_PROD_REFERENCE_TAB_TIPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PRODUCTOS') and o.name = 'FK_TAB_PROD_REFERENCE_TAB_PROV')
alter table TAB_PRODUCTOS
   drop constraint FK_TAB_PROD_REFERENCE_TAB_PROV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_VENTAS') and o.name = 'FK_TAB_VENT_REFERENCE_TAB_CLIE')
alter table TAB_VENTAS
   drop constraint FK_TAB_VENT_REFERENCE_TAB_CLIE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CLIENTES')
            and   type = 'U')
   drop table TAB_CLIENTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_DETALLES_DE_VENTAS')
            and   type = 'U')
   drop table TAB_DETALLES_DE_VENTAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PRODUCTOS')
            and   type = 'U')
   drop table TAB_PRODUCTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PROVEEDORES')
            and   type = 'U')
   drop table TAB_PROVEEDORES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_TIPOPRODUCTOS')
            and   type = 'U')
   drop table TAB_TIPOPRODUCTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_VENTAS')
            and   type = 'U')
   drop table TAB_VENTAS
go

/*==============================================================*/
/* Table: TAB_CLIENTES                                          */
/*==============================================================*/
create table TAB_CLIENTES (
   ID_CLIENTES          numeric              identity,
   APELLIDOS            varchar(50)          not null,
   NOMBRES              varchar(50)          not null,
   CEDULA               varchar(10)          not null,
   EMAIL                varchar(250)         not null,
   TELEFONO             varchar(15)          not null,
   DIRECCION            varchar(250)         not null,
   constraint PK_TAB_CLIENTES primary key (ID_CLIENTES)
)
go

/*==============================================================*/
/* Table: TAB_DETALLES_DE_VENTAS                                */
/*==============================================================*/
create table TAB_DETALLES_DE_VENTAS (
   ID_DETALLE_VENTA     numeric              identity,
   ID_VENTA             numeric              not null,
   ID_PRODUCTO          numeric              not null,
   CANTIDAD             numeric              not null,
   PRECIO               numeric(6,2)         not null,
   IVA                  numeric              not null,
   constraint PK_TAB_DETALLES_DE_VENTAS primary key (ID_DETALLE_VENTA)
)
go

/*==============================================================*/
/* Table: TAB_PRODUCTOS                                         */
/*==============================================================*/
create table TAB_PRODUCTOS (
   ID_PRODUCTO          numeric              identity,
   ID_TIPO_PRODUCTO     numeric              null,
   ID_PROVEEDOR         numeric              null,
   NOMBRE               varchar(300)         not null,
   CANTIDAD             numeric              not null,
   PRECIO               numeric(6,2)         not null,
   IVA                  numeric              not null,
   constraint PK_TAB_PRODUCTOS primary key (ID_PRODUCTO)
)
go

/*==============================================================*/
/* Table: TAB_PROVEEDORES                                       */
/*==============================================================*/
create table TAB_PROVEEDORES (
   ID_PROVEEDOR         numeric              identity,
   APELLIDOS            varchar(50)          not null,
   NOMBRES              varchar(50)          not null,
   CEDULA               varchar(10)          not null,
   EMAIL                varchar(250)         not null,
   TELEFONO             varchar(15)          not null,
   DIRECCION            varchar(250)         not null,
   constraint PK_TAB_PROVEEDORES primary key (ID_PROVEEDOR)
)
go

/*==============================================================*/
/* Table: TAB_TIPOPRODUCTOS                                     */
/*==============================================================*/
create table TAB_TIPOPRODUCTOS (
   ID_TIPO_PRODUCTO     numeric              identity,
   TIPO_PRODUCTO        varchar(200)         not null,
   constraint PK_TAB_TIPOPRODUCTOS primary key (ID_TIPO_PRODUCTO)
)
go

/*==============================================================*/
/* Table: TAB_VENTAS                                            */
/*==============================================================*/
create table TAB_VENTAS (
   ID_VENTA             numeric              identity,
   ID_CLIENTES          numeric              null,
   FECHA_VENTA          date                 not null,
   NUMERO_FACTURA       numeric              not null,
   constraint PK_TAB_VENTAS primary key (ID_VENTA)
)
go

alter table TAB_DETALLES_DE_VENTAS
   add constraint FK_TAB_DETA_REFERENCE_TAB_VENT foreign key (ID_VENTA)
      references TAB_VENTAS (ID_VENTA)
go

alter table TAB_DETALLES_DE_VENTAS
   add constraint FK_TAB_DETA_REFERENCE_TAB_PROD foreign key (ID_PRODUCTO)
      references TAB_PRODUCTOS (ID_PRODUCTO)
go

alter table TAB_PRODUCTOS
   add constraint FK_TAB_PROD_REFERENCE_TAB_TIPO foreign key (ID_TIPO_PRODUCTO)
      references TAB_TIPOPRODUCTOS (ID_TIPO_PRODUCTO)
go

alter table TAB_PRODUCTOS
   add constraint FK_TAB_PROD_REFERENCE_TAB_PROV foreign key (ID_PROVEEDOR)
      references TAB_PROVEEDORES (ID_PROVEEDOR)
go

alter table TAB_VENTAS
   add constraint FK_TAB_VENT_REFERENCE_TAB_CLIE foreign key (ID_CLIENTES)
      references TAB_CLIENTES (ID_CLIENTES)
go

