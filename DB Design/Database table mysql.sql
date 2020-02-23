/*create user pkl identified by pkl;
grant dba to pkl;*/

insert into user_aplikasi
values
    ('op', 'operator');
insert into user_aplikasi
values
    ('G', 'GA');
insert into user_aplikasi
values
    ('pur', 'purchasing');
insert into user_aplikasi
values
    ('_dmin', 'admin');


/*User PKL Pass PKL*/
create table USER_APLIKASI
(
    USERNAME varchar(30) not null,
    PASSWORD varchar(30),
    primary key (USERNAME)
);


create table KATEGORI_SPAREPART
(
    KODE_KATEGORI varchar(30) not null,
    NAMA_KATEGORI varchar(50),
    UOM varchar(20),
    UOM_PACKAGING varchar(20),
    SUB_CLASS varchar(40),
    ITEM_CLASS varchar(40),
    QTY_PERPACK numeric(8,0),
    LEAD_TIME numeric(8,0),
    primary key (KODE_KATEGORI)
);



create table SPAREPART
(
    KODE_SPAREPART varchar(30) not null,
    KODE_KATEGORI varchar(30),
    STATUS_SPAREPART varchar(20),
    ITEM_GRADE varchar(20),
    REMARK_SPAREPART varchar(999),
    primary key (KODE_SPAREPART)
);

alter table SPAREPART add constraint FK_RELATIONSHIP_1 foreign key (KODE_KATEGORI)
      references KATEGORI_SPAREPART (KODE_KATEGORI)
on delete restrict on
update restrict;


create table PENGAMBILAN
(
    KODE_SPAREPART varchar(30) not null,
    KODE_PENGAMBILAN varchar(30) not null,
    KODE_KATEGORI varchar(30),
    DATE_PENGAMBILAN varchar(30),
    STATUS_SPAREPARTP varchar(30),
    REMARK_PENGAMBILAN varchar(999),
    primary key (KODE_SPAREPART, KODE_PENGAMBILAN)
);

alter table PENGAMBILAN add constraint FK_RELATIONSHIP_2 foreign key (KODE_SPAREPART)
      references SPAREPART (KODE_SPAREPART)
on delete restrict on
update restrict;

alter table PENGAMBILAN add constraint FK_RELATIONSHIP_3 foreign key (KODE_KATEGORI)
      references KATEGORI_SPAREPART (KODE_KATEGORI)
on delete restrict on
update restrict;


create table SUPPLIER
(
    KODE_SUPPLIER varchar(30) not null,
    NAMA_SUPPLIER varchar(100),
    CONTACT_PERSON varchar(50),
    ALAMAT varchar(100),
    KOTA varchar(30),
    KODE_POS varchar(10),
    TELEPON_SUPPLIER varchar(15),
    FAX varchar(15),
    TIPE_SUPPLIER varchar(40),
    PRODUK_GRUP varchar(40),
    DEFAULT_CURRENCY varchar(20),
    ACCOUNT_AP varchar(100),
    STATUS_SUPPLIER varchar(20),
    REMARK_SUPPLIER varchar(999),
    NPWP varchar(50) not null,
    NAMA_NPWP varchar(50),
    ALAMAT_NPWP varchar(100),
    PAJAK_NPWP varchar(30),
    EMAIL_KONTAK varchar(50) not null,
    NAMA_KONTAK varchar(50),
    DIVISI_KONTAK varchar(50),
    TELEPON_KONTAK varchar(20),
    DESC_AP varchar(100) not null,
    DETAIL_AP varchar(999),
    primary key (KODE_SUPPLIER, NPWP, EMAIL_KONTAK, DESC_AP)
);


create table T_PR
(
    KODE_KATEGORI varchar(30) not null,
    KODE_TRANSAKSIPR varchar(40) not null,
    DATE_PR varchar(30),
    PERMINTAAN_PENGIRIMAN varchar(30),
    PR_TYPE varchar(30),
    SUB_PR_TYPE varchar(30),
    REQ_DEPART varchar(30),
    QTY1 numeric(8,0),
    QTY2 numeric(8,0),
    DESKRIPSI_PR varchar(999),
    REMARK_PR varchar(999),
    STATUS_PR varchar(30),
    primary key (KODE_KATEGORI, KODE_TRANSAKSIPR)
);

