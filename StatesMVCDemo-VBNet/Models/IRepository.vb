Public Interface IRepository

    Function GetAllStateNames() As List(Of StateNameEntryModel)
    Function GetAllStateNames(ByVal selectedStateAbbr As String) As List(Of StateNameEntryModel)

    Function GetStateDetails(ByVal selectedStateAbbr As String) As StateDetailModel
    Function GetStateDetails(ByVal selectedStateAbbr As String,
                             ByVal doImageFixup As Boolean) As StateDetailModel

    Sub SaveStateDetails(ByVal entry As State)

    Sub DeleteState(ByVal stateAbbr As String)
End Interface
