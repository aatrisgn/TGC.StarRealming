# Instructions

This contains all the instructions for Claude Code. It is divided into four sections:
- Angular Frontend
- .Net backend
- Terraform - Infrastructure
- Github Actions (CI / CD)

## Angular Frontend
- Always use standalone components

## .Net backend
- Ensure to follow clean architecture division of entities
- Follow coding guidelines in TGC.CSharpCodingStandards. Add as NuGet package if not already present
- Always document public methods with XML comments
- Use .Net 10
- Always use xUnit for unit tests
- Use CQRS for commands / queries executed by controllers.

## Terraform - Infrastructure
- Always use the following naming standard for Azure resources: {Resource_type_shortcode}-{application_name}-{Optional: sub_application_name}-{environment}-{region_shortcode}

## Github Actions (CI / CD)
- Never write-out any potential confidential values!
