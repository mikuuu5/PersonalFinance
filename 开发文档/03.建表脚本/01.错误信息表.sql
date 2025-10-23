USE [PF]
GO

/****** Object:  Table [dbo].[FinanceError]  ������Ϣ��  Script Date: 02/10/2011 11:43:22 ******/
if exists (select * from sysobjects where id = object_id(N'[FinanceError]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FinanceError] 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FinanceError](
	[errorId] [int] IDENTITY(1,1) NOT NULL,
	[errorDate] [datetime] NOT NULL,
	[errorPage] [varchar](2000) NOT NULL,
	[errorMessage] [varchar](4000) NOT NULL,
	[errortargetSite] [varchar](max) NOT NULL,
	[errorstackTrace] [nvarchar](max) NOT NULL,
	[errorSource] [nvarchar](max) NOT NULL,
	[errorIp] [varchar](300) NOT NULL,
	[errorName] [varchar](20) NOT NULL,
	[errorbkFd01] [int] NULL,
	[errorbkFd02] [tinyint] NULL,
	[errorbkFd03] [varchar](max) NULL,
 CONSTRAINT [PK_FinanceError] PRIMARY KEY CLUSTERED 
(
	[errorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ϵͳ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��¼ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ҳ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorPage'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ϣ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorMessage'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����Ŀ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errortargetSite'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorstackTrace'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorSource'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorIp'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����û�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�01' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorbkFd01'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�02' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorbkFd02'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�03' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError', @level2type=N'COLUMN',@level2name=N'errorbkFd03'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ϣ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceError'
GO

ALTER TABLE [dbo].[FinanceError] ADD  CONSTRAINT [DF_FinanceError_errorDate]  DEFAULT (getdate()) FOR [errorDate]
GO

ALTER TABLE [dbo].[FinanceError] ADD  CONSTRAINT [DF_FinanceError_errorIp]  DEFAULT ('0.0.0.0') FOR [errorIp]
GO

ALTER TABLE [dbo].[FinanceError] ADD  CONSTRAINT [DF_FinanceError_errorName]  DEFAULT ('none') FOR [errorName]
GO


