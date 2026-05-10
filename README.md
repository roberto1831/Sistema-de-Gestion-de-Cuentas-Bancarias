# 🏦 BancoNcapas – Sistema de Gestión de Cuentas Bancarias

![.NET](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_Core_MVC-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

> Sistema CRUD para administración de cuentas bancarias, desarrollado con **ASP.NET Core MVC 9** y **arquitectura en 3 capas (3-Tier)**, usando ADO.NET para acceso directo a SQL Server.

---

## 🧱 Arquitectura del Sistema

```
┌─────────────────────────────────────────────┐
│           Capa de Presentación (UI)          │
│         ASP.NET Core MVC + Bootstrap         │
└───────────────────┬─────────────────────────┘
                    │
┌───────────────────▼─────────────────────────┐
│         Capa de Lógica de Negocio (BAL)      │
│           Validaciones y reglas              │
└───────────────────┬─────────────────────────┘
                    │
┌───────────────────▼─────────────────────────┐
│         Capa de Acceso a Datos (DAL)         │
│              ADO.NET + SQL Server            │
└───────────────────┬─────────────────────────┘
                    │
┌───────────────────▼─────────────────────────┐
│                  Entidades                   │
│             Modelos de dominio               │
└─────────────────────────────────────────────┘
```

| Capa | Responsabilidad |
|---|---|
| **UI** | Vistas MVC, formularios, Bootstrap 5.3 |
| **BAL** | Lógica de negocio y validaciones |
| **DAL** | Consultas SQL con ADO.NET |
| **Entity** | Modelos de dominio (CuentaBancaria) |

---

## 🛠️ Tecnologías Utilizadas

| Tecnología | Versión | Uso |
|---|---|---|
| ASP.NET Core MVC | 9.0 | Framework web principal |
| C# | Latest | Lenguaje backend |
| SQL Server | Latest | Base de datos relacional |
| ADO.NET | — | Acceso directo a datos |
| Bootstrap | 5.3 | Estilos y UI responsiva |
| jQuery | Latest | Interactividad frontend |

---

## 🚀 Funcionalidades

| Operación | Descripción |
|---|---|
| ➕ Crear | Registrar nueva cuenta bancaria |
| 🔍 Buscar | Buscar cuenta por número o cliente |
| 📋 Listar | Ver todas las cuentas registradas |
| ✏️ Editar | Modificar datos de una cuenta |
| 🗑️ Eliminar | Eliminar una cuenta del sistema |

---

## 🗃️ Script de Base de Datos

```sql
CREATE TABLE CuentaBancaria (
    NumeroCuenta VARCHAR(50)  PRIMARY KEY,
    Cliente      VARCHAR(150) NOT NULL,
    Descripcion  VARCHAR(250) NOT NULL
);
```

---

## ⚙️ Configuración y Ejecución

### Prerrequisitos
- .NET 9 SDK
- SQL Server (local o remoto)

### Pasos

```bash
# 1. Clonar el repositorio
git clone https://github.com/roberto1831/BancoNcapas.git
cd BancoNcapas

# 2. Ejecutar el script SQL en SQL Server
# (usar el script de la sección anterior)

# 3. Configurar cadena de conexión en appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BancoDB;Trusted_Connection=True;"
  }
}

# 4. Levantar el proyecto
dotnet run
```

---

## 🛠 Mejoras Futuras

- [ ] Migrar acceso a datos de ADO.NET a **Entity Framework Core**
- [ ] Agregar validaciones avanzadas en formularios
- [ ] Implementar autenticación y autorización de usuarios
- [ ] Añadir pruebas unitarias (xUnit / NUnit)
- [ ] Dockerizar el proyecto

---

## 👤 Autor

**Ing. Roberto Toapanta**  
📍 Quito, Ecuador  
🔗 [GitHub](https://github.com/roberto1831) · [LinkedIn](https://linkedin.com/in/roberto1831)

---

## 📄 Licencia

Uso académico / demostrativo. No apto para producción sin revisión de seguridad.
