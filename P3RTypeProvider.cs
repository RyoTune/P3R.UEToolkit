using System.Reflection;
using UE.Toolkit.Interfaces.ObjectWriters;

namespace P3R.UEToolkit;

public class P3RTypeProvider : ITypeProvider
{
    private readonly Assembly _asm = Assembly.Load("RyoTune.Persona3Reload.Types");
    public bool CanProvide(string typeName) => _asm.GetType($"RyoTune.Persona3Reload.Types.{typeName}") != null;
    public Type GetType(string typeName) => _asm.GetType($"RyoTune.Persona3Reload.Types.{typeName}")!;
    public string Id => "P3R.UEToolkit";
}