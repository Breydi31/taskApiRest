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

git clone https://github.com/Breydi31/taskApiRest.git
cd taskApiRest

### 2. Restaurar paquetes

dotnet restore

### 3. Ejecutar la API

dotnet run

## 📢 Ejemplos de Endpoints

### GET /api/task

Descripción: Lista todas las tareas
Response:
{
"data": [{ ...Lista }],
"mensaje": "Tareas listadas correctamente",
"statusCode": 200
}

### GET /api/task/{id}

Descripción: Lista una tarea por ID
Response:
{
"data": { ...Tarea },
"mensaje": "Tarea listada correctamente",
"statusCode": 200
}

### POST /api/task

Descripción: Crear tarea
Request:
{
"titulo": string,
"descripcion": string,
"estado": string
}

Response:
{
"data": { ...TareaCreada },
"mensaje": "Tarea creada exitosamente",
"statusCode": 200
}

### PUT /api/task/{id}

Descripción: Actualizar una tarea por ID.
Request:
{
"titulo": string,
"descripcion": string,
"estado": string
}

Response:
{
"data": { ...TareaActualizada },
"mensaje": "Tarea actualizada exitosamente",
"statusCode": 200
}

### DELETE /api/task/{id}

Descripción: Eliminar una tarea por ID.
Response:
{
"data": null,
"mensaje": "Tareas obtenidas correctamente",
"statusCode": 200
}
