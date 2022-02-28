
# Running a Self Hosted Agent(Windows & Linux) in AKS
This sample intends to show how to build/deploy self hosted agents in AKS with Azure DevOps including-
- Linux & Windows Agents Dockerfiles & Necessary Scripts
- .Net(6.0) Application with C# & Kubernetes C# Client for dynamic agent spinup
- Hashicorp Vault for Secrets
- IaC
- CICD

# Prerequisites
Prerequisites are listed down for local development

## Local Devlopment
- Vault unsealed local setup(includes Vault CLI & UI) with in memory storage
- Docker Desktop
- Azure CLI
- Helm
- Jq
- PowerShell
- Git Bash
- Azure DevOps Account

# Steps
- Local image(windows & linux) build & run to power AzureDevOps agent
- Deploy infrastructure(AKS) to host agents
- Configure CICD to deploy agent containers on AKS 
- Deploy agent images into AKS
