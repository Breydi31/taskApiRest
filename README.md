# API de Gestión de Tareas

API RESTful construida con .NET 8 y SQLite para gestionar la lista de tareas.

## 📋 Funcionalidades

- Crear, listar, actualizar y eliminar tareas.
- Almacenamiento de base de datos.
- Vallidaciones básicas de entrada.

## ⚙ Requisitos

- .NET 8 SDK
- Git

## 📑 Instrucciones para ejecutar el proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/Breydi31/taskApiRest.git
cd taskApiRest
```

### 2. Restaurar paquetes

```bash
dotnet restore
```

### 3. Ejecutar la API

```bash
dotnet run
```

## 📢 Ejemplos de Endpoints

### GET /api/task

**Descripción:** Lista todas las tareas
**Response:**

```json
{
    "data": [{ ...Lista }],
    "mensaje": "Tareas listadas correctamente",
    "statusCode": 200
}
```

### GET /api/task/{id}

**Descripción:** Lista una tarea por ID
**Response:**

```json
{
    "data": { ...Tarea },
    "mensaje": "Tarea listada correctamente",
    "statusCode": 200
}
```

### POST /api/task

**Descripción:** Crear tarea
**Request:**

```json
{
    "titulo": string,
    "descripcion": string,
    "estado": string
}
```

**Response:**

```json
{
    "data": { ...TareaCreada },
    "mensaje": "Tarea creada exitosamente",
    "statusCode": 200
}
```

### PUT /api/task/{id}

**Descripción:** Actualizar una tarea por ID.
**Request:**

```json
{
    "titulo": string,
    "descripcion": string,
    "estado": string
}
```

**Response:**

```json
{
    "data": { ...TareaActualizada },
    "mensaje": "Tarea actualizada exitosamente",
    "statusCode": 200
}
```

### DELETE /api/task/{id}

**Descripción:** Eliminar una tarea por ID.
**Response:**

```json
{
  "data": null,
  "mensaje": "Tareas obtenidas correctamente",
  "statusCode": 200
}
```
