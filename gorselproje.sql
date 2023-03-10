USE [fevzidatabase]
GO
/****** Object:  Table [dbo].[ders]    Script Date: 1/17/2023 11:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ders](
	[dersId] [smallint] IDENTITY(1,1) NOT NULL,
	[dersAd] [varchar](50) NULL,
	[dersKredi] [varchar](50) NULL,
	[dersOkulYonetimID] [smallint] NULL,
 CONSTRAINT [PK_derss] PRIMARY KEY CLUSTERED 
(
	[dersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenci]    Script Date: 1/17/2023 11:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci](
	[ogrenciID] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenciAdSoyad] [varchar](50) NULL,
	[ogrenciKayitTarih] [datetime] NULL,
	[ogrenciDogumTarih] [datetime] NULL,
	[ogrenciBolum] [varchar](50) NULL,
	[ogrenciNo] [varchar](11) NULL,
 CONSTRAINT [PK_ogrenci] PRIMARY KEY CLUSTERED 
(
	[ogrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenciDers]    Script Date: 1/17/2023 11:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenciDers](
	[ogrenciDersID] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenciDers2ID] [smallint] NULL,
	[ogrenciDersOgrenciID] [smallint] NULL,
 CONSTRAINT [PK_ogrenciDers] PRIMARY KEY CLUSTERED 
(
	[ogrenciDersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[okulYonetimT]    Script Date: 1/17/2023 11:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[okulYonetimT](
	[yonetimId] [smallint] IDENTITY(1,1) NOT NULL,
	[yonetimAdSoyad] [varchar](30) NULL,
	[yonetimGorevi] [varchar](30) NULL,
	[yonetimTip] [nchar](10) NULL,
 CONSTRAINT [PK_okulYonetim] PRIMARY KEY CLUSTERED 
(
	[yonetimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ders] ON 

INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (1, N'Kimya', N'12', 4)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (2, N'Cebir', N'3', 5)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (3, N'Fizik', N'4', 4)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (4, N'Oyun Programlama', N'11', 5)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (5, N'OOP', N'8', 6)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (6, N'Python', N'8', 5)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (7, N'Web Programlama', N'8', 6)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (8, N'C#', N'8', 6)
INSERT [dbo].[ders] ([dersId], [dersAd], [dersKredi], [dersOkulYonetimID]) VALUES (9, N'Mantık', N'8', 2)
SET IDENTITY_INSERT [dbo].[ders] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrenci] ON 

INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (2, N'Furkan Cengiz', CAST(N'2020-12-12T00:00:00.000' AS DateTime), CAST(N'2000-12-01T00:00:00.000' AS DateTime), N'Matematik Öğretmenliği', N'144')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (3, N'Kerem Vatan', CAST(N'2020-05-12T00:00:00.000' AS DateTime), CAST(N'2000-05-02T00:00:00.000' AS DateTime), N'Biyokimya', N'255')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (4, N'Süleyman Ozer', CAST(N'2022-12-08T16:57:24.327' AS DateTime), CAST(N'1998-07-25T00:00:00.000' AS DateTime), N'Bilgisayar Programcılığı', N'124')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (5, N'Fatma Aktaş', CAST(N'2019-09-15T00:00:00.000' AS DateTime), CAST(N'1999-02-15T00:00:00.000' AS DateTime), N'Deniz Bilimleri', N'111')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (6, N'Ebru Çakır', CAST(N'2019-02-22T00:00:00.000' AS DateTime), CAST(N'2001-12-02T00:00:00.000' AS DateTime), N'Havacılık', N'412')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (7, N'Yaren Yıldız', CAST(N'2019-11-09T00:00:00.000' AS DateTime), CAST(N'2000-12-25T00:00:00.000' AS DateTime), N'Biyokimya', N'123')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (8, N'Abdullah Yüksel', CAST(N'2020-02-01T00:00:00.000' AS DateTime), CAST(N'2000-09-12T00:00:00.000' AS DateTime), N'Biyokimya', N'242')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (9, N'Emre Koç', CAST(N'2020-11-12T00:00:00.000' AS DateTime), CAST(N'2002-02-14T00:00:00.000' AS DateTime), N'Havacılık', N'515')
INSERT [dbo].[ogrenci] ([ogrenciID], [ogrenciAdSoyad], [ogrenciKayitTarih], [ogrenciDogumTarih], [ogrenciBolum], [ogrenciNo]) VALUES (10, N'Ömer Bozkurt', CAST(N'2022-05-24T00:00:00.000' AS DateTime), CAST(N'2022-05-24T00:00:00.000' AS DateTime), N'Bilgisayar ProgramcılığıL', N'873')
SET IDENTITY_INSERT [dbo].[ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrenciDers] ON 

INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (17, 1, 3)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (18, 1, 9)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (19, 7, 4)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (20, 6, 4)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (21, 5, 4)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (22, 2, 4)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (23, 2, 10)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (24, 8, 10)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (25, 7, 10)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (26, 2, 2)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (27, 3, 2)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (28, 9, 2)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (29, 3, 6)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (30, 3, 9)
INSERT [dbo].[ogrenciDers] ([ogrenciDersID], [ogrenciDers2ID], [ogrenciDersOgrenciID]) VALUES (31, 1, 4)
SET IDENTITY_INSERT [dbo].[ogrenciDers] OFF
GO
SET IDENTITY_INSERT [dbo].[okulYonetimT] ON 

INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (2, N'Fevzi Uzun', N'Matematik', N'12        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (3, N'Barış Tavşan', N'Türkçe', N'12        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (4, N'Altay Yılmaz', N'Fizik', N'12        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (5, N'Muhammet Akan', N'Biyoloji', N'12        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (6, N'Ulaş Kaplan', N'Yazılım', N'12        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (7, N'Emrah Atlı', N'Dekan', N'11        ')
INSERT [dbo].[okulYonetimT] ([yonetimId], [yonetimAdSoyad], [yonetimGorevi], [yonetimTip]) VALUES (8, N'Sıla Yoldaş', N'Öğrenci İşleri', N'13        ')
SET IDENTITY_INSERT [dbo].[okulYonetimT] OFF
GO
ALTER TABLE [dbo].[ders]  WITH CHECK ADD  CONSTRAINT [FK_ders_okulYonetimT1] FOREIGN KEY([dersOkulYonetimID])
REFERENCES [dbo].[okulYonetimT] ([yonetimId])
GO
ALTER TABLE [dbo].[ders] CHECK CONSTRAINT [FK_ders_okulYonetimT1]
GO
ALTER TABLE [dbo].[ogrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_ogrenciDers_ders] FOREIGN KEY([ogrenciDers2ID])
REFERENCES [dbo].[ders] ([dersId])
GO
ALTER TABLE [dbo].[ogrenciDers] CHECK CONSTRAINT [FK_ogrenciDers_ders]
GO
ALTER TABLE [dbo].[ogrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_ogrenciDers_ogrenci1] FOREIGN KEY([ogrenciDersOgrenciID])
REFERENCES [dbo].[ogrenci] ([ogrenciID])
GO
ALTER TABLE [dbo].[ogrenciDers] CHECK CONSTRAINT [FK_ogrenciDers_ogrenci1]
GO
