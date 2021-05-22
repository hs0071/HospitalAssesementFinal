SET IDENTITY_INSERT [dbo].[Hospital] ON
INSERT INTO [dbo].[Hospital] ([Id], [Hospital_Name]) VALUES (1, N'Aman')
INSERT INTO [dbo].[Hospital] ([Id], [Hospital_Name]) VALUES (2, N'Danish')
INSERT INTO [dbo].[Hospital] ([Id], [Hospital_Name]) VALUES (3, N'Preet')
INSERT INTO [dbo].[Hospital] ([Id], [Hospital_Name]) VALUES (4, N'Ishita')
SET IDENTITY_INSERT [dbo].[Hospital] OFF
SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT INTO [dbo].[Doctor] ([Id], [Doctor_Name], [Doctor_Address], [Doctor_Contact]) VALUES (1, N'Sit', N'Auckland', N'022566789')
INSERT INTO [dbo].[Doctor] ([Id], [Doctor_Name], [Doctor_Address], [Doctor_Contact]) VALUES (2, N'Ish', N'Auckland', N'0225676899')
INSERT INTO [dbo].[Doctor] ([Id], [Doctor_Name], [Doctor_Address], [Doctor_Contact]) VALUES (3, N'Dem', N'Auckland', N'0226567879')
INSERT INTO [dbo].[Doctor] ([Id], [Doctor_Name], [Doctor_Address], [Doctor_Contact]) VALUES (4, N'Enh', N'Auckland', N'0225667899')
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON
INSERT INTO [dbo].[Patient] ([Id], [Patient_Name], [Patient_Address], [Patient_Contact], [DoctorID]) VALUES (1, N'Dil', N'Auckland', N'022677889', 1)
INSERT INTO [dbo].[Patient] ([Id], [Patient_Name], [Patient_Address], [Patient_Contact], [DoctorID]) VALUES (2, N'Ind', N'Auckland', N'022656778', 2)
INSERT INTO [dbo].[Patient] ([Id], [Patient_Name], [Patient_Address], [Patient_Contact], [DoctorID]) VALUES (3, N'Sdt', N'Auckland', N'022566778', 3)
INSERT INTO [dbo].[Patient] ([Id], [Patient_Name], [Patient_Address], [Patient_Contact], [DoctorID]) VALUES (4, N'Den', N'Auckland', N'022567878', 4)
SET IDENTITY_INSERT [dbo].[Patient] OFF