create table smer (
    id int primary key identity,
    naziv varchar(100)
);
create table skolska_godina (
    id int primary key identity,
    naziv varchar(50)
);

create table predmet (
    id int primary key identity,
    naziv varchar(100),
    razred int
);

create table osoba (
    id int primary key identity,
    ime varchar(50),
    prezime varchar(50),
    adresa varchar(100),
    jmbg varchar(20),
    email varchar(100),
    pass varchar(100),
    uloga varchar(20)
);

create table odeljenje (
    id int primary key identity,
    razred int,
    naziv varchar(10),
    smer_id int,
    razredni_id int,
    godina_id int,

    foreign key (smer_id) references smer(id),
    foreign key (razredni_id) references osoba(id),
    foreign key (godina_id) references skolska_godina(id)
);

create table upisnica (
    id int primary key identity,
    osoba_id int,
    odeljenje_id int,

    foreign key (osoba_id) references osoba(id),
    foreign key (odeljenje_id) references odeljenje(id)
);

create table raspodela (
    id int primary key identity,
    nastavnik_id int,
    godina_id int,
    predmet_id int,
    odeljenje_id int,

    foreign key (nastavnik_id) references osoba(id),
    foreign key (godina_id) references skolska_godina(id),
    foreign key (predmet_id) references predmet(id),
    foreign key (odeljenje_id) references odeljenje(id)
);

create table ocena (
    id int primary key identity,
    datum date,
    raspodela_id int,
    ocena int,
    ucenik_id int,

    foreign key (raspodela_id) references raspodela(id),
    foreign key (ucenik_id) references osoba(id)
);