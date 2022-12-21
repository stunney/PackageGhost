TENANT=<TODO>
SUBSCRIPTION=<TODO>

az account set -s $SUBSCRIPTION
az login --tenant $TENANT

dotnet build -c Release && dotnet publish -c Release && func azure functionapp publish ghostpack