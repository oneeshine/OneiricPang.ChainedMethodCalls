using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OneiricPang.ChainedMethodCalls
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class ChainedMethodCallDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        public static readonly DiagnosticDescriptor LostPartialRule = new DiagnosticDescriptor(id: "Chained001", title: "缺少Partial修饰符", messageFormat: "{0} 缺少Partial修饰符", category: "Design", defaultSeverity: DiagnosticSeverity.Error, isEnabledByDefault: true, description: "ChainedMethodCallObject需要Partial修饰符.");


        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.CreateRange([LostPartialRule]);

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.EnableConcurrentExecution();
            //context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.ClassDeclaration);
        }
        private void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {           
            if (context.Node is ClassDeclarationSyntax classDeclaration ) { 
            
              
            }
        }
    }
}

