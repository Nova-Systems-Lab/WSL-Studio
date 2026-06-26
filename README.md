# WSL Studio

![Status](https://img.shields.io/badge/status-active%20development-success)
![Platform](https://img.shields.io/badge/platform-Windows%2011-blue)
![Framework](https://img.shields.io/badge/.NET-10-purple)
![License](https://img.shields.io/badge/license-MIT-green)
![Development](https://img.shields.io/badge/development-Phase%203-orange)

WSL Studio is an open-source native Windows 11 application for managing Windows Subsystem for Linux (WSL) through a modern WinUI 3 interface.

The project focuses on providing a safe, discoverable, and Microsoft-style desktop experience built on top of officially supported WSL functionality. Rather than replacing the command line, WSL Studio complements it by exposing common management, diagnostics, and configuration workflows through a polished graphical interface.

Inspired by the usability of Docker Desktop while remaining focused entirely on Windows Subsystem for Linux and its official feature set.

> **Note**
>
> WSL Studio aims to support officially documented WSL features. Feature availability may vary depending on the installed WSL version and Windows release.

## Project Status

| Component | Status |
|-----------|--------|
| Documentation | ✅ |
| Architecture | ✅ |
| WinUI Shell | ✅ |
| WSL Discovery | ✅ |
| Dashboard | ✅ |
| Design System | ✅ |
| Lifecycle Management | 🚧 |
| Backup & Recovery | ⏳ |
| Configuration | ⏳ |

## Vision

WSL is an important part of many Windows development workflows, but day-to-day management is still centered around command-line usage. WSL Studio aims to provide a focused desktop experience for common WSL management tasks while preserving the behavior, safety, and expectations of official WSL tooling.

The long-term goal is not to replace the WSL command line. The goal is to expose official WSL functionality through a clear, modern, native Windows interface that helps users inspect, manage, and operate their distributions with confidence.

## Why WSL Studio?

WSL has evolved into an essential part of Windows development, but most management tasks still rely on remembering command-line syntax or manually editing configuration files.

WSL Studio aims to simplify those workflows by providing a modern desktop interface that complements—not replaces—the official WSL tools.

## Features

### Implemented

- Native WinUI 3 application shell
- Dashboard overview
- Read-only WSL distribution discovery
- Official WSL command runner
- Dependency injection using Generic Host
- Clean Architecture
- Reusable Fluent design system

### Planned

- WSL Health Center
- Distribution details
- Search and filtering
- Diagnostics viewer
- Backup and recovery
- Configuration management
- Safe lifecycle operations
- Docker integration
- VS Code integration
- Performance monitoring
- Linux GUI and remote desktop management

## Technology Stack

WSL Studio currently uses:

- C#
- .NET 10
- WinUI 3
- Windows App SDK
- CommunityToolkit.Mvvm
- Microsoft.Extensions.Hosting
- xUnit
- SQLite (planned)
- GitHub Actions (planned)
- MSIX Packaging (planned)

## Project Scope

WSL Studio is intended to manage WSL using officially supported Windows interfaces.

The project does not aim to:

- Replace `wsl.exe`
- Modify undocumented WSL internals
- Introduce proprietary WSL functionality
- Run unnecessary background services
- Become another Linux terminal

Instead, it focuses on making existing WSL capabilities easier to discover, configure, and use.

## Project Philosophy

WSL Studio is designed around a few durable principles:

- Use official WSL functionality whenever possible.
- Do not modify WSL internals directly.
- Prefer safety and clarity over convenience.
- Require explicit confirmation before destructive actions.
- Validate configuration before applying changes.
- Start quickly and avoid unnecessary background services.
- Follow modern Windows 11 Fluent Design principles.
- Keep the codebase modular, testable, and maintainable.
- Build in the open with clear documentation and reviewable changes.

## Current Status

🚧 **Active Development**

WSL Studio is currently in active development.

Implemented so far:

- Native WinUI 3 application shell
- Clean Architecture solution structure
- Generic Host dependency injection
- CommunityToolkit.Mvvm integration
- Read-only WSL distribution discovery
- Dashboard overview
- WSL command execution infrastructure
- Reusable WinUI design system
- Comprehensive documentation and Architecture Decision Records (ADRs)

Current work is focused on **Phase 3 — WSL Workspace**, expanding diagnostics, inspection, and developer workflows before introducing lifecycle management operations.

## Roadmap

- Phase 0 — Planning
- Phase 1 — Foundation
- Phase 2 — Core WSL Integration
- Phase 3 — WSL Workspace
- Phase 4 — Safe WSL Operations
- Phase 5 — Backup & Recovery
- Phase 6 — Configuration
- Phase 7 — Advanced Integrations
- Phase 8 — Linux GUI & Remote Desktop

See [docs/roadmap.md](docs/roadmap.md) for the detailed roadmap.

## Screenshots

> Screenshots will be updated as development progresses.

### Dashboard

*(Coming soon)*

### Distributions

*(Coming soon)*

## Architecture

```text
WinUI 3
    │
Presentation
    │
Application
    │
Core
    │
Infrastructure
    │
┌─────────────┬─────────────┬──────────────┐
│   wsl.exe   │ PowerShell  │   SQLite     │
└─────────────┴─────────────┴──────────────┘
```
## Documentation

- [Project Blueprint](docs/blueprint.md)
- [Architecture](docs/architecture.md)
- [Architecture Decision Records](docs/adr/)
- [Roadmap](docs/roadmap.md)
- [Security Model](docs/security-model.md)
- [Command Map](docs/command-map.md)
- [Contributing Guide](CONTRIBUTING.md)

## Contributing

WSL Studio is under active development, and contributions are welcome.

Whether you're interested in improving documentation, refining the architecture, enhancing the WinUI interface, writing tests, or implementing new features, your help is appreciated.

Please review [CONTRIBUTING.md](CONTRIBUTING.md) before opening a pull request.

## Development Philosophy

WSL Studio follows a quality-first development approach.

Every feature is designed around:

- Official Microsoft APIs and tooling
- Safe defaults
- Clear architecture boundaries
- Comprehensive testing
- Modern Windows 11 design principles
- Incremental, reviewable development
- Long-term maintainability

The project prioritizes correctness, usability, and transparency over rapid feature growth.

## License

This project is licensed under the MIT License.
