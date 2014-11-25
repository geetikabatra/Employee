USE [master]
GO
/****** Object:  Database [EmployeeDatabase]    Script Date: 11/25/2014 10:58:20 PM ******/
CREATE DATABASE [EmployeeDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EmployeeDatabase.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EmployeeDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EmployeeDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EmployeeDatabase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EmployeeDatabase]
GO
/****** Object:  Table [dbo].[skillid_description_empid_map]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[skillid_description_empid_map](
	[skid_skills] [varchar](30) NOT NULL,
	[skid_employee_id] [int] NOT NULL,
 CONSTRAINT [PK_skillid_description_empid_map] PRIMARY KEY CLUSTERED 
(
	[skid_skills] ASC,
	[skid_employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_country_code_name_map]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_country_code_name_map](
	[ccmap_country_code] [varchar](4) NOT NULL,
	[ccmap_country_name] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_country_code_name_map] PRIMARY KEY CLUSTERED 
(
	[ccmap_country_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_designation_map]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_designation_map](
	[designation_description] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_designation_map] PRIMARY KEY CLUSTERED 
(
	[designation_description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_employee_designation_map]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_employee_designation_map](
	[empdes_employee_id] [int] NOT NULL,
	[empdes_designation_description] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_employee_designation_map] PRIMARY KEY CLUSTERED 
(
	[empdes_designation_description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Employee_Details]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Employee_Details](
	[empdet_emp_id] [int] IDENTITY(1,1) NOT NULL,
	[empdet_first_name] [varchar](15) NOT NULL,
	[empdet_middle_name] [varchar](15) NULL,
	[empdet_last_name] [varchar](15) NOT NULL,
	[empdet_in_out_campus] [bit] NOT NULL,
	[empdet_dob] [date] NOT NULL,
	[empdet_date_joined] [date] NOT NULL,
	[empdet_date_left] [date] NULL,
	[empdet_residential_address_line1] [varchar](30) NOT NULL,
	[empdet_residential_address_line2] [varchar](30) NULL,
	[empdet_residential_city] [varchar](20) NOT NULL,
	[empdet_residential_state] [varchar](20) NOT NULL,
	[empdet_residential_address_country] [varchar](30) NOT NULL,
	[empdet_residential_address_pincode] [numeric](6, 0) NOT NULL,
	[empdet_permanent_address_line1] [varchar](30) NULL,
	[empdet_permanent_address_line2] [varchar](30) NULL,
	[empdet_permanent_address_city] [varchar](20) NULL,
	[empdet_permanent_address_state] [varchar](20) NULL,
	[empdet_permanent_address_country] [varchar](30) NULL,
	[empdet_permanent_address_pincode] [numeric](6, 0) NULL,
	[empdet_password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_Employee_Details] PRIMARY KEY CLUSTERED 
(
	[empdet_emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_employee_phone_map]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_employee_phone_map](
	[emphne_employee_id] [int] NOT NULL,
	[emphne_country_code] [varchar](4) NOT NULL,
	[emphne_phone_no] [numeric](15, 0) NOT NULL,
 CONSTRAINT [PK_tbl_employee_phone_map] PRIMARY KEY CLUSTERED 
(
	[emphne_country_code] ASC,
	[emphne_phone_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_skills]    Script Date: 11/25/2014 10:58:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_skills](
	[skill_skill_description] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_skills] PRIMARY KEY CLUSTERED 
(
	[skill_skill_description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_country_code_name_map]    Script Date: 11/25/2014 10:58:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_country_code_name_map] ON [dbo].[tbl_country_code_name_map]
(
	[ccmap_country_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_tbl_employee_designation_map]    Script Date: 11/25/2014 10:58:21 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_employee_designation_map] ON [dbo].[tbl_employee_designation_map]
(
	[empdes_employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [EmployeeDatabase] SET  READ_WRITE 
GO
