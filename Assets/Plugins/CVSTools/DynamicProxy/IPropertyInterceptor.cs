using System;

/// <summary>
/// �����������ӿ�
/// </summary>
public interface IPropertyInterceptor
{
    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Int32 propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Int32[] propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Int64 propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Int64[] propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Single propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Single[] propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Double propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Double[] propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Decimal propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, Decimal[] propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, String propValue, Boolean update);

    /// <summary>
    /// ���ʶ�������ʱ����
    /// </summary>
    /// <param name="obj">Ŀ�����ʵ��</param>
    /// <param name="propName">��������</param>
    /// <param name="propValue">����ֵ</param>
    /// <param name="update">��������ʱΪfalse���������Խ�����֤����֤ʧ���׳��쳣�� ��������ʱΪtrue���������ú������֤�롣</param>
    /// <exception cref="CsvModelPropertyVerificationException">��������ʱ�����Խ�����֤����֤ʧ���׳����쳣</exception>
    void Invoke(Object obj, String propName, String[] propValue, Boolean update);
}