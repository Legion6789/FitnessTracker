CREATE TABLE [dbo].[WorkoutExerciseMapping](
	[WorkoutExerciseMappingId] [int] IDENTITY(1,1) NOT NULL,
	[WorkoutId] [int] NOT NULL,
	[ExerciseId] [varchar](6) NOT NULL,
	[Sets] [int] NOT NULL,
	[Reps] [int] NOT NULL,
	[TargetRPE] [int] NULL,
	[RestPeriod] [decimal](3, 2) NULL,
 CONSTRAINT [PK_WorkoutExerciseMapping] PRIMARY KEY CLUSTERED 
(
	[WorkoutExerciseMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WorkoutExerciseMapping]  WITH CHECK ADD  CONSTRAINT [FK_WorkoutExerciseMapping_Exercises] FOREIGN KEY([ExerciseId])
REFERENCES [dbo].[Exercises] ([ExerciseId])
GO

ALTER TABLE [dbo].[WorkoutExerciseMapping] CHECK CONSTRAINT [FK_WorkoutExerciseMapping_Exercises]
GO

ALTER TABLE [dbo].[WorkoutExerciseMapping]  WITH CHECK ADD  CONSTRAINT [FK_WorkoutExerciseMapping_Workouts] FOREIGN KEY([WorkoutId])
REFERENCES [dbo].[Workouts] ([WorkoutId])
GO

ALTER TABLE [dbo].[WorkoutExerciseMapping] CHECK CONSTRAINT [FK_WorkoutExerciseMapping_Workouts]
GO