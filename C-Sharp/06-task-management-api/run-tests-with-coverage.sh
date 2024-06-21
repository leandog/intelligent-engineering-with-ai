#!/bin/bash

rm -rf TaskManagementApiTests/TestResults

# Run tests and collect coverage
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude=\"[TaskManagementApi]*TaskManagementApi.Migrations.*,[TaskManagementApi]TaskManagementApi.Program,[TaskManagementApi]TaskManagementApi.Startup\"

# Find the latest coverage file
coverageFile=$(find . -name coverage.cobertura.xml)

if [ -z "$coverageFile" ]; then
    echo "Coverage file not found!"
    exit 1
fi

echo "Coverage file located at: $coverageFile"

# Generate and display the coverage report
reportgenerator -reports:"$coverageFile" -targetdir:"coveragereport" -reporttypes:TextSummary

cat coveragereport/Summary.txt
