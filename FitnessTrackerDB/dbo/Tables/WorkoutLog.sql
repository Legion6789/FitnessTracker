CREATE TABLE [dbo].[WorkoutLog](
	[workoutLogId] [uniqueidentifier] NOT NULL,
	[workoutId] [uniqueidentifier] NOT NULL,
	[workoutDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_WorkoutLog] PRIMARY KEY CLUSTERED 
(
	[workoutLogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WorkoutLog]  WITH CHECK ADD  CONSTRAINT [FK_WorkoutLog_WorkoutTemplate] FOREIGN KEY([workoutId])
REFERENCES [dbo].[WorkoutTemplate] ([workoutId])
GO

ALTER TABLE [dbo].[WorkoutLog] CHECK CONSTRAINT [FK_WorkoutLog_WorkoutTemplate]
GO