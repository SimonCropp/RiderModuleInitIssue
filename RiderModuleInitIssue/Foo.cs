using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[AttributeUsage(
    validOn: AttributeTargets.Method,
    Inherited = false)]
sealed class ModuleInitializerAttribute :
    Attribute
{
}