/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     19/02/2015 21:07:50                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_CANTONES') and o.name = 'FK_TAB_CANT_REFERENCE_TAB_PROV')
alter table TAB_CANTONES
   drop constraint FK_TAB_CANT_REFERENCE_TAB_PROV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_CLIENTES') and o.name = 'FK_TAB_CLIE_REFERENCE_TAB_PERS')
alter table TAB_CLIENTES
   drop constraint FK_TAB_CLIE_REFERENCE_TAB_PERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_CONTROL_MASCOTA') and o.name = 'FK_TAB_CONT_REFERENCE_TAB_FICH')
alter table TAB_CONTROL_MASCOTA
   drop constraint FK_TAB_CONT_REFERENCE_TAB_FICH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_FICHA_DE_INGRESO') and o.name = 'FK_TAB_FICH_REFERENCE_TAB_MEDI')
alter table TAB_FICHA_DE_INGRESO
   drop constraint FK_TAB_FICH_REFERENCE_TAB_MEDI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_FICHA_DE_INGRESO') and o.name = 'FK_TAB_FICH_REFERENCE_TAB_MASC')
alter table TAB_FICHA_DE_INGRESO
   drop constraint FK_TAB_FICH_REFERENCE_TAB_MASC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MASCOTA') and o.name = 'FK_TAB_MASC_REFERENCE_TAB_RAZA')
alter table TAB_MASCOTA
   drop constraint FK_TAB_MASC_REFERENCE_TAB_RAZA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MASCOTA') and o.name = 'FK_TAB_MASC_REFERENCE_TAB_TIPO')
alter table TAB_MASCOTA
   drop constraint FK_TAB_MASC_REFERENCE_TAB_TIPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MASCOTA') and o.name = 'FK_TAB_MASC_REFERENCE_TAB_CLIE')
alter table TAB_MASCOTA
   drop constraint FK_TAB_MASC_REFERENCE_TAB_CLIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MEDICAMENTOS_SUMINISTRADOS') and o.name = 'FK_TAB_MEDI_REFERENCE_TAB_MEDI')
alter table TAB_MEDICAMENTOS_SUMINISTRADOS
   drop constraint FK_TAB_MEDI_REFERENCE_TAB_MEDI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MEDICAMENTOS_SUMINISTRADOS') and o.name = 'FK_TAB_MEDI_REFERENCE_TAB_FICH')
alter table TAB_MEDICAMENTOS_SUMINISTRADOS
   drop constraint FK_TAB_MEDI_REFERENCE_TAB_FICH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_MEDICOS') and o.name = 'FK_TAB_MEDI_REFERENCE_TAB_PERS')
alter table TAB_MEDICOS
   drop constraint FK_TAB_MEDI_REFERENCE_TAB_PERS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PERSONA') and o.name = 'FK_TAB_PERS_REFERENCE_TAB_CANT')
alter table TAB_PERSONA
   drop constraint FK_TAB_PERS_REFERENCE_TAB_CANT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_PERSONA') and o.name = 'FK_TAB_PERS_REFERENCE_TAB_PROV')
alter table TAB_PERSONA
   drop constraint FK_TAB_PERS_REFERENCE_TAB_PROV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_RAZA') and o.name = 'FK_TAB_RAZA_REFERENCE_TAB_TIPO')
alter table TAB_RAZA
   drop constraint FK_TAB_RAZA_REFERENCE_TAB_TIPO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_REGISTRO_DIARIO') and o.name = 'FK_TAB_REGI_REFERENCE_TAB_FICH')
alter table TAB_REGISTRO_DIARIO
   drop constraint FK_TAB_REGI_REFERENCE_TAB_FICH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_SALIDA_DE_MASCOTA') and o.name = 'FK_TAB_SALI_REFERENCE_TAB_FICH')
alter table TAB_SALIDA_DE_MASCOTA
   drop constraint FK_TAB_SALI_REFERENCE_TAB_FICH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_USUARIOS') and o.name = 'FK_TAB_USUA_REFERENCE_TAB_ROLE')
alter table TAB_USUARIOS
   drop constraint FK_TAB_USUA_REFERENCE_TAB_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TAB_USUARIOS') and o.name = 'FK_TAB_USUA_REFERENCE_TAB_PERS')
