
# Running a Self Hosted Agent(Windows & Linux) in AKS
This sample shows how to build/deploy self hosted agents in AKS with Azure DevOps including-
- Linux & Windows Agents
- C# Application(.Net5.0)
- Kubernetes C# Client
- Hashicorp Vault for Secrets
- IaC
- CICD

# Prerequisites
- Azure DevOps Account
- Docker Desktop/Docker CE
- PowerShell
- Bash
- Azure CLI

# Steps
- Local image(windows & linux) build & run to power on AzureDevOps agent
- Deploy infrastructure(AKS) to host agents
- Configure CICD 
- Deploy agent images into AKS
