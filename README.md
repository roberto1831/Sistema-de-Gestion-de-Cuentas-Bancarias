# 🏦 BancoNcapas

### Sistema de Gestión de Cuentas Bancarias --- Arquitectura en Capas (3-Tier) con ASP.NET Core MVC + SQL Server

![banner](https://raw.githubusercontent.com/github/explore/main/topics/dotnet/dotnet.png)

## 🏷️ Badges

![.NET](https://img.shields.io/badge/.NET-9.0-blueviolet)
![C#](https://img.shields.io/badge/Language-C%23-239120) ![SQL
Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![MVC](https://img.shields.io/badge/Pattern-MVC-brightgreen)
![Arquitectura](https://img.shields.io/badge/Arquitectura-3--Capas-orange)
![Estado](https://img.shields.io/badge/Estado-En%20Desarrollo-yellow)

# 📋 Tabla de Contenidos

-   Descripción del Proyecto
-   Tecnologías
-   Arquitectura del Sistema
-   Estructura del Repositorio
-   Configuración y Ejecución
-   Script de Base de Datos
-   Funcionalidades
-   Mejoras Futuras
-   Autor

## 📝 Descripción del Proyecto

BancoNcapas es un sistema CRUD para la administración de cuentas
bancarias, desarrollado con ASP.NET Core MVC y arquitectura en 3 capas.

## 🧰 Tecnologías

-   ASP.NET Core MVC 9\
-   C#\
-   SQL Server\
-   ADO.NET\
-   Bootstrap 5.3\
-   jQuery

## 🧱 Arquitectura del Sistema

UI → BAL → DAL → Entity

## 📁 Estructura del Repositorio

(Árbol del proyecto)

## ⚙️ Configuración y Ejecución

1.  Clonar repositorio\
2.  Configurar cadena de conexión\
3.  Ejecutar script SQL\
4.  Levantar el proyecto con `dotnet run`

## 🗃️ Script de Base de Datos

    CREATE TABLE CuentaBancaria (
        NumeroCuenta VARCHAR(50) PRIMARY KEY,
        Cliente VARCHAR(150) NOT NULL,
        Descripcion VARCHAR(250) NOT NULL
    );

## 🚀 Funcionalidades

-   Crear\
-   Buscar\
-   Listar\
-   Editar\
-   Eliminar

## 🛠 Mejoras Futuras

-   Migrar a EF Core\
-   Validaciones\
-   Autenticación\
-   Pruebas unitarias

## 👤 Autor

Ing. Roberto Toapanta
