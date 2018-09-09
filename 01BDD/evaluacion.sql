/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     10/03/2015 10:03:23                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PERSONA') and o.name = 'FK_TAB_PERS_REFERENCE_TAB_PAIS')
alter table TAB_PERSONA
   drop constraint FK_TAB_PERS_REFERENCE_TAB_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PERSONA') and o.name = 'FK_TAB_PERS_REFERENCE_TAB_PROV')
alter table TAB_PERSONA
   drop constraint FK_TAB_PERS_REFERENCE_TAB_PROV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PROVINCIA') and o.name = 'FK_TAB_PROV_REFERENCE_TAB_PAIS')
alter table TAB_PROVINCIA
   drop constraint FK_TAB_PROV_REFERENCE_TAB_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TOTALES') and o.name = 'FK_TAB_TOTA_REFERENCE_TAB_PAIS')
alter table TAB_TOTALES
   drop constraint FK_TAB_TOTA_REFERENCE_TAB_PAIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_TOTALES') and o.name = 'FK_TAB_TOTA_REFERENCE_TAB_PROV')
alter table TAB_TOTALES
   drop constraint FK_TAB_TOTA_REFERENCE_TAB_PROV
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PAIS')
            and   type = 'U')
   drop table TAB_PAIS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PERSONA')
            and   type = 'U')
   drop table TAB_PERSONA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PROVINCIA')
            and   type = 'U')
   drop table TAB_PROVINCIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_TOTALES')
            and   type = 'U')
   drop table TAB_TOTALES
go

/*==============================================================*/
/* Table: TAB_PAIS                                              */
/*==============================================================*/
create table TAB_PAIS (
   ID_PAIS              integer              identity,
   PAIS                 varchar(200)         not null,
   constraint PK_TAB_PAIS primary key (ID_PAIS)
)
go

/*==============================================================*/
/* Table: TAB_PERSONA                                           */
/*==============================================================*/
create table TAB_PERSONA (
   ID_PERSONA           integer              identity,
   ID_PROVINCIA         integer              null,
   ID_PAIS              integer              null,
   NOMBRES              varchar(200)         not null,
   APELLDIOS            varchar(200)         not null,
   constraint PK_TAB_PERSONA primary key (ID_PERSONA)
)
go

/*==============================================================*/
/* Table: TAB_PROVINCIA                                         */
/*==============================================================*/
create table TAB_PROVINCIA (
   ID_PROVINCIA         integer              identity,
   ID_PAIS              integer              null,
   PROVINCIA            varchar(200)         not null,
   constraint PK_TAB_PROVINCIA primary key (ID_PROVINCIA)
)
go

/*==============================================================*/
/* Table: TAB_TOTALES                                           */
/*==============================================================*/
create table TAB_TOTALES (
   ID_TOTAL             integer              identity,
   ID_PAIS              integer              null,
   ID_PROVINCIA         integer              null,
   TOTALES              varchar(200)         not null,
   constraint PK_TAB_TOTALES primary key (ID_TOTAL)
)
go

alter table TAB_PERSONA
   add constraint FK_TAB_PERS_REFERENCE_TAB_PAIS foreign key (ID_PAIS)
      references TAB_PAIS (ID_PAIS)
go

alter table TAB_PERSONA
   add constraint FK_TAB_PERS_REFERENCE_TAB_PROV foreign key (ID_PROVINCIA)
      references TAB_PROVINCIA (ID_PROVINCIA)
go

alter table TAB_PROVINCIA
   add constraint FK_TAB_PROV_REFERENCE_TAB_PAIS foreign key (ID_PAIS)
      references TAB_PAIS (ID_PAIS)
go

alter table TAB_TOTALES
   add constraint FK_TAB_TOTA_REFERENCE_TAB_PAIS foreign key (ID_PAIS)
      references TAB_PAIS (ID_PAIS)
go

alter table TAB_TOTALES
   add constraint FK_TAB_TOTA_REFERENCE_TAB_PROV foreign key (ID_PROVINCIA)
      references TAB_PROVINCIA (ID_PROVINCIA)
go