alter table TAB_USUARIOS
   drop constraint FK_TAB_USUA_REFERENCE_TAB_PERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CANTONES')
            and   type = 'U')
   drop table TAB_CANTONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CLIENTES')
            and   type = 'U')
   drop table TAB_CLIENTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_CONTROL_MASCOTA')
            and   type = 'U')
   drop table TAB_CONTROL_MASCOTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_FICHA_DE_INGRESO')
            and   type = 'U')
   drop table TAB_FICHA_DE_INGRESO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_MASCOTA')
            and   type = 'U')
   drop table TAB_MASCOTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_MEDICAMENTOS')
            and   type = 'U')
   drop table TAB_MEDICAMENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_MEDICAMENTOS_SUMINISTRADOS')
            and   type = 'U')
   drop table TAB_MEDICAMENTOS_SUMINISTRADOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_MEDICOS')
            and   type = 'U')
   drop table TAB_MEDICOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PERSONA')
            and   type = 'U')
   drop table TAB_PERSONA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_PROVINCIAS')
            and   type = 'U')
   drop table TAB_PROVINCIAS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_RAZA')
            and   type = 'U')
   drop table TAB_RAZA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_REGISTRO_DIARIO')
            and   type = 'U')
   drop table TAB_REGISTRO_DIARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_ROLES')
            and   type = 'U')
   drop table TAB_ROLES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_SALIDA_DE_MASCOTA')
            and   type = 'U')
   drop table TAB_SALIDA_DE_MASCOTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_TIPO_DE_MASCOTA')
            and   type = 'U')
   drop table TAB_TIPO_DE_MASCOTA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TAB_USUARIOS')
            and   type = 'U')
   drop table TAB_USUARIOS
go

/*==============================================================*/
/* Table: TAB_CANTONES                                          */
/*==============================================================*/
create table TAB_CANTONES (
   ID_CANTON            integer              identity,
   ID_PROVINCIA         integer              not null,
   CANTON               varchar(100)         not null,
   constraint PK_TAB_CANTONES primary key (ID_CANTON)
)
go

/*==============================================================*/
/* Table: TAB_CLIENTES                                          */
/*==============================================================*/
create table TAB_CLIENTES (
   ID_PERSONA           integer              not null,
   FECHA_REGISTRO       datetime             not null,
   constraint PK_TAB_CLIENTES primary key (ID_PERSONA)
)
go

/*==============================================================*/
/* Table: TAB_CONTROL_MASCOTA                                   */
/*==============================================================*/
create table TAB_CONTROL_MASCOTA (
   ID_CONTROL_DE_MASCOTA numeric              identity,
   ID_FICHA_INGRESO     integer              not null,
   TIPO_DE_CONTROL      varchar(10)          not null,
   PARAMETRO            varchar(10)          not null,
   RESULTADO            varchar(10)          not null,
   constraint PK_TAB_CONTROL_MASCOTA primary key (ID_CONTROL_DE_MASCOTA)
)
go

/*==============================================================*/
/* Table: TAB_FICHA_DE_INGRESO                                  */
/*==============================================================*/
create table TAB_FICHA_DE_INGRESO (
   ID_FICHA_INGRESO     integer              identity,
   ID_MASCOTA           integer              not null,
   ID_PERSONA           integer              not null,
   FECHA                datetime             not null,
   DESCRIPCION          varchar(20)          not null,
   DIAGNOSTICO          varchar(20)          not null,
   ESTADO               varchar(20)          not null,
   PESO                 numeric(6,2)         not null,
   TEMPERATURA          numeric(4,2)         not null,
   constraint PK_TAB_FICHA_DE_INGRESO primary key (ID_FICHA_INGRESO)
)
go

/*==============================================================*/
/* Table: TAB_MASCOTA                                           */
/*==============================================================*/
create table TAB_MASCOTA (
   ID_MASCOTA           integer              identity,
   ID_PERSONA           integer              not null,
   ID_TIPODEMASCOTA     integer              not null,
   ID_RAZA              integer              not null,
   NOMBRE               varchar(10)          not null,
   COLOR                varchar(10)          not null,
   constraint PK_TAB_MASCOTA primary key (ID_MASCOTA)
)
go

/*==============================================================*/
/* Table: TAB_MEDICAMENTOS                                      */
/*==============================================================*/
create table TAB_MEDICAMENTOS (
   ID_MEDICAMENTO       integer              identity,
   NOMBRE               varchar(300)         not null,
   PRECIO               numeric(6,2)         not null,
   constraint PK_TAB_MEDICAMENTOS primary key (ID_MEDICAMENTO)
)
go

