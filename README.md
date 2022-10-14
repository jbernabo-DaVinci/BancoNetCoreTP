# BancoNetCoreTP es un proycto realizado en la asignatura Plataformas de Desarrollo de Escuela DaVinci bajo la guiatura del porfesor Walter Matías Gomez.

# Descripción general del proyecto
Para este trabajo implementaremos una aplicación de Windows Form que simula un Home Banking utilizando C# con .NET Core. 

En dicha aplicación podrán registrarse y loguearse diferentes usuarios, a los que se les solicitarán sus datos para crear una nueva cuenta. Usuarios a los cuales, una vez dentro del Home Banking podrán visualizar todas sus cajas de ahorro, los movimientos de sus cuentas, pagos realizados, transferencias, plazos fijos y tarjetas. 

También podrán agregar nuevas cajas de ahorro, eliminarlas y/o modificarlas, gestionar sus pagos, depósitos y transferencias.

Todo esto mediante una interfáz gráfica minimalista y sencilla pero que internamente se sostiene por un código complejo que se rige por los conceptos de la Programación Orientada a Objetos.

Este proyecto es un trabajo de colaboración constante entre sus 4 integrantes:
- Juan E Bernabo
- Nicolas E Bösz
- Paul G Mac Allister
- Francisco G Rivas

# El estado del proyecto:
Actualmente este proyecto cuenta actualmente con una clase denominada Form que es la interfaz gráfica WindowsForm. Esta se encarga de recibir los datos ingresados por el usuario y pasarlos al objeto Banco.

Por su parte, la clase Banco es la principal y más importante clase, ya que en esta están contenidas todas las listas de Usuarios registrados, las listas de Cajas de Ahorro, el listado de Tarjetas y el listado de Plazo Fijo.

A estas instancias, el proyecto cuenta también con los Forms completos de: Cajas de Ahorro, Detalles, Home, Login, Modificar Cajas, Movimientos, Pagos, Retiros, Signup, Transferencias y Usuario, cada uno con sus respectivos archivos .cs y Designer.cs


# Los Requisitos del entorno de desarrollo para la integración


# Una guía para la instalación y funcionamiento
