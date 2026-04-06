# RentFlow 🚀 

**RentFlow** es una plataforma SaaS (Software as a Service) de alto rendimiento diseñada para la gestión integral de negocios de renta (mobiliario, equipo para eventos y maquinaria ligera). 

Este proyecto ha sido desarrollado como una **solución de grado empresarial** para demostrar la implementación de arquitecturas escalables, manejo de multi-tenancy dinámico y mejores prácticas de ingeniería de software bajo estándares de Clean Code.

---

## 🛠️ Stack Tecnológico

Seleccionado estratégicamente para maximizar la mantenibilidad y el rendimiento:

- **Backend:** .NET 10 Web API
- **Arquitectura:** Clean Architecture + Domain-Driven Design (DDD) Principles
- **Frontend:** Angular 18 + Tailwind CSS
- **Persistencia:** Entity Framework Core (SQL Server / PostgreSQL)
- **Infraestructura:** Docker Containers & GitHub Actions (CI/CD)

---

## 🏗️ Características de Ingeniería (Enterprise Grade)

### 1. Arquitectura Multi-tenant Dinámica
El sistema implementa un aislamiento de datos estricto mediante el uso de subdominios (ej. `cliente1.rentflow.com`). 
- **Aislamiento a nivel de DB:** Todas las consultas incluyen filtros globales por `TenantId` aplicados en la capa de persistencia.
- **Resolución de Inquilinos:** Middleware personalizado para la identificación automática del contexto del cliente en cada petición HTTP.

### 2. Motor de Disponibilidad
Algoritmo avanzado para la gestión de reservas que previene colisiones de fechas y garantiza el control de stock en tiempo real mediante validaciones asíncronas.

---

## 📅 Hoja de Ruta de Desarrollo (Roadmap)

1.  **Fase 1:** Configuración de Clean Architecture, Capa de Dominio y Seguridad JWT.
2.  **Fase 2:** Implementación del Motor Multi-tenant y Gestión de Staff/Usuarios.
3.  **Fase 3:** Catálogos de Inventario, Gestión de Clientes y Directorios.
4.  **Fase 4:** Motor de Reservas, Calendarios Interactivos y Control de Disponibilidad.
5.  **Fase 5:** Dashboard de Analítica (BI), Panel de SuperAdmin y Pipelines de DevOps.
6.  **Fase 6:** Panel de Administración Global (SuperAdmin) y Pipelines de DevOps.

---

## 🚀 Guía de Instalación Local

### Requisitos Previos
- .NET 10 SDK
- Node.js v20+
- Docker Desktop

### Pasos para Ejecutar
1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/JCJOAQUIN/rental-management-platform.git](https://github.com/JCJOAQUIN/rental-management-platform.git)

2. Levantar Infraestructura (DB) y Configuración de Seguridad

Para garantizar la consistencia entre entornos y proteger las credenciales, seguimos este flujo:

Paso A: Definir Credenciales (Docker Compose)
Antes de iniciar, abre el archivo docker-compose.yml en la raíz. Si deseas cambiar la contraseña de administración, ajusta la variable MSSQL_SA_PASSWORD.

Paso B: Levantar el Contenedor
Ejecuta el siguiente comando para iniciar SQL Server 2022:

Bash
docker-compose up -d

Paso C: Configurar la Cadena de Conexión (User Secrets)

Para que la API se comunique con el contenedor sin exponer la contraseña en Git, ejecutamos este comando dentro de la carpeta src/backend/RentFlow.API:

Bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=RentFlowDb;User Id=sa;Password=<TU_CONTRASEÑA>;TrustServerCertificate=True;"

Asegúrate de que <TU_CONTRASEÑA> sea exactamente la misma que definiste en el Paso A.

Paso D: Sincronizar Esquema (Migraciones)
Crea las tablas en tu instancia local:

Bash
dotnet ef database update --project ../RentFlow.Infrastructure --startup-project .

3. Backend: Navegar a src/backend/RentFlow.API y ejecutar dotnet run.

4. Frontend: Navegar a src/frontend/ y ejecutar npm install && ng serve.

📜 Estándares de Calidad
El desarrollo sigue rigurosos estándares de calidad basados en el manual de ingeniería de BridgeByte Technologies (mi firma de consultoría), asegurando:

Principios SOLID: Código desacoplado y altamente testeable.

Conventional Commits: Historial de Git legible y estandarizado.

Clean Code: Enfoque en legibilidad y reducción de deuda técnica.

Desarrollado por Jose Carlos Joaquín Vazquez | Ingeniero en Sistemas Computacionales | Especialista en desarrollo de software