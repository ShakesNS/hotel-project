--create proc sp_MisafirINSERT
--(
--	@MisafirAd				nvarchar(150), 
--	@MisafirSoyad			nvarchar(150), 
--	@MisafirTcKimlik		nvarchar(150),
--	@MisafirDogumTarihi		datetime,
--	@MisafirUyrukId			int , 
--	@MisafirEposta			nvarchar(150), 
--	@MisafirTelefon			nvarchar(150), 
--	@MisafirPasaportNo		nvarchar(150), 
--	@CinsiyetId				int, 
--	@MisafirAdres			nvarchar(400), 
--	@IlId					int, 
--	@IlceId					int , 
--	@UlkeId					int,
--	@MisafirAciklama		nvarchar(400),
--	@MisafirHesKod			nvarchar(150),
--	@dilId					int
--)
--as
--begin
--insert into tbl_Misafir values (@MisafirAd,  
--								@MisafirSoyad ,
--								@MisafirTcKimlik, 
--								@MisafirDogumTarihi,
--								@MisafirUyrukId ,
--								@MisafirEposta ,
--								@MisafirTelefon ,
--								@MisafirPasaportNo ,
--								@CinsiyetId,  
--								@MisafirAdres ,
--								@IlId  ,
--								@IlceId  ,
--								@UlkeId ,
--								@MisafirAciklama ,
--								@MisafirHesKod ,
--								@dilId )

--end	



create proc sp_MisafirUPDATE
(
	@MisafirID				int, 
	@MisafirAd				nvarchar(150), 
	@MisafirSoyad			nvarchar(150), 
	@MisafirTcKimlik		nvarchar(150),
	@MisafirDogumTarihi		datetime,
	@MisafirUyrukId			int , 
	@MisafirEposta			nvarchar(150), 
	@MisafirTelefon			nvarchar(150), 
	@MisafirPasaportNo		nvarchar(150), 
	@CinsiyetId				int, 
	@MisafirAdres			nvarchar(400), 
	@IlId					int, 
	@IlceId					int , 
	@UlkeId					int,
	@MisafirAciklama		nvarchar(400),
	@MisafirHesKod			nvarchar(150),
	@dilId					int
)
as
begin
update tbl_Misafir set MisafirId, , , , , , MisafirTelefon, MisafirPasaportNo, CinsiyetId, MisafirAdres, IlId, IlceId, UlkeId, MisafirAciklama, MisafirHesKod, dilId
								(MisafirAd=@MisafirAd,  
								MisafirSoyad=@MisafirSoyad ,
								MisafirTcKimlik=@MisafirTcKimlik, 
								MisafirDogumTarihi=@MisafirDogumTarihi,
								MisafirUyrukId=@MisafirUyrukId ,
								MisafirEposta=@MisafirEposta ,
								@MisafirTelefon ,
								@MisafirPasaportNo ,
								@CinsiyetId,  
								@MisafirAdres ,
								@IlId  ,
								@IlceId  ,
								@UlkeId ,
								@MisafirAciklama ,
								@MisafirHesKod ,
								@dilId )

end	
