USE [FitnessTracker]
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'A', N'Arms')
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'ABS', N'Abs')
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'B', N'Back')
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'C', N'Chest')
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'LG', N'Legs')
GO
INSERT [dbo].[BodyParts] ([BodyPartId], [BodyPartName]) VALUES (N'S', N'Shoulders')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'ADLT', N'Anterior Deltoid', N'S')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'BCP', N'Biceps', N'A')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'ERSP', N'Erector Spinae', N'B')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'GLTMX', N'Gluteus Maximus', N'LG')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'GSNM', N'Gastrocnemius', N'LG')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'HAMS', N'Hamstrings', N'LG')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'LATS', N'Latissimus Dorsi', N'B')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'LDLT', N'Lateral Deltoid', N'S')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'OBLQ', N'Obliques', N'ABS')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'PCM', N'Pectoralis Major', N'C')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'PDLT', N'Posterior Deltoid', N'S')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'QUAD', N'Quadriceps', N'LG')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'RABS', N'Rectus Abdominis', N'ABS')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'RHOM', N'Rhomboids', N'B')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'SOLE', N'Soleus', N'LG')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'TCP', N'Triceps', N'A')
GO
INSERT [dbo].[Muscles] ([MuscleId], [MuscleName], [BodyPartId]) VALUES (N'TRAP', N'Trapezius', N'B')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'BBBC', N'Barbell Bicep Curl')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'BBBP', N'Barbell Bench Press')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'BBIP', N'Barbell Incline Press')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'CC', N'Cable Cross')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'CCDH', N'Cable Curl D-Handle')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'CLR', N'Cable Lateral Raise')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'CRD', N'Cable Rear Delt')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'DBL', N'Dumbbell Lunges')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'DBRW', N'Dumbbell Row')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'FP', N'Face Pull')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'GSRP', N'Grip Strength Rack Pull')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'HSHR', N'Hammer Strength High Row')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'HSIP', N'Hammer Strength Incline Press')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'IDBC', N'Incline Dumbbell Curl')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'LBXT', N'Low Back Extension')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'LGPR', N'Leg Press')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'LGR', N'Leg Raise')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'LGXT', N'Leg Extension')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'MDP', N'Machine Dip')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'PCRLMN', N'Preacher Curl Machine')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'RDL', N'Romanian Deadlift')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'RPXT', N'Rope Extension')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SACXT', N'Single Arm Cable Extension')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SETC', N'Seated Calf Raise')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SLAT', N'Seated Dumbbell Laterals')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SLC', N'Seated Leg Curl')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SLGXT', N'Single Leg Extension')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SMSP', N'Smith Machine Shoulder Press')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'SRLR', N'Seated Row Lateral Raise')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'STCR', N'Standing Calf Raise')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'TBR', N'T-Bar Row')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'WABS', N'Weighted Abs')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'WC', N'Wrist Curl')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'WCHUP', N'Weighted Chin Up')
GO
INSERT [dbo].[Exercises] ([ExerciseId], [ExerciseName]) VALUES (N'WDCP', N'Wood Chopper')
GO
SET IDENTITY_INSERT [dbo].[ExerciseMuscleMapping] ON 
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (1, N'BBBC', N'BCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (2, N'BBBP', N'PCM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (3, N'BBIP', N'PCM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (4, N'CC', N'PCM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (5, N'CCDH', N'BCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (6, N'CLR', N'LDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (7, N'CRD', N'PDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (8, N'DBL', N'QUAD')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (9, N'DBL', N'GLTMX')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (10, N'DBRW', N'LATS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (11, N'DBRW', N'TRAP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (12, N'DBRW', N'RHOM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (13, N'FP', N'PDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (14, N'HSHR', N'LATS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (15, N'HSIP', N'PCM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (16, N'IDBC', N'BCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (17, N'LBXT', N'ERSP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (18, N'LGPR', N'QUAD')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (19, N'LGPR', N'GLTMX')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (21, N'LGR', N'RABS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (22, N'LGXT', N'QUAD')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (23, N'MDP', N'TCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (24, N'MDP', N'PCM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (25, N'PCRLMN', N'BCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (26, N'RDL', N'HAMS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (27, N'RPXT', N'TCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (28, N'SACXT', N'TCP')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (29, N'SETC', N'SOLE')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (30, N'SETC', N'GSNM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (31, N'SLAT', N'LDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (32, N'SLC', N'HAMS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (33, N'SLGXT', N'QUAD')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (34, N'SMSP', N'ADLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (35, N'SMSP', N'LDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (36, N'SRLR', N'LDLT')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (37, N'STCR', N'GSNM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (38, N'STCR', N'SOLE')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (39, N'TBR', N'RHOM')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (40, N'TBR', N'LATS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (41, N'WABS', N'RABS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (42, N'WCHUP', N'LATS')
GO
INSERT [dbo].[ExerciseMuscleMapping] ([ExerciseMuscleMappingId], [ExerciseId], [MuscleId]) VALUES (43, N'WDCP', N'OBLQ')
GO
SET IDENTITY_INSERT [dbo].[ExerciseMuscleMapping] OFF
GO
