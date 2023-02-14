CREATE TABLE [dbo].[Muscles](
	[MuscleId] [varchar](5) NOT NULL,
	[MuscleName] [varchar](100) NOT NULL,
	[BodyPartId] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Muscles] PRIMARY KEY CLUSTERED 
(
	[MuscleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Muscles]  WITH CHECK ADD  CONSTRAINT [FK_Muscles_BodyParts] FOREIGN KEY([BodyPartId])
REFERENCES [dbo].[BodyParts] ([BodyPartId])
GO

ALTER TABLE [dbo].[Muscles] CHECK CONSTRAINT [FK_Muscles_BodyParts]
GO