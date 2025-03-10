USE [DATA_PROCESSING]
GO
/****** Object:  Table [dbo].[Activation]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HardwareID] [nchar](100) NOT NULL,
	[ActivationID] [nchar](150) NOT NULL,
 CONSTRAINT [PK_Activation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advance_settings]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advance_settings](
	[dmarkup] [float] NULL,
	[phar] [bit] NULL,
	[dispatch] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASECURITY]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASECURITY](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Menu] [nchar](100) NULL,
	[LEV1] [bit] NULL,
	[LEV2] [bit] NULL,
	[LEV3] [bit] NULL,
 CONSTRAINT [PK_ASECURITY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](250) NOT NULL,
	[MailingName] [nvarchar](250) NULL,
	[Country] [nvarchar](250) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nchar](200) NULL,
	[State] [nchar](200) NULL,
	[PinCode] [nchar](30) NULL,
	[ContactNo] [nchar](100) NULL,
	[Fax] [nchar](100) NULL,
	[Email] [nchar](200) NULL,
	[Website] [nvarchar](max) NULL,
	[TIN] [nchar](50) NULL,
	[LicenseNo] [nchar](50) NULL,
	[ServiceTaxNo] [nvarchar](max) NULL,
	[CST] [nchar](50) NULL,
	[PAN] [nchar](100) NULL,
	[CurrencyCode] [nchar](10) NULL,
	[Currency] [nchar](100) NULL,
	[Logo] [image] NULL,
	[ShowLogo] [nchar](20) NULL,
	[CapitalAccount] [decimal](18, 5) NULL,
	[NP] [int] NULL,
	[QCode] [nchar](10) NULL,
	[BCode] [nchar](10) NULL,
	[InvoiceHeader] [nchar](50) NULL,
	[ItemWiseVAT] [nchar](10) NULL,
	[QTC] [nvarchar](max) NULL,
	[ZeroPrice] [varchar](50) NULL,
	[BelowCost] [varchar](50) NULL,
	[ActiveBelow] [varchar](50) NULL,
	[patchinter] [bit] NULL,
	[wscalable] [bit] NULL,
	[pscalable] [bit] NULL,
	[MultiCurrencyReceipt] [bit] NULL,
	[ShowMultiCurrency] [bit] NULL,
	[VatNo] [varchar](50) NULL,
	[RevMaxKey] [varchar](200) NULL,
	[ShowDiscount] [bit] NULL,
	[EnableRevMax] [bit] NULL,
	[selnegative] [bit] NULL,
	[cash] [bit] NULL,
	[autoprint] [bit] NULL,
	[autoprintshift] [bit] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[course_code] [varchar](50) NOT NULL,
	[course_name] [varchar](100) NOT NULL,
	[facultyid] [int] NOT NULL,
	[deptid] [int] NOT NULL,
	[program] [varchar](50) NOT NULL,
	[level] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dept]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dept](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[facultyid] [int] NOT NULL,
	[dept] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doz]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doz](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[doz] [nchar](1000) NULL,
	[p_id] [nchar](10) NULL,
	[Code] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailSetting]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServerName] [nchar](150) NOT NULL,
	[SMTPAddress] [nvarchar](250) NOT NULL,
	[Username] [nchar](200) NOT NULL,
	[Password] [nchar](100) NOT NULL,
	[Port] [int] NOT NULL,
	[TLS_SSL_Required] [nchar](10) NOT NULL,
	[IsDefault] [nchar](10) NOT NULL,
	[IsActive] [nchar](10) NOT NULL,
 CONSTRAINT [PK_EmailSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[faculty]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[faculty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[faculty] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Level]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Level](
	[LevelID] [int] IDENTITY(1,1) NOT NULL,
	[LevelName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Levels]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Levels](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Level] [varchar](50) NOT NULL,
	[code] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](100) NOT NULL,
	[Operation] [nvarchar](250) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[UserID] [nchar](100) NOT NULL,
	[UserType] [nchar](30) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[Name] [nchar](150) NOT NULL,
	[ContactNo] [nchar](50) NULL,
	[SSN] [nchar](30) NULL,
	[EmailID] [nchar](150) NULL,
	[JoiningDate] [datetime] NOT NULL,
	[Active] [nchar](10) NULL,
	[PayrollType] [nchar](30) NULL,
	[CardNo] [nchar](30) NULL,
	[AllowAccess] [varchar](20) NULL,
	[Quotation] [varchar](20) NULL,
	[BillReprint] [varchar](20) NULL,
	[CreditCustomer] [varchar](20) NULL,
	[SalesReturn] [varchar](20) NULL,
	[SalesList] [varchar](50) NULL,
	[flogin] [bit] NULL,
	[lall] [bit] NULL,
	[pharname] [varchar](100) NULL,
	[Plev1] [nchar](50) NULL,
	[Plev3] [nchar](50) NULL,
	[Plev2] [nchar](50) NULL,
	[FacultyId] [int] NULL,
	[DeptId] [int] NULL,
	[LevelId] [int] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[course_id] [int] NOT NULL,
	[userid] [int] NOT NULL,
	[venue_id] [int] NOT NULL,
	[day] [varchar](50) NOT NULL,
	[time_slot] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[session] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseTax] [nchar](20) NOT NULL,
	[SalesTax] [nchar](20) NOT NULL,
 CONSTRAINT [PK_PurchaseSetting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SMSSetting]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SMSSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[APIURL] [nvarchar](max) NOT NULL,
	[IsDefault] [nchar](10) NOT NULL,
	[IsEnabled] [nchar](10) NOT NULL,
 CONSTRAINT [PK_SMSSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venues]    Script Date: 14-Jul-24 3:13:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venues](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[venue_name] [nvarchar](100) NOT NULL,
	[capacity] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_LicenseNo]  DEFAULT ((0.00)) FOR [LicenseNo]
GO
ALTER TABLE [dbo].[Company] ADD  CONSTRAINT [DF_Company_CapitalAccount]  DEFAULT ((0.00)) FOR [CapitalAccount]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [patchinter]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [cash]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [autoprint]
GO
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((1)) FOR [autoprintshift]
GO
ALTER TABLE [dbo].[Registration] ADD  DEFAULT ((1)) FOR [flogin]
GO
ALTER TABLE [dbo].[dept]  WITH CHECK ADD FOREIGN KEY([facultyid])
REFERENCES [dbo].[faculty] ([id])
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Registration] FOREIGN KEY([UserID])
REFERENCES [dbo].[Registration] ([UserID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Registration]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD FOREIGN KEY([venue_id])
REFERENCES [dbo].[Venues] ([id])
GO
