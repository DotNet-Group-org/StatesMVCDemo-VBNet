Public Class StateNameEntryModel

    Public Property stateName As String = String.Empty
    Public Property stateAbbr As String = String.Empty
    Public Property isSelected As Boolean = False

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String,
                   ByVal abbr As String,
                   ByVal selected As Boolean)
        stateName = name
        stateAbbr = abbr
        isSelected = selected
    End Sub

End Class
