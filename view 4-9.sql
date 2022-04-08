use kucni_budzet

select * from promet_v 

create view promet_v as
select datum, osoba.naziv as osoba, novcanik.naziv as novcanik,
trosak.naziv as trosak, org.naziv as org, firma.naziv as firma,
ulaz, izlaz
from promet
join osoba on osoba.id = promet.osoba
join novcanik on novcanik.id = promet.novcanik
join trosak on trosak.id = promet.trosak
join org on org.id = promet.org
left join firma on firma.id = promet.firma