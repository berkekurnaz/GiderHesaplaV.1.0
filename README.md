# GiderHesaplaV.1.0
Visual Studio 2013 Geliştirme Ortamında C# İle Yazılmış 'Gider Hesapla' Masaüstü Uygulamasıdır...

## Kurulum
##### 1-) 'DboGiderHesapla' Adında Veritabanı Olusturun.

##### 2-) sqlbaglantisi.cs'de Bulunan Veritabanı Yolunu Kendi Veritabani Yolunuz Ile Degistirin.

##### 3-) Giderler Tablosu Olusturun.

CREATE TABLE TBL_GIDERLER(
   id INT IDENTITY(1,1) NOT NULL,
   GUN VARCHAR (5),
   AY VARCHAR (5),     
   YIL VARCHAR (5), 
   HARCAMA VARCHAR (20), 
   ARAC VARCHAR (20), 
   TUTAR FLOAT, 
   DETAY VARCHAR (150) ,      
   PRIMARY KEY (id)
);

##### 4-) Gelirler Tablosu Olusturun.

CREATE TABLE TBL_GELIRLER(
   id INT IDENTITY(1,1) NOT NULL,
   AY VARCHAR (5),     
   YIL VARCHAR (5), 
   TUTAR FLOAT, 
   GELIRNOT VARCHAR (150) ,      
   PRIMARY KEY (id)
);

##### 5-) Notlar Tablosu Olusturun.

CREATE TABLE TBL_NOTLAR(
   id INT IDENTITY(1,1) NOT NULL,
   GUN VARCHAR (5),
   AY VARCHAR (5),     
   YIL VARCHAR (5), 
   NOTBASLIK VARCHAR (150) ,  
   NOTICERIK VARCHAR (150) ,      
   PRIMARY KEY (id)
);

##### 6-) Kullanıcı Tablosu Olusturun.

CREATE TABLE TBL_KULLANICI(
   id INT IDENTITY(1,1) NOT NULL,
   KULLANICI VARCHAR (30),   
   PRIMARY KEY (id)
);

## Kullanım
1-) Harcama Ekleme-Güncelleme-Silme İle Harcamalarınızı Düzenleyebilirsiniz.
2-) Belirli Tarihteki Harcamaları Listeleyebilir Ve O Tarihteki Günlük Harcamanızı,Aylık Harcamanızı,Yıllık Harcamanızı,En Çok Harcama Yaptığınız Alanı Ve En Çok Kullandığınız Harcama Aracınızı Görebilirsiniz.
3-) Notlar Paneli İle Not Ekleyebilir ve Belirli Tarihlerde Yazmış Olduğunuz Notları Görüntüleyebilirsiniz.
4-) Gelirler Paneli İle Her Ay İçin Gelirinizi Ekleyebilir Ve Ana Ekranda Gelirler Ve Giderler Sonucu Hesaplanan Kar Durumunuzu İnceleyebilirsiniz.
5-)Raporlama İle Verileri Yazdırabilir,PDF Olarak Dışarı Aktarabilirsiniz.

## İletişim
bkoyunberkekurnaz@hotmail.com

