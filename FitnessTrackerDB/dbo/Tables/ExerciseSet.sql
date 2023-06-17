CREATE TABLE [dbo].[ExerciseSet](
	[exerciseSetId] [uniqueidentifier] NOT NULL,
	[workoutId] [uniqueidentifier] NOT NULL,
	[exerciseId] [uniqueidentifier] NOT NULL,
	[sets] [int] NOT NULL,
	[targetReps] [int] NOT NULL,
	[targetRPE] [int] NULL,
	[restPeriod] [int] NULL,
 CONSTRAINT [PK_ExerciseSet] PRIMARY KEY CLUSTERED 
(
	[exerciseSetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ExerciseSet]  WITH CHECK ADD  CONSTRAINT [FK_ExerciseSet_Exercise] FOREIGN KEY([exerciseId])
REFERENCES [dbo].[Exercise] ([exerciseId])
GO

ALTER TABLE [dbo].[ExerciseSet] CHECK CONSTRAINT [FK_ExerciseSet_Exercise]
GO

ALTER TABLE [dbo].[ExerciseSet]  WITH CHECK ADD  CONSTRAINT [FK_ExerciseSet_WorkoutTemplate] FOREIGN KEY([workoutId])
REFERENCES [dbo].[WorkoutTemplate] ([workoutId])
GO

ALTER TABLE [dbo].[ExerciseSet] CHECK CONSTRAINT [FK_ExerciseSet_WorkoutTemplate]
GO