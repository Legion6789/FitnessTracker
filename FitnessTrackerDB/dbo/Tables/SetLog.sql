CREATE TABLE [dbo].[SetLog](
	[setLogId] [uniqueidentifier] NOT NULL,
	[workoutLogId] [uniqueidentifier] NOT NULL,
	[exerciseId] [uniqueidentifier] NOT NULL,
	[setNumber] [int] NOT NULL,
	[repsAchieved] [int] NOT NULL,
	[weight] [int] NOT NULL,
	[RPE] [int] NULL,
 CONSTRAINT [PK_SetLog] PRIMARY KEY CLUSTERED 
(
	[setLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SetLog]  WITH CHECK ADD  CONSTRAINT [FK_SetLog_Exercise] FOREIGN KEY([exerciseId])
REFERENCES [dbo].[Exercise] ([exerciseId])
GO

ALTER TABLE [dbo].[SetLog] CHECK CONSTRAINT [FK_SetLog_Exercise]
GO

ALTER TABLE [dbo].[SetLog]  WITH CHECK ADD  CONSTRAINT [FK_SetLog_WorkoutLog] FOREIGN KEY([workoutLogId])
REFERENCES [dbo].[WorkoutLog] ([workoutLogId])
GO

ALTER TABLE [dbo].[SetLog] CHECK CONSTRAINT [FK_SetLog_WorkoutLog]
GO