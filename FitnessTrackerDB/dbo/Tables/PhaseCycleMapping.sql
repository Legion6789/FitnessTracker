CREATE TABLE [dbo].[PhaseCycleMapping](
	[PhaseCycleMappingId] [int] IDENTITY(1,1) NOT NULL,
	[PhaseId] [int] NOT NULL,
	[CycleId] [int] NOT NULL,
	[Ordinal] [int] NOT NULL,
 CONSTRAINT [PK_PhaseCycleMapping] PRIMARY KEY CLUSTERED 
(
	[PhaseCycleMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhaseCycleMapping]  WITH CHECK ADD  CONSTRAINT [FK_PhaseCycleMapping_Cycles] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
GO

ALTER TABLE [dbo].[PhaseCycleMapping] CHECK CONSTRAINT [FK_PhaseCycleMapping_Cycles]
GO

ALTER TABLE [dbo].[PhaseCycleMapping]  WITH CHECK ADD  CONSTRAINT [FK_PhaseCycleMapping_Phases] FOREIGN KEY([PhaseId])
REFERENCES [dbo].[Phases] ([PhaseId])
GO

ALTER TABLE [dbo].[PhaseCycleMapping] CHECK CONSTRAINT [FK_PhaseCycleMapping_Phases]
GO