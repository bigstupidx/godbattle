using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

/// <summary>
/// ��̬ģ��
/// </summary>
public class ModuleScope
{
    private readonly AssemblyBuilder _assemblyBuilder;

    /// <summary>
    /// ��̬�����ļ���
    /// </summary>
    public static readonly String AssemblyFileName = "CsvModelDynamicProxy.dll";

    /// <summary>
    /// ��̬��������
    /// </summary>
    public readonly String NameOfAssembly = "CsvModelDynamicProxyAssembly";

    /// <summary>
    /// �Ƿ���Ҫ���涯̬����
    /// </summary>
    public Boolean SavePhysicalAssembly { get; private set; }

    /// <summary>
    /// ModuleBuilder
    /// </summary>
    public ModuleBuilder ModuleBuilder { get; set; }

    /// <summary>
    /// ����һ���ɱ���Ķ�̬���� ModuleScope ģ��
    /// </summary>
    /// <param name="assemblySaveDir">���򼯱����Ŀ¼</param>
    public ModuleScope(String assemblySaveDir)
    {
        if (assemblySaveDir != null && !Directory.Exists(assemblySaveDir))
        {
            throw new DirectoryNotFoundException(assemblySaveDir);
        }
        _assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(NameOfAssembly), AssemblyBuilderAccess.RunAndSave, assemblySaveDir);
        ModuleBuilder = _assemblyBuilder.DefineDynamicModule(NameOfAssembly, AssemblyFileName);
        SavePhysicalAssembly = true;
    }

    /// <summary>
    /// ����һ���޷�����Ķ�̬���� ModuleScope ģ��
    /// </summary>
    public ModuleScope()
    {
        _assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(NameOfAssembly), AssemblyBuilderAccess.Run);
        ModuleBuilder = _assemblyBuilder.DefineDynamicModule(NameOfAssembly);
        SavePhysicalAssembly = false;
    }

    /// <summary>
    /// ���涯̬ģ��
    /// </summary>
    public void SaveAssembly()
    {
        if (SavePhysicalAssembly)
        {
            _assemblyBuilder.Save(AssemblyFileName);
        }
    }
}