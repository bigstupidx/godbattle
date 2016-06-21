/// <summary>
/// Csvģ�ʹ��������
/// </summary>
public static class CsvModelDynamicProxyHelper
{
    private static readonly CsvModelDynamicProxy DynamicProxy = new CsvModelDynamicProxy();

    /// <summary>
    /// Ϊָ�����ʹ���һ��ʹ�ù����������Ĵ���ʵ��
    /// </summary>
    /// <typeparam name="T">����������</typeparam>
    /// <returns>����ʵ��</returns>
    public static T Of<T>() where T : class, new()
    {
        return DynamicProxy.Of<T>();
    }

    /// <summary>
    /// Ϊָ�����ʹ���һ��ʹ�ö����������Ĵ���ʵ��
    /// </summary>
    /// <typeparam name="T">����������</typeparam>
    /// <returns>����ʵ��</returns>
    public static T OfWithIndependentPropertyInterceptor<T>() where T : class, new()
    {
        return DynamicProxy.Of<T>(new IndependentPropertyInterceptor());
    }
}