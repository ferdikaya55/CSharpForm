/*insert into TBL_Musteriler (MusteriAdi,Adres,Telefon)
values ('Oðulcan','Avcýlar','5351234321');

insert into TBL_Urunler (UrunAdi,Fiyati,StokMiktari)
values ('Bardak',20,10);

insert into TBL_Siparisler (SiparisNo,SiparisTarihi,MusteriId)
values ('12347',2021-03-12,3);*/

select * from TBL_Musteriler;
select TBL_Musteriler.Adres from TBL_Musteriler Where MusteriAdi='Ferdi';
select TBL_Urunler.UrunAdi,TBL_Urunler.StokMiktari from TBL_Urunler where Fiyati>150;
select * from TBL_Urunler order by Fiyati desc;
select count(*) as [Ürün Sayýsý] from TBL_Urunler;
-- group by datalara bak tekrar etmeyecek þekilde listele.
select TBL_Siparisler.MusteriId,count(*) from TBL_Siparisler group by MusteriId;

select * 
from TBL_Siparisler
inner join TBL_Musteriler 
on TBL_Siparisler.MusteriId = TBL_Musteriler.MusteriId;

select TBL_Siparisler.SiparisNo,TBL_Musteriler.MusteriAdi,TBL_Musteriler.Adres 
from TBL_Siparisler 
inner join TBL_Musteriler 
on TBL_Siparisler.MusteriId = TBL_Musteriler.MusteriId;

select *
from TBL_Urunler u
inner join TBL_Siparis_Detay sd
on u.UrunId = sd.UrunId;

select *
from TBL_Musteriler m
left join TBL_Siparisler s
on m.MusteriId = s.MusteriId;

select *
from TBL_Musteriler m
left join TBL_Siparisler s
on m.MusteriId = s.MusteriId
where s.MusteriId is null;
