
# Aplikacija za organizaciju sportskog događaja


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Niki Hercigonja | nhercigon@foi.hr | 0016138155 | NikiHerc
Antonio De Martini | ademartin@foi.hr | 0016133330 | AntonioDeMartin
Veronika Tvrdy| vtvrdy@foi.hr | 0016142833 | vtvrdy1
Ivana Užarević | iuzarevic@foi.hr | 0016142560 | iiuzarevic

## Opis domene
U ovom projektu bavit ćemo se izgradnjom aplikacije koja će pomoći u organizaciji sportskih događanja. 
Aplikaciju će moći koristiti neregistrirani korisnici u svrhu pretraživanja turnira i događaja koji su prijavljeni u aplikaciju, 
ostalih informacija poput rezultata turnira ili općih informacija vezanih za mogućnosti aplikacije. S druge strane, postoje 2 skupine 
registriranih korisnika. Prva skupina registriranih korisnika su sportske udruge, sportski klubovi i ostale organizacije koje se bave sportskim događanjima.
Pod drugu skupinu spadaju korisnici koji se žele prijaviti za sportske događaje koji su aktualni u aplikaciji. Prijava sportskog događaja mora biti 
odobrena od strane administratora aplikacije. Svaki sportski događaj se dodijeljuje jednom ili više moderatora koji su zaduženi za unos podataka tj.
vođenje evidencije o navedenom događaju (rezultati, statistika itd.). Administrator ima mogućnost pregleda svih sportskih događaja, gdje se odvijaju te
kojem je moderatoru taj sportski događaj dodijeljen. Svrha ove aplikacije je da se olakša organizacija sportskog događaja i ubrza proces prijave, također 
ova aplikacija služi kao promocija tih događaja diljem Hrvatske. 

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Početna stranica | Prikaz svih prijavljenih događaja i pretraživanje timova, igraca, događaja i organizacija.| Niki Hercigonja
F02 | Login i registracija | Registracija u aplikaciju kao neka organizacija koja organizira sportski događaj ili kao obican korisnik koji se može prijaviti za organizirani sportski događaj. Također, regirastracija kao moderator koji u suradnji sa organizatorima upravlja tijek događaja u aplikaciji. | Antonio De Martini
F03 | Pregled korisničkog računa | Svaki korisnik će imati pristup svom korisničkom računu na kojem će biti prikazane osnovne informacije. Moderator će uz to imati popis događaja koje je odradio ili događaje za koje je trenutno zadužen. Korisnik će imati uvid u prijavljene događaje, statistiku te timove kojim pripada. | Ivana Užarević 
F04 | Kreiranje tima | Forma koju ispunjava korisnik koji kreira tim, kada se forma ispuni korisnik dobiva jedinstveni kod koji korisnik prosljeđuje drugim korisnicima koje korisnik želi u svom timu. | Veronika Tvrdy
F05 | Prijava sportskog događaja | Prijaviti sportski događaj mogu samo korisnici koji su prijavljeni kao sportska organizacija. Prijavu će izvršiti tako da popune obrazac za prijavu. Svaka prijava mora biti odobrena od strane administratora. | Ivana Užarević
F06 | Prijava za sportski događaj | Prijavu za sportski događaj mogu napraviti korisnici koji imaju osnovan tim. Prijavu će izvršiti tako da popune obrazac za prijavu | Veronika Tvrdy
F07 | Izvještaji | Izvještaj o odigranom turniru koji se odnosi na općenite informacije o turniru te ishod turnira. Izvještaj o timu koji sadrži općenite informacije o timu te isto tako i informacije o turnirima na kojima su sudjelovali | Ivana Užarević
F08 | Unos rezultata | Forma koju moderator koristi za vrijeme događaja, gdje upisuje rezultate te igrače koji su ostvarili pogodak. | Niki Hercigonja
F09 | Odobravanje sportskog događaja i dodjeljivanje moderatora | Administrator ima prikaz generiranih zahtjeva za određeni događaj, koje on može odobriti ili odbiti, također dodjeljuje moderatora događaju. | Niki Hercigonja
F10 | Generiranje događaja | Moderator na početku događaja odabire strukturu te generira raspored utakmica (po skupinama, eliminacijski turnir itd.) | Antonio De Martini
F11 | Pregled turnira | Forma koja će prikazivati turnire s mogućnošću filtriranja prošlih i onih koji će se tek održati. Turniri su sortirani po datumu s mogućnošću sortiranja po vrsti sporta. Također, postoji opcija da se klikom na nadolazeći događaj može prijaviti na navedeni turnir. Odabirom odigranog turnira se otvara izvještaj s podatcima navedenog turnira. | Antonio De Martini
F12 | Generiranje timova | Korisnik ukoliko nema prethodno dogovoren tim može odabrati opciju da se sam prijavi te će mu se, ukoliko se skupi dovoljno igrača za tim, dodijeliti tim, inače će dobiti povratnu pokruku da se tim nije uspio sastaviti | Veronika Tvrdy


## Tehnologije i oprema

| Alat/tehnologija        | Opis                       |
| ----------------------- | -------------------------- |
| C# i .NET Framework     | Izrada programskog dijela  |
| Microsoft Visual Studio | Izrada programskog dijela  |
| Microsoft SQL Server    | Izrada baze podataka       |
| Windows forms           | GUI biblioteka, frontend   |
| MS Office               | Izrada dokumentacije       |
| Visual Paradigm Online  | Izrada dijagrama           |
| MySQL Workbench         | Izrada skripte za bazu podataka i ERA modela |

Za projektni menadžment ćemo koristiti sam GitHub za sada i u okviru njega postaviti rokove i odrediti faze izrade pojedinog dijela projekta.
