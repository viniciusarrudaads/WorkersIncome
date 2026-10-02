# Sistema de Gerenciamento de Trabalhadores

Projeto desenvolvido em C# para praticar conceitos de Programação Orientada a Objetos (POO), utilizando trabalhadores, departamentos e contratos por hora.

## Sobre o projeto

O sistema permite cadastrar trabalhadores associados a um departamento, definir seu nível profissional e salário base, além de adicionar contratos por hora.

Cada trabalhador pode possuir múltiplos contratos, sendo possível calcular sua renda mensal a partir do salário base e dos contratos realizados em um determinado mês.

## Estrutura

O projeto possui as seguintes entidades principais:

- **Worker** — representa o trabalhador, contendo nome, nível, salário base e departamento.
- **Department** — representa o departamento ao qual o trabalhador pertence.
- **HourContract** — representa um contrato por hora, contendo data, valor por hora e quantidade de horas trabalhadas.
- **WorkerLevel** — enumeração que representa o nível do trabalhador: JÚNIOR, MID_LEVEL e SÊNIOR.

## Funcionalidades

- Cadastro de trabalhadores
- Associação de trabalhadores a departamentos
- Adição e remoção de contratos
- Consulta de contratos por período
- Cálculo da renda mensal do trabalhador
- Organização dos trabalhadores por nível profissional

## Tecnologias

- C#
- Programação Orientada a Objetos
- UML
