
# Running a Self Hosted Agent(Windows & Linux) in AKS
This sample shows how to build/deploy self hosted agents in AKS with Azure DevOps including-
- Linux & Windows Agents Dockerfiles & Necessary Scripts
- .Net(6.0) Application with C# & Kubernetes C# Client
- Hashicorp Vault for Secrets
- IaC
- CICD

# Prerequisites
- Vault unsealed local setup(includes Vault CLI & UI) with in memory storage
- Docker Desktop/Docker CE
- Azure CLI
- Azure DevOps Account
- Helm
- Jq
- PowerShell
- Git Bash

# Steps
- Local image(windows & linux) build & run to power AzureDevOps agent
- Deploy infrastructure(AKS) to host agents
- Configure CICD to deploy agent containers on AKS 
- Deploy agent images into AKS
