using System;

/// <summary>
///  PropertyInterceptor������֤ʧ��ʱ�׳�
/// </summary>
public class CsvModelPropertyVerificationException : Exception
{
    public CsvModelPropertyVerificationException(String propName)
        : base(String.Format("Csvģ������( {0} )��֤ʧ�ܡ�", propName))
    {
        
    }
}