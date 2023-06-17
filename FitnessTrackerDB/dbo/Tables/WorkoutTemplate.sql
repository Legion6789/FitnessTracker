CREATE TABLE [dbo].[WorkoutTemplate](
	[workoutId] [uniqueidentifier] NOT NULL,
	[workoutName] [varchar](100) NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_WorkoutTemplate] PRIMARY KEY CLUSTERED 
(
	[workoutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[WorkoutTemplate] ADD  CONSTRAINT [DF_WorkoutTemplate_isDeleted]  DEFAULT ((0)) FOR [isDeleted]
GO