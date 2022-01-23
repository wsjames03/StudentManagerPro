Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Models
    ''' <summary>
    ''' 分数信息实体类
    ''' </summary>
    Public Class ScoreList
        Public Property Id As Integer
        Public Property StudentId As Integer
        Public Property CSharp As Integer
        Public Property SQLServerDB As Integer
        Public Property UpdateTime As DateTime
    End Class
End Namespace
