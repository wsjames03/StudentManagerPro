Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Models

    ''' <summary>
    ''' 学员实体类
    ''' </summary>
    Public Class StudentExt
        Inherits Student

        '班级姓名
        Public Property ClassName As String

        'C#
        Public Property CSharp As Integer

        'SQL DB
        Public Property SQLServerDB As Integer

    End Class

End Namespace
