create proc HListele
as begin
select * from Hatlar
end

create proc OListele
as begin
select * from Otobusler
end

create proc YListele
as begin
select * from Yolcular
end

create proc BListele
as begin
select * from Biletler
end


create proc HEkle 
@HatAdi varchar(50),
@HatGuzergahBaslangici varchar(50),
@HatGuzergahBitisi varchar(50)
as begin 
insert into Hatlar(HatAdi,HatGuzergahBaslangici,HatGuzergahBitisi)
values(@HatAdi,@HatGuzergahBaslangici,@HatGuzergahBitisi)
end

create proc OEkle 
@OtobusFirma varchar(50),
@OtobusPlaka varchar(50),
@OtobusTipi varchar(50),
@OtobusKapasite int,
@OtobusSoforAdSoyad varchar(50),
@HatNo int
as begin 
insert into Otobusler(OtobusFirma,OtobusPlaka,OtobusTipi,OtobusKapasite,OtobusSoforAdSoyad,HatNo)
values(@OtobusFirma,@OtobusPlaka,@OtobusTipi,@OtobusKapasite,@OtobusSoforAdSoyad,@HatNo)
end

create proc YEkle 
@YolcuAdSoyad varchar(50),
@YolcuMail varchar(50),
@YolcuTelefon varchar(50),
@OtobusNo int
as begin 
insert into Yolcular(YolcuAdSoyad,YolcuMail,YolcuTelefon,OtobusNo)
values(@YolcuAdSoyad,@YolcuMail,@YolcuTelefon,@OtobusNo)
end

create proc BEkle 
@YolcuAdSoyad varchar(50),
@YolcuKoltukNo int,
@OtobusTipi varchar(50),
@OtobusFirma varchar(50),
@OtobusKalkisYeri varchar(50),
@OtobusVarisYeri varchar(50),
@OtobusKalkisZamani varchar(50),
@OtobusVarisZamani varchar(50),
@OtobusKalkisTarihi varchar(50),
@OtobusVarisTarihi varchar(50),
@BiletFiyati int,
@YolcuNo int
as begin 
insert into Biletler(YolcuAdSoyad,YolcuKoltukNo,OtobusTipi,OtobusFirma,OtobusKalkisYeri,OtobusVarisYeri,OtobusKalkisZamani,OtobusVarisZamani,OtobusKalkisTarihi,OtobusVarisTarihi,BiletFiyati,YolcuNo)
values(@YolcuAdSoyad,@YolcuKoltukNo,@OtobusTipi,@OtobusFirma,@OtobusKalkisYeri,@OtobusVarisYeri,@OtobusKalkisZamani,@OtobusVarisZamani,@OtobusKalkisTarihi,@OtobusVarisTarihi,@BiletFiyati,@YolcuNo)
end

create proc HYenile
@HatNo int,
@HatAdi varchar(50),
@HatGuzergahBaslangici varchar(50),
@HatGuzergahBitisi varchar(50)
as begin 
update Hatlar set HatAdi=@HatAdi,HatGuzergahBaslangici=@HatGuzergahBaslangici,@HatGuzergahBitisi=@HatGuzergahBitisi where HatNo=@HatNo
end

create proc OYenile
@OtobusNo int,
@OtobusFirma varchar(50),
@OtobusPlaka varchar(50),
@OtobusTipi varchar(50),
@OtobusKapasite int,
@OtobusSoforAdSoyad varchar(50),
@HatNo int
as begin 
update Otobusler set OtobusFirma=@OtobusFirma,OtobusPlaka=@OtobusPlaka,OtobusTipi=@OtobusTipi,OtobusKapasite=@OtobusKapasite,OtobusSoforAdSoyad=@OtobusSoforAdSoyad,HatNo=@HatNo where OtobusNo=@OtobusNo
end

create proc YYenile
@YolcuNo int,
@YolcuAdSoyad varchar(50),
@YolcuMail varchar(50),
@YolcuTelefon varchar(50),
@OtobusNo int
as begin 
update Yolcular set YolcuAdSoyad=@YolcuAdSoyad,YolcuMail=@YolcuMail,YolcuTelefon=@YolcuTelefon,OtobusNo=OtobusNo where YolcuNo=@YolcuNo
end

create proc BYenile
@BiletNo int,
@YolcuAdSoyad varchar(50),
@YolcuKoltukNo int,
@OtobusTipi varchar(50),
@OtobusFirma varchar(50),
@OtobusKalkisYeri varchar(50),
@OtobusVarisYeri varchar(50),
@OtobusKalkisZamani varchar(50),
@OtobusVarisZamani varchar(50),
@OtobusKalkisTarihi varchar(50),
@OtobusVarisTarihi varchar(50),
@BiletFiyati int,
@YolcuNo int
as begin 
update Biletler set YolcuAdSoyad=@YolcuAdSoyad,YolcuKoltukNo=@YolcuKoltukNo,OtobusTipi=@OtobusTipi,OtobusFirma=@OtobusFirma,OtobusKalkisYeri=@OtobusKalkisYeri,OtobusVarisYeri=OtobusVarisYeri,@OtobusKalkisZamani=@OtobusKalkisZamani,OtobusVarisZamani=@OtobusVarisZamani,OtobusKalkisTarihi=@OtobusKalkisTarihi,OtobusVarisTarihi=@OtobusVarisTarihi,BiletFiyati=@BiletFiyati,YolcuNo=@YolcuNo where BiletNo=@BiletNo
end

create proc HSil
@HatNo int
as begin 
delete from Hatlar where HatNo=@HatNo
end

create proc OSil
@OtobusNo int
as begin 
delete from Otobusler where OtobusNo=@OtobusNo
end

create proc YSil
@YolcuNo int
as begin 
delete from Yolcular where YolcuNo=@YolcuNo
end

create proc BSil
@BiletNo int
as begin 
delete from Biletler where BiletNo=@BiletNo
end