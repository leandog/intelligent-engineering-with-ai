#!/bin/bash

# Run tests and collect coverage
dotnet test --collect:"XPlat Code Coverage"

# Find the latest coverage file
coverageFile=$(find . -name coverage.cobertura.xml | sort | tail -n 1)

if [ -z "$coverageFile" ]; then
    echo "Coverage file not found!"
    exit 1
fi

echo "Coverage file located at: $coverageFile"

# Generate and display the coverage report
reportgenerator -reports:"$coverageFile" -targetdir:"coveragereport" -reporttypes:TextSummary

cat coveragereport/Summary.txt
