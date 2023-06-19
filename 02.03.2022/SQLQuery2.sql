--create proc sp_MusterilerINSERT
--(
--	@MusteriAd nvarchar(150), 
--	@MusteriSoyad  nvarchar(150), 
--	@MusteriTCKimlik  nvarchar(150), 
--	@MusteriPasaportNo  nvarchar(150), 
--	@MusteriUnvan  nvarchar(150), 
--	@MusteriYetkiliAdSoyad  nvarchar(150), 
--	@MusteriVergiNo  nvarchar(150), 
--	@MusteriVergiDairesi  nvarchar(150), 
--	@MusteriTelefon  nvarchar(150),
--	@MusteriPosta  nvarchar(150),              
--	@MusteriAdres  nvarchar(150) , 
--	@IlID int, 
--	@IlceID int, 
--	@UlkeID int, 
--	@MusteriAciklama nvarchar(400), 
--	@MusteriKurumsalOK bit, 
--	@DilID int

--)
--as
--begin
--INSERT INTO tbl_Musteriler (MusteriAd, MusteriSoyad, MusteriTCKimlik, 
--MusteriPasaportNo, MusteriUnvan, MusteriYetkiliAdSoyad, MusteriVergiNo, 
--MusteriVergiDairesi, MusteriTelefon, MusteriPosta,MusteriAdres, IlID, 
--IlceID, UlkeID, MusteriAciklama, MusteriKurumsalOK, DilID) 
--VALUES (@MusteriAd, @MusteriSoyad, @MusteriTCKimlik, @MusteriPasaportNo, @MusteriUnvan, @MusteriYetkiliAdSoyad, @MusteriVergiNo, @MusteriVergiDairesi, @MusteriTelefon,@MusteriPosta,              @MusteriAdres, @IlID, @IlceID, @UlkeID, @MusteriAciklama, @MusteriKurumsalOK, @DilID)
--end

--exec sp_MusterilerINSERT ('a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a','a',)



create proc sp_MusterilerUpdate
(
	@MusteriID int,
	@MusteriAd nvarchar(150), 
	@MusteriSoyad  nvarchar(150), 
	@MusteriTCKimlik  nvarchar(150), 
	@MusteriPasaportNo  nvarchar(150), 
	@MusteriUnvan  nvarchar(150), 
	@MusteriYetkiliAdSoyad  nvarchar(150), 
	@MusteriVergiNo  nvarchar(150), 
	@MusteriVergiDairesi  nvarchar(150), 
	@MusteriTelefon  nvarchar(150),
	@MusteriPosta  nvarchar(150),              
	@MusteriAdres  nvarchar(150) , 
	@IlID int, 
	@IlceID int, 
	@UlkeID int, 
	@MusteriAciklama nvarchar(400), 
	@MusteriKurumsalOK bit, 
	@DilID int

)
as
begin
update tbl_Musteriler set MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, MusteriTCKimlik=@MusteriTCKimlik, 
MusteriPasaportNo=@MusteriPasaportNo, MusteriUnvan=@MusteriUnvan, MusteriYetkiliAdSoyad=@MusteriYetkiliAdSoyad, MusteriVergiNo=@MusteriVergiNo, 
MusteriVergiDairesi=@MusteriVergiDairesi, MusteriTelefon=@MusteriTelefon, MusteriPosta=@MusteriPosta,MusteriAdres=@MusteriAdres, IlID=@IlID, 
IlceID=@IlceID, UlkeID=@UlkeID, MusteriAciklama=@MusteriAciklama, MusteriKurumsalOK=@MusteriKurumsalOK, DilID=@DilID where MusteriID=@MusteriID
end