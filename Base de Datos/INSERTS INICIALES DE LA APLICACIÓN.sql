USE [DB_AEROPUERTO_PROGRA_III]
GO

INSERT INTO [dbo].[T_Estados] ([IdEstado],[Descripcion]) VALUES ('A', 'Activo');
INSERT INTO [dbo].[T_Estados] ([IdEstado],[Descripcion]) VALUES ('I', 'Inactivo');

INSERT INTO [dbo].[T_Aerolineas] ([NombreAerolinea],[IdEstado]) VALUES ('Copa Airlines','A');
INSERT INTO [dbo].[T_Aerolineas] ([NombreAerolinea],[IdEstado]) VALUES ('Avianca','A');
INSERT INTO [dbo].[T_Aerolineas] ([NombreAerolinea],[IdEstado]) VALUES ('Cubana','A');

INSERT INTO [dbo].[T_TiposEmpleados] ([DescTipo],[IdEstado]) VALUES ('Administrador', 'A');
INSERT INTO [dbo].[T_TiposEmpleados] ([DescTipo],[IdEstado]) VALUES ('Piloto', 'A');
INSERT INTO [dbo].[T_TiposEmpleados] ([DescTipo],[IdEstado]) VALUES ('Mecánico', 'A');
INSERT INTO [dbo].[T_TiposEmpleados] ([DescTipo],[IdEstado]) VALUES ('Conserje', 'A');
INSERT INTO [dbo].[T_TiposEmpleados] ([DescTipo],[IdEstado]) VALUES ('Plataformista', 'A');

INSERT INTO 
  [dbo].[T_Empleados] ([IdEmpleado],[Cedula],[Nombre],[Apellidos],[Direccion],[Edad],[Telefono_Casa],
                       [Telefono_Referencia],[Celular],[Salario],[IdTipoEmpleado],[IdAerolinea],[IdEstado])
VALUES
  ('0000001','1-2354-5467','Adrián','Soto','San José, Guadalupe, Goicoechea ...',29,'2222-2222','2222-2222',
   '8888-8888', 2500000.00,1,1,'A');

INSERT INTO 
  [dbo].[T_Usuarios] ([Username],[Password],[IdEmpleado],[IdEstado])
VALUES
  ('asoto','asoto','0000001','A');