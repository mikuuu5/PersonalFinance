USE [PF]
GO

/****** Object:  Table [dbo].[FinanceExpenditure]  ��֧��ϸ��  Script Date: 02/10/2011 11:46:43 ******/
if exists (select * from sysobjects where id = object_id(N'[FinanceExpenditure]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FinanceExpenditure] 

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FinanceExpenditure](
	[fiExpId] [int] IDENTITY(1,1) NOT NULL,
	[fiMbrId] [smallint] NOT NULL,
	[fiActId] [smallint] NOT NULL,
	[fiCatId] [int] NOT NULL,
	[fiExpDate] [datetime] NOT NULL,
	[fiExpName] [nvarchar](50) NULL,
	[fiExpMoney] [money] NOT NULL,
	[fiExpAddress] [nvarchar](200) NULL,
	[fiExpDescription] [nvarchar](500) NULL,
	[fiExpRemark] [nvarchar](2000) NULL,
	[fiExpStatus] [tinyint] NULL,
	[fiExpEditDate] [datetime] NULL,
	[fiExpEditCount] [int] NULL,
	[fiExpBkFd01] [int] NULL,
	[fiExpBkFd02] [tinyint] NULL,
	[fiExpBkFd03] [varchar](50) NULL,
 CONSTRAINT [PK_FinanceExpenditure] PRIMARY KEY CLUSTERED 
(
	[fiExpId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ϵͳ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiMbrId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiActId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiCatId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��¼ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpMoney'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧�ص�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpAddress'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpDescription'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpRemark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpStatus'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpEditDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸Ĵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpEditCount'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�01' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpBkFd01'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�02' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpBkFd02'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�03' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure', @level2type=N'COLUMN',@level2name=N'fiExpBkFd03'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��֧��ϸ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'FinanceExpenditure'
GO

ALTER TABLE [dbo].[FinanceExpenditure]  WITH CHECK ADD  CONSTRAINT [FK_FinanceExpenditure_FinanceAccounts] FOREIGN KEY([fiActId])
REFERENCES [dbo].[FinanceAccounts] ([fiActId])
GO

ALTER TABLE [dbo].[FinanceExpenditure] CHECK CONSTRAINT [FK_FinanceExpenditure_FinanceAccounts]
GO

ALTER TABLE [dbo].[FinanceExpenditure]  WITH CHECK ADD  CONSTRAINT [FK_FinanceExpenditure_FinanceCategory] FOREIGN KEY([fiCatId])
REFERENCES [dbo].[FinanceCategory] ([fiCatId])
GO

ALTER TABLE [dbo].[FinanceExpenditure] CHECK CONSTRAINT [FK_FinanceExpenditure_FinanceCategory]
GO

ALTER TABLE [dbo].[FinanceExpenditure]  WITH CHECK ADD  CONSTRAINT [FK_FinanceExpenditure_FinanceMember] FOREIGN KEY([fiMbrId])
REFERENCES [dbo].[FinanceMember] ([fiMbrId])
GO

ALTER TABLE [dbo].[FinanceExpenditure] CHECK CONSTRAINT [FK_FinanceExpenditure_FinanceMember]
GO

ALTER TABLE [dbo].[FinanceExpenditure] ADD  CONSTRAINT [DF_FinanceExpenditure_fiExpDate]  DEFAULT (getdate()) FOR [fiExpDate]
GO

ALTER TABLE [dbo].[FinanceExpenditure] ADD  CONSTRAINT [DF_FinanceExpenditure_fiExpStatus]  DEFAULT ((1)) FOR [fiExpStatus]
GO

ALTER TABLE [dbo].[FinanceExpenditure] ADD  CONSTRAINT [DF_FinanceExpenditure_fiExpEditDate]  DEFAULT (getdate()) FOR [fiExpEditDate]
GO


