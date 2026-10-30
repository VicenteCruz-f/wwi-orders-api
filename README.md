# ImportersAPI

API REST en .NET para la gestión de pedidos mayoristas, construida sobre la base de datos de ejemplo **WideWorldImporters** de Microsoft.

> **Estado:** en desarrollo. Este README se irá actualizando a medida que avance el proyecto.

## Sobre el proyecto

WideWorldImporters es una distribuidora mayorista ficticia que vende artículos a tiendas. Esta API es su sistema interno de ventas y bodega:

- **Vendedores:** consultan el catálogo, gestionan clientes y registran los pedidos de las tiendas.
- **Bodega:** revisa los pedidos pendientes y registra su preparación (picking).

El foco está en las **reglas de negocio**: precios con ofertas vigentes, límite de crédito de los clientes, validación de stock y estados del pedido.

Es un proyecto personal de portafolio para aplicar lo que estoy aprendiendo de C# y .NET. El backend está escrito a mano; la IA solo se usará como apoyo en el diseño del frontend.

## Tecnologías

- C# y .NET 10
- ASP.NET Core Minimal API
- Entity Framework Core (database-first, sobre una base existente)
- SQL Server

## Arquitectura

Arquitectura limpia en cuatro capas, donde las dependencias apuntan hacia el centro:

| Capa | Responsabilidad |
| --- | --- |
| **Domain** | Entidades y reglas de negocio. No depende de nadie. |
| **Application** | Casos de uso; coordina el dominio y define lo que necesita del exterior. |
| **Infrastructure** | Acceso a la base de datos con Entity Framework. |
| **Api** | Endpoints HTTP. |

## Alcance

### Versión 1
- [ ] Catálogo de productos con filtros y paginación
- [ ] Clientes: CRUD y consulta de crédito disponible
- [ ] Pedidos con sus líneas: crear, editar, cancelar y registrar picking
- [ ] Reportes: ventas por mes, productos más vendidos y ventas por región
- [ ] Manejo de errores y documentación con Swagger

### Versión 2
- [ ] Facturación de pedidos preparados
- [ ] Autenticación con JWT y roles (vendedor y bodega)
- [ ] Pruebas unitarias de las reglas de negocio
- [ ] Docker con SQL Server

### Versión 3
- [ ] Sugerencias de reabastecimiento a proveedores
- [ ] Frontend en Angular

## Base de datos

Usa [WideWorldImporters](https://learn.microsoft.com/en-us/sql/samples/wide-world-importers-what-is), la base de ejemplo de Microsoft para SQL Server. La versión 1 trabaja con 18 de sus tablas, de los esquemas `Sales`, `Warehouse`, `Application` y `Purchasing`.

## Cómo ejecutarlo

Próximamente. Requisitos:

- SDK de .NET 10
- SQL Server con la base WideWorldImporters restaurada

## Autor

Vicente Cruz