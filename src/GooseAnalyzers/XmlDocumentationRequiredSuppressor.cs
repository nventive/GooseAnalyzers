using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;

namespace GooseAnalyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class XmlDocumentationRequiredSuppressor : DiagnosticSuppressor
{
	public static readonly string[] SuppressedDiagnosticIds = { "CS1591", "SA1600" };

	public static readonly IReadOnlyDictionary<string, SuppressionDescriptor> SuppressionDescriptorByDiagnosticId = SuppressedDiagnosticIds.ToDictionary(
		id => id,
		id => new SuppressionDescriptor("GOOSE001", id, "XML documentation is most important on interface members, but not on everything else."));

	public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions { get; } = ImmutableArray.CreateRange(SuppressionDescriptorByDiagnosticId.Values);

	public override void ReportSuppressions(SuppressionAnalysisContext context)
	{
		foreach (var diagnostic in context.ReportedDiagnostics)
		{
			if (!context.CancellationToken.IsCancellationRequested)
			{
				Location location = diagnostic.Location;
				SyntaxNode? node = location.SourceTree?.GetRoot(context.CancellationToken).FindNode(location.SourceSpan);
				if (!(node is InterfaceDeclarationSyntax || HasParentOfType<InterfaceDeclarationSyntax>(node)))
				{
					context.ReportSuppression(Suppression.Create(SuppressionDescriptorByDiagnosticId[diagnostic.Id], diagnostic));
				}
			}
		}
	}

	public bool HasParentOfType<TSearched>(SyntaxNode? syntaxNode) where TSearched : SyntaxNode
	{
		return syntaxNode != null && (syntaxNode.Parent is TSearched || HasParentOfType<TSearched>(syntaxNode.Parent));
	}
}