/*==============================================================*/
/* Table: TAB_MEDICAMENTOS_SUMINISTRADOS                        */
/*==============================================================*/
create table TAB_MEDICAMENTOS_SUMINISTRADOS (
   ID_MEDIACAMENTO_SUMINISTRADO integer              identity,
   ID_MEDICAMENTO       integer              not null,
   ID_FICHA_INGRESO     integer              not null,
   FECHA_SUMINISTRO     datetime             not null,
   constraint PK_TAB_MEDICAMENTOS_SUMINISTRA primary key (ID_MEDIACAMENTO_SUMINISTRADO)
)
go

/*==============================================================*/
/* Table: TAB_MEDICOS                                           */
/*==============================================================*/
create table TAB_MEDICOS (
   ID_PERSONA           integer              not null,
   CARGO                varchar(30)          not null,
   FECHA_REGISTRO       datetime             not null,
   constraint PK_TAB_MEDICOS primary key (ID_PERSONA)
)
go

/*==============================================================*/
/* Table: TAB_PERSONA                                           */
/*==============================================================*/
create table TAB_PERSONA (
   ID_PERSONA           integer              identity,
   ID_PROVINCIA         integer              not null,
   ID_CANTON            integer              not null,
   CEDULA               varchar(10)          not null,
   PRIMER_NOMBRE        varchar(15)          not null,
   SEGUNDO_NOMBRE       varchar(15)          not null,
   PRIMER_APELLIDO      varchar(15)          not null,
   SEGUNDO_APELLIDO     varchar(15)          not null,
   DIRECCION_CALLE      varchar(100)         not null,
   DIRECCION_NUMERO     varchar(10)          not null,
   NUMERO_TELEFONO      varchar(15)          not null,
   NUMERO_CELULAR       varchar(15)          not null,
   constraint PK_TAB_PERSONA primary key (ID_PERSONA)
)
go

/*==============================================================*/
/* Table: TAB_PROVINCIAS                                        */
/*==============================================================*/
create table TAB_PROVINCIAS (
   ID_PROVINCIA         integer              identity,
   PROVINCIA            varchar(50)          not null,
   constraint PK_TAB_PROVINCIAS primary key (ID_PROVINCIA)
)
go

/*==============================================================*/
/* Table: TAB_RAZA                                              */
/*==============================================================*/
create table TAB_RAZA (
   ID_RAZA              integer              identity,
   ID_TIPODEMASCOTA     integer              not null,
   TIPO_RAZA            varchar(100)         not null,
   constraint PK_TAB_RAZA primary key (ID_RAZA)
)
go

/*==============================================================*/
/* Table: TAB_REGISTRO_DIARIO                                   */
/*==============================================================*/
create table TAB_REGISTRO_DIARIO (
   ID_REGISTRO_DIARIO   integer              identity,
   ID_FICHA_INGRESO     integer              not null,
   FECHA                date                 not null,
   DIAGNOSTICO          varchar(10)          not null,
   OBSERVACION          varchar(10)          not null,
   PESO                 numeric(3,2)         not null,
   constraint PK_TAB_REGISTRO_DIARIO primary key (ID_REGISTRO_DIARIO)
)
go

/*==============================================================*/
/* Table: TAB_ROLES                                             */
/*==============================================================*/
create table TAB_ROLES (
   ID_ROL               integer              identity,
   ROL                  varchar(30)          not null,
   constraint PK_TAB_ROLES primary key (ID_ROL)
)
go

/*==============================================================*/
/* Table: TAB_SALIDA_DE_MASCOTA                                 */
/*==============================================================*/
create table TAB_SALIDA_DE_MASCOTA (
   ID_FICHA_INGRESO     integer              not null,
   FECHA_DE_ALTA        date                 not null,
   ESTADO               varchar(10)          not null,
   OBSERVACION          varchar(10)          not null,
   CITA                 varchar(10)          not null,
   constraint PK_TAB_SALIDA_DE_MASCOTA primary key (ID_FICHA_INGRESO)
)
go

/*==============================================================*/
/* Table: TAB_TIPO_DE_MASCOTA                                   */
/*==============================================================*/
create table TAB_TIPO_DE_MASCOTA (
   ID_TIPODEMASCOTA     integer              identity,
   TIPO_DE_MASCOTA      varchar(10)          not null,
   constraint PK_TAB_TIPO_DE_MASCOTA primary key (ID_TIPODEMASCOTA)
)
go

/*==============================================================*/
/* Table: TAB_USUARIOS                                          */
/*==============================================================*/
create table TAB_USUARIOS (
   ID_USUARIO           integer              identity,
   ID_ROL               integer              not null,
   ID_PERSONA           integer              not null,
   NOMBRE_USUARIO       varchar(30)          not null,
   CLAVE                varchar(30)          not null,
   constraint PK_TAB_USUARIOS primary key (ID_USUARIO)
)
go

alter table TAB_CANTONES
   add constraint FK_TAB_CANT_REFERENCE_TAB_PROV foreign key (ID_PROVINCIA)
      references TAB_PROVINCIAS (ID_PROVINCIA)
go

alter table TAB_CLIENTES
   add constraint FK_TAB_CLIE_REFERENCE_TAB_PERS foreign key (ID_PERSONA)
      references TAB_PERSONA (ID_PERSONA)
go

alter table TAB_CONTROL_MASCOTA
   add constraint FK_TAB_CONT_REFERENCE_TAB_FICH foreign key (ID_FICHA_INGRESO)
      references TAB_FICHA_DE_INGRESO (ID_FICHA_INGRESO)
go

alter table TAB_FICHA_DE_INGRESO
   add constraint FK_TAB_FICH_REFERENCE_TAB_MEDI foreign key (ID_PERSONA)
      references TAB_MEDICOS (ID_PERSONA)
go

alter table TAB_FICHA_DE_INGRESO
   add constraint FK_TAB_FICH_REFERENCE_TAB_MASC foreign key (ID_MASCOTA)
      references TAB_MASCOTA (ID_MASCOTA)
go

alter table TAB_MASCOTA
   add constraint FK_TAB_MASC_REFERENCE_TAB_RAZA foreign key (ID_RAZA)
      references TAB_RAZA (ID_RAZA)
go

alter table TAB_MASCOTA
   add constraint FK_TAB_MASC_REFERENCE_TAB_TIPO foreign key (ID_TIPODEMASCOTA)
      references TAB_TIPO_DE_MASCOTA (ID_TIPODEMASCOTA)
go

alter table TAB_MASCOTA
   add constraint FK_TAB_MASC_REFERENCE_TAB_CLIE foreign key (ID_PERSONA)
      references TAB_CLIENTES (ID_PERSONA)
go

alter table TAB_MEDICAMENTOS_SUMINISTRADOS
   add constraint FK_TAB_MEDI_REFERENCE_TAB_MEDI foreign key (ID_MEDICAMENTO)
      references TAB_MEDICAMENTOS (ID_MEDICAMENTO)
go

alter table TAB_MEDICAMENTOS_SUMINISTRADOS
   add constraint FK_TAB_MEDI_REFERENCE_TAB_FICH foreign key (ID_FICHA_INGRESO)
      references TAB_FICHA_DE_INGRESO (ID_FICHA_INGRESO)
go

alter table TAB_MEDICOS
   add constraint FK_TAB_MEDI_REFERENCE_TAB_PERS foreign key (ID_PERSONA)
      references TAB_PERSONA (ID_PERSONA)
go

alter table TAB_PERSONA
   add constraint FK_TAB_PERS_REFERENCE_TAB_CANT foreign key (ID_CANTON)
      references TAB_CANTONES (ID_CANTON)
go

alter table TAB_PERSONA
   add constraint FK_TAB_PERS_REFERENCE_TAB_PROV foreign key (ID_PROVINCIA)
      references TAB_PROVINCIAS (ID_PROVINCIA)
go

alter table TAB_RAZA
   add constraint FK_TAB_RAZA_REFERENCE_TAB_TIPO foreign key (ID_TIPODEMASCOTA)
      references TAB_TIPO_DE_MASCOTA (ID_TIPODEMASCOTA)
go

alter table TAB_REGISTRO_DIARIO
   add constraint FK_TAB_REGI_REFERENCE_TAB_FICH foreign key (ID_FICHA_INGRESO)
      references TAB_FICHA_DE_INGRESO (ID_FICHA_INGRESO)
go

alter table TAB_SALIDA_DE_MASCOTA
   add constraint FK_TAB_SALI_REFERENCE_TAB_FICH foreign key (ID_FICHA_INGRESO)
      references TAB_FICHA_DE_INGRESO (ID_FICHA_INGRESO)
go

alter table TAB_USUARIOS
   add constraint FK_TAB_USUA_REFERENCE_TAB_ROLE foreign key (ID_ROL)
      references TAB_ROLES (ID_ROL)
go

alter table TAB_USUARIOS
   add constraint FK_TAB_USUA_REFERENCE_TAB_PERS foreign key (ID_PERSONA)
      references TAB_PERSONA (ID_PERSONA)
go

