# Run tests and collect coverage
dotnet test --collect:"XPlat Code Coverage"

# Find the latest coverage file
$coverageFile = Get-ChildItem -Recurse -Filter coverage.cobertura.xml | Sort-Object LastWriteTime | Select-Object -Last 1

if (-not $coverageFile) {
    Write-Host "Coverage file not found!"
    exit 1
}

Write-Host "Coverage file located at: $coverageFile"

# Generate and display the coverage report
reportgenerator -reports:"$coverageFile" -targetdir:"coveragereport" -reporttypes:TextSummary

# Path to the summary report
$summaryReportPath = "coveragereport/Summary.txt"

# Check if the summary report exists
if (Test-Path $summaryReportPath) {
    # Read and display the contents of the summary report
    Get-Content $summaryReportPath | ForEach-Object { Write-Host $_ }
} else {
    Write-Host "Summary report not found!"
}