alter table T_PR add constraint FK_RELATIONSHIP_6 foreign key (KODE_KATEGORI)
      references KATEGORI_SPAREPART (KODE_KATEGORI)
on delete restrict on
update restrict;


create table T_PO
(
    KODE_KATEGORI varchar(30) not null,
    KODE_TRANSAKSIPR varchar(40) not null,
    KODE_TRANSAKSIPO varchar(40) not null,
    KODE_SUPPLIER varchar(30) not null,
    NPWP varchar(50),
    EMAIL_KONTAK varchar(50),
    DESC_AP varchar(100),
    DATE_PO varchar(20),
    ENTITY_PO varchar(30),
    PO_TYPE varchar(40),
    UP varchar(50),
    TERM varchar(30),
    CURRENCY varchar(20),
    TAX_SCHEME varchar(20),
    PPN numeric(8,0),
    TOTAL_BARANG numeric(8,0),
    TOTAL_SELURUH numeric(8,0),
    DISCOUNT numeric(8,0),
    SHIPPING_ADDRESS varchar(200),
    REMARK_PO varchar(999),
    STATUS_PO varchar(30),
    primary key (KODE_KATEGORI, KODE_TRANSAKSIPR, KODE_TRANSAKSIPO, KODE_SUPPLIER)
);

alter table T_PO add constraint FK_RELATIONSHIP_7 foreign key (KODE_SUPPLIER, NPWP, EMAIL_KONTAK, DESC_AP)
      references SUPPLIER (KODE_SUPPLIER, NPWP, EMAIL_KONTAK, DESC_AP)
on delete restrict on
update restrict;

alter table T_PO add constraint FK_RELATIONSHIP_8 foreign key (KODE_KATEGORI, KODE_TRANSAKSIPR)
      references T_PR (KODE_KATEGORI, KODE_TRANSAKSIPR)
on delete restrict on
update restrict;

create table PENERIMAAN
(
    KODE_KATEGORI varchar(30) not null,
    KODE_TRANSAKSIPR varchar(40) not null,
    KODE_TRANSAKSIPO varchar(40) not null,
    KODE_SUPPLIER varchar(30) not null,
    KODE_PENERIMAAN varchar(40) not null,
    DATE_PENERIMAAN varchar(30),
    DN_VENDOR varchar(40),
    NO_POL varchar(20),
    GRN_QTY1 numeric(8,0),
    GRN_QTY2 numeric(8,0),
    OS_PO numeric(8,0),
    REMARK_PENERIMAAN varchar(999),
    primary key (KODE_KATEGORI, KODE_TRANSAKSIPR, KODE_TRANSAKSIPO, KODE_SUPPLIER, KODE_PENERIMAAN)
);

alter table PENERIMAAN add constraint FK_RELATIONSHIP_9 foreign key (KODE_KATEGORI, KODE_TRANSAKSIPR, KODE_TRANSAKSIPO, KODE_SUPPLIER)
      references T_PO (KODE_KATEGORI, KODE_TRANSAKSIPR, KODE_TRANSAKSIPO, KODE_SUPPLIER)
on delete restrict on
update restrict;

create table TBBARU
(
    KODE_SPAREPART varchar(30),
    KODE_PENGAMBILAN varchar(30),
    TYPE_CODEB text,
    ITEM_CODEB text,
    ITEM_DESCB text
);

alter table TBBARU add constraint FK_RELATIONSHIP_4 foreign key (KODE_SPAREPART, KODE_PENGAMBILAN)
      references PENGAMBILAN (KODE_SPAREPART, KODE_PENGAMBILAN)
on delete restrict on
update restrict;

create table TBLAMA
(
    KODE_SPAREPART varchar(30),
    KODE_PENGAMBILAN varchar(30),
    TYPE_CODEL text,
    ITEM_CODEL text,
    ITEM_DESCL text
);

alter table TBLAMA add constraint FK_RELATIONSHIP_5 foreign key (KODE_SPAREPART, KODE_PENGAMBILAN)
      references PENGAMBILAN (KODE_SPAREPART, KODE_PENGAMBILAN)
on delete restrict on
update restrict;
