USE [pelatihan_cSharp]
GO
/****** Object:  Table [dbo].[Akun]    Script Date: 27/04/2023 02:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Akun](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[nama] [varchar](50) NOT NULL,
	[jabatan] [varchar](50) NULL,
 CONSTRAINT [PK_Akun] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 27/04/2023 02:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[image] [image] NOT NULL,
	[nama_barang] [varchar](50) NOT NULL,
	[qty] [int] NOT NULL,
	[harga] [money] NOT NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detail_Tagihan]    Script Date: 27/04/2023 02:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detail_Tagihan](
	[id_tagihan] [int] NOT NULL,
	[id_barang] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[subtotal] [money] NOT NULL,
 CONSTRAINT [PK_Detail_Tagihan] PRIMARY KEY CLUSTERED 
(
	[id_tagihan] ASC,
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tagihan]    Script Date: 27/04/2023 02:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tagihan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tanggal] [date] NOT NULL,
	[total] [money] NOT NULL,
 CONSTRAINT [PK_Tagihan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Akun] ([username], [password], [nama], [jabatan]) VALUES (N'admin', N'admin', N'Admin Ganteng', N'Admin')
INSERT [dbo].[Akun] ([username], [password], [nama], [jabatan]) VALUES (N'kasir', N'kasir', N'Kasir', N'Kasir')
INSERT [dbo].[Akun] ([username], [password], [nama], [jabatan]) VALUES (N'manager', N'manager', N'Manager', N'Manager')
GO
ALTER TABLE [dbo].[Detail_Tagihan]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Tagihan_Barang] FOREIGN KEY([id_barang])
REFERENCES [dbo].[Barang] ([id])
GO
ALTER TABLE [dbo].[Detail_Tagihan] CHECK CONSTRAINT [FK_Detail_Tagihan_Barang]
GO
ALTER TABLE [dbo].[Detail_Tagihan]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Tagihan_Tagihan] FOREIGN KEY([id_tagihan])
REFERENCES [dbo].[Tagihan] ([id])
GO
ALTER TABLE [dbo].[Detail_Tagihan] CHECK CONSTRAINT [FK_Detail_Tagihan_Tagihan]
GO
/****** Object:  StoredProcedure [dbo].[CheckUserLogin]    Script Date: 27/04/2023 02:09:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckUserLogin]
    @username VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT * FROM Akun WHERE username = @username AND password = @password)
        SELECT 'Success' AS result, jabatan,nama FROM Akun WHERE username = @username
    ELSE
        SELECT 'Failed' AS result, NULL AS jabatan
END
GO
