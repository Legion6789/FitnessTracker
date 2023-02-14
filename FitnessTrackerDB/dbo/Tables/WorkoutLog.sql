CREATE TABLE [dbo].[WorkoutLog](
	[WorkoutLogId] [int] IDENTITY(1,1) NOT NULL,
	[WorkoutId] [int] NOT NULL,
	[WorkoutDate] [smalldatetime] NOT NULL,
	[ExerciseId] [varchar](6) NOT NULL,
	[SetNumber] [int] NOT NULL,
	[RepsAchieved] [int] NOT NULL,
	[WeightUsed] [decimal](4, 2) NOT NULL,
	[RestTaken] [decimal](3, 2) NOT NULL,
	[RPE] [int] NULL,
	[Note] [varchar](500) NULL,
 CONSTRAINT [PK_WorkoutLog] PRIMARY KEY CLUSTERED 
(
	[WorkoutLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WorkoutLog]  WITH CHECK ADD  CONSTRAINT [FK_WorkoutLog_Workouts] FOREIGN KEY([WorkoutId])
REFERENCES [dbo].[Workouts] ([WorkoutId])
GO

ALTER TABLE [dbo].[WorkoutLog] CHECK CONSTRAINT [FK_WorkoutLog_Workouts]
GO