using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PrivateFieldNamingAnalyzer : DiagnosticAnalyzer
    {
        // Unique ID for your diagnostic rule
        public const string DiagnosticId = "RULE001";

        private static readonly LocalizableString Title = "Private field naming convention";
        private static readonly LocalizableString MessageFormat = "Private field '{0}' must start with an underscore ('_')";
        private static readonly LocalizableString Description = "Enforces that private fields follow the '_name' convention.";
        private const string Category = "Naming";

        // Define the Rule Descriptor
        private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(
            DiagnosticId,
            Title,
            MessageFormat,
            Category,
            DiagnosticSeverity.Warning, // Warning, Error, or Info
            isEnabledByDefault: true,
            description: Description);

        // Register supported diagnostics
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            // Roslyn best practices for performance and generated code
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
            context.EnableConcurrentExecution();

            // Register a callback to analyze symbols of type Field
            context.RegisterSymbolAction(AnalyzeField, SymbolKind.Field);
        }

        private static void AnalyzeField(SymbolAnalysisContext context)
        {
            var fieldSymbol = (IFieldSymbol)context.Symbol;

            // 1. Only analyze private fields
            if (fieldSymbol.DeclaredAccessibility != Accessibility.Private)
                return;

            // 2. Ignore compiler-generated backing fields (e.g., auto-properties)
            if (fieldSymbol.IsImplicitlyDeclared)
                return;

            // 3. Check naming rule
            if (!fieldSymbol.Name.StartsWith("_"))
            {
                // Create a diagnostic pointing to the exact field declaration in source code
                var diagnostic = Diagnostic.Create(
                    Rule, 
                    fieldSymbol.Locations[0], 
                    fieldSymbol.Name
                );

                // Report the warning back to the compiler/IDE
                context.ReportDiagnostic(diagnostic);
            }
        }
    }
}
