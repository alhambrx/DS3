# DS3 - Proyecto de Práctica TDD y CI/CD

Objetivo principal es demostrar los conceptos de **Test-Driven Development (TDD)**, **Integración Continua (CI)** y **Despliegue Continuo (CD)** usando un proyecto sencillo.

## Funcionalidad

Por ahora, este proyecto incluye:

- Una clase `Matematicas` con una función para verificar si un número es **perfecto**.
- Los tests unitarios se implementan antes de la función siguiendo TDD.

En el futuro se pueden añadir nuevas funcionalidades como:

- Calcular factorial de un número
- Descomposición en números primos
- Verificar si es un número feliz

## Estructura del proyecto

- `Matematicas/` → Código principal
- `Matematicas.Tests/` → Tests unitarios
- `.github/workflows/` → Pipeline de CI/CD de GitHub Actions

## Ramas del repositorio

- `main` → Rama estable
- `dev` → Rama de desarrollo
- `feature/numero-perfecto` → Rama de la funcionalidad actual
