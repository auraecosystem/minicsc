dotnet new console -n MiniCsc
cd MiniCsc
dotnet add package Microsoft.CodeAnalysis.CSharp
git add .github/workflows/build-and-test.yml
git commit -m "Add CI build and test workflow"
git push origin main
dotnet add package Microsoft.CodeAnalysis.CSharp
dotnet add package Microsoft.CodeAnalysis.Analyzers
