CREATE TABLE [dbo].[ExerciseMuscleMapping](
	[ExerciseMuscleMappingId] [int] IDENTITY(1,1) NOT NULL,
	[ExerciseId] [varchar](6) NOT NULL,
	[MuscleId] [varchar](5) NOT NULL,
 CONSTRAINT [PK_ExerciseMuscleMapping] PRIMARY KEY CLUSTERED 
(
	[ExerciseMuscleMappingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ExerciseMuscleMapping]  WITH CHECK ADD  CONSTRAINT [FK_ExerciseMuscleMapping_Exercises] FOREIGN KEY([ExerciseId])
REFERENCES [dbo].[Exercises] ([ExerciseId])
GO

ALTER TABLE [dbo].[ExerciseMuscleMapping] CHECK CONSTRAINT [FK_ExerciseMuscleMapping_Exercises]
GO

ALTER TABLE [dbo].[ExerciseMuscleMapping]  WITH CHECK ADD  CONSTRAINT [FK_ExerciseMuscleMapping_Muscles] FOREIGN KEY([MuscleId])
REFERENCES [dbo].[Muscles] ([MuscleId])
GO

ALTER TABLE [dbo].[ExerciseMuscleMapping] CHECK CONSTRAINT [FK_ExerciseMuscleMapping_Muscles]
GO