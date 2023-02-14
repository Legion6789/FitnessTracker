CREATE TABLE [dbo].[CycleWorkoutMapping](
	[CycleWorkoutMappingId] [int] IDENTITY(1,1) NOT NULL,
	[CycleId] [int] NOT NULL,
	[WorkoutId] [int] NOT NULL,
	[Ordinal] [int] NOT NULL,
 CONSTRAINT [PK_CycleWorkoutMapping] PRIMARY KEY CLUSTERED 
(
	[CycleWorkoutMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CycleWorkoutMapping]  WITH CHECK ADD  CONSTRAINT [FK_CycleWorkoutMapping_Cycles] FOREIGN KEY([CycleId])
REFERENCES [dbo].[Cycles] ([CycleId])
GO

ALTER TABLE [dbo].[CycleWorkoutMapping] CHECK CONSTRAINT [FK_CycleWorkoutMapping_Cycles]
GO

ALTER TABLE [dbo].[CycleWorkoutMapping]  WITH CHECK ADD  CONSTRAINT [FK_CycleWorkoutMapping_Workouts] FOREIGN KEY([WorkoutId])
REFERENCES [dbo].[Workouts] ([WorkoutId])
GO

ALTER TABLE [dbo].[CycleWorkoutMapping] CHECK CONSTRAINT [FK_CycleWorkoutMapping_Workouts]
GO