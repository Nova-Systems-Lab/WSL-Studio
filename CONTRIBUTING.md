# Contributing to WSL Studio

Thank you for considering a contribution to WSL Studio. The project is in active development, currently in **Phase 3 — WSL Workspace** (see the [roadmap](docs/roadmap.md)). The application is intentionally **read-only** with respect to WSL state during this phase, so contributions should focus on read-only discovery, diagnostics, inspection, workspace polish, documentation, tests, and architecture review.

Mutating or destructive WSL operations (start, stop, terminate, shutdown, import, export, unregister, configuration editing) are deferred to later phases and should not be introduced unless an issue explicitly schedules them.

## Branch Strategy

The repository will use a simple branch strategy during early development:

- `main` is the stable development branch.
- Feature work should happen on short-lived branches.
- Branch names should describe the work, such as `docs/security-model` or `feature/distribution-list`.
- Pull requests should be small enough to review carefully.

Long-lived release branches may be introduced when the project approaches public releases.

## Coding Standards

The implementation stack is C#, .NET 10, WinUI 3, Windows App SDK, CommunityToolkit.Mvvm, the .NET Generic Host, and xUnit. SQLite is planned for application-owned data in a later phase.

Contributors should follow these standards:

- Prefer clear, maintainable C# over clever abstractions.
- Keep UI code separate from WSL command execution; the UI does not call `wsl.exe` directly.
- Route WSL operations through reviewed application services; view models call services rather than executing processes or parsing output.
- Use structured process execution rather than shell-interpolated command strings.
- Add tests for parsing, validation, command construction, and safety policies.
- Keep public behavior documented when it affects users.
- Follow established .NET naming and formatting conventions.

## Pull Request Expectations

Pull requests should include:

- A clear description of the change.
- The reason the change is needed.
- Any relevant issue links.
- Notes about testing or validation performed.
- Screenshots only when UI exists and the screenshot is real.

Pull requests should avoid:

- Mixing unrelated changes.
- Adding undocumented dependencies.
- Introducing unsupported WSL internals.
- Adding destructive operations without security-model updates.
- Creating CI/CD, packaging, or application scaffolding before the relevant project phase.

## Issue Reporting

Useful issues include:

- Documentation gaps or inconsistencies.
- Confirmed WSL command behavior that affects the command map.
- Safety concerns.
- Usability concerns.
- Feature proposals that align with official WSL functionality.

When reporting a behavior issue in future application phases, include:

- Windows version.
- WSL version information, if available.
- Distribution name and version, if relevant.
- Steps to reproduce.
- Expected behavior.
- Actual behavior.
- Error output, with sensitive information removed.

Please do not include secrets, private keys, access tokens, or sensitive files from a WSL distribution.

## Code Review Philosophy

Code review should protect maintainability and user safety. Reviews should focus on:

- Correctness.
- Clear ownership boundaries.
- Test coverage for meaningful behavior.
- Safe command construction.
- Validation and confirmation for risky operations.
- Readable user-facing errors.
- Alignment with the documented architecture and security model.

Review feedback should be specific, respectful, and grounded in the project goals. Contributors should expect careful review for any feature that changes WSL state, touches user data, or affects destructive operations.

## Documentation Contributions

Documentation should use a professional open-source tone. Avoid marketing language, unsupported claims, and promises about features that have not been designed or implemented.

Good documentation contributions:

- Clarify project scope.
- Correct command references.
- Improve safety explanations.
- Make future implementation work easier to review.
- Keep documents consistent with one another.

## Development Phase Notes

During Phase 3 (WSL Workspace), the application stays read-only:

- Do not add commands that start, stop, terminate, shut down, import, export, or unregister distributions.
- Do not add configuration editing or other state-changing WSL operations.
- Do not introduce background services or performance monitoring that runs continuously.
- Do not add invented screenshots, badges, release artifacts, or fake production data.

GitHub Actions and MSIX packaging are scheduled for a later phase. These items, and any state-changing WSL operations, will be introduced when the roadmap and security model are ready for them.
