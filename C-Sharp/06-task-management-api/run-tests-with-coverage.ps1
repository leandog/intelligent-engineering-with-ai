# Remove existing TestResults directory
Remove-Item -Recurse -Force TaskManagementApiTests/TestResults -ErrorAction Ignore

# Run tests and collect coverage
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[TaskManagementApi]*TaskManagementApi.Migrations.*"

# Find the latest coverage file
$coverageFile = Get-ChildItem -Recurse -Filter coverage.cobertura.xml | Sort-Object LastWriteTime -Descending | Select-Object -First 1

if ($null -eq $coverageFile) {
    Write-Host "Coverage file not found!"
    exit 1
}

Write-Host "Coverage file located at: $($coverageFile.FullName)"

# Generate and display the coverage report
reportgenerator -reports:$coverageFile.FullName -targetdir:"coveragereport" -reporttypes:TextSummary

Get-Content coveragereport/Summary.txt
