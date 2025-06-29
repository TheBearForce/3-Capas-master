# 3-Capas-master

La aplicación ContactsApp es un ejemplo clásico de arquitectura en capas en C#. Esta estructura divide el proyecto en varias capas para separar responsabilidades y facilitar el mantenimiento del código:

* Data Layer (ContactsApp.Data) - Maneja el acceso a datos y define las entidades del dominio.
* Business Layer (ContactsApp.Business) - Implementa la lógica de negocio, reglas y validaciones.
* UI Layer (ContactsApp.UI) - Proporciona la interfaz de usuario (WinForms o WPF).
  
El objetivo es crear una aplicación de gestión de contactos que permita agregar, editar, eliminar y listar contactos, manteniendo una separación clara entre datos, lógica de negocio y presentación.

1. Crear Entidades (ContactsApp.Data)
2. Agregar Entidades y Repositorios en ContactsApp.Data.
3. Crear los Servicios en ContactsApp.Business.
4. Diseñar la Interfaz Gráfica en ContactsApp.UI.

* Estructura del proyecto
  
ContactsApp
├── ContactsApp.Data       # Entidades y acceso a datos
├── ContactsApp.Business   # Lógica de negocio
└── ContactsApp.UI         # Interfaz de usuario (WinForms)
