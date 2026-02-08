# payments_core

`payments_core` is a **distributed, event-driven Payments Core** designed to orchestrate financial transactions across multiple payment providers, focusing on **reliability, predictability, and safe evolution**.

The project models payments as **long-running, distributed processes**, rather than simple synchronous HTTP calls, reflecting real-world payment systems and production constraints.

---

## 🎯 Project Goals

- Orchestrate payments **decoupled from payment providers**
- Keep the **domain isolated and expressive**
- Handle **asynchronous and distributed workflows**
- Enable observability, replayability, and auditing
- Simulate real production scenarios (failures, retries, duplicated events)

---

## 🧠 Architecture & Concepts

The system applies architectural patterns commonly used in real financial systems:

- **Domain-Driven Design (DDD)**
- **Event-Driven Architecture**
- **Event Sourcing (conceptually applied)**
- **Ports & Adapters (Hexagonal Architecture)**
- **Clean Architecture**

### High-Level Flow

```text
Request → Controller → Use Case
       → Domain (Aggregates & Rules)
       → Persistence
       → Domain Events
       → Event Bus
       → Event Handlers (Webhooks, Notifications, etc.)
```
### 🧩 Payments Domain

Payments are modeled as stateful processes, not atomic operations.

Example lifecycle states:

- CREATED
- AUTHORIZATION_REQUESTED
- AUTHORIZED
- CONFIRMED
- SETTLED
- FAILED
- CANCELED
- CHARGEBACK

All meaningful transitions are represented as domain events, ensuring traceability and auditability.

### 🔌 Payment Providers Integration

Communication with payment providers is done through ports, allowing:

- Easy replacement or addition of providers
- Isolation of technical concerns (HTTP, authentication, retries)
- Simulation of real provider behavior and failures

Example providers (simulated or abstracted):

- Cielo
- Rede
- Getnet

### 📣 Events & Webhooks

- Domain events represent business facts
- Event handlers react to these events to:
  - Send webhooks
  - Notify external systems
  - Trigger side effects
- The system assumes events can be:
  - duplicated
  - delayed
  - delivered out of order

### 🛠️ Technologies (planned / in progress)
- .NET / C#
- REST APIs
- Docker
- Messaging (simulated or real)
- PostgreSQL
- Structured logging and observability

### 🚧 Project Status

🔧 Work in progress

This project is part of a technical portfolio, focused on architecture, design decisions, and production-oriented thinking — not on delivering a complete commercial product.

### 📌 Final Notes

This project is not a payment gateway.
It is an exploration of how to design and evolve a reliable Payments Core, prepared for distributed systems, asynchronous workflows, and real-world operational challenges.
