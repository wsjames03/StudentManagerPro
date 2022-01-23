Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Models

    ''' <summary>
    ''' 学员实体类
    ''' </summary>
    Public Class Student
        Public Property StudentId As Integer
        Public Property StudentName As String
        Public Property Gender As String
        Public Property Birthday As DateTime
        '将数据库中的18位整数转换成字符串
        Public Property StudentIdNo As String
        Public Property Age As Integer
        Public Property PhoneNumber As String
        Public Property StudentAddress As String
        Public Property CardNo As String
        Public Property ClassId As Integer
    End Class

End Namespace
