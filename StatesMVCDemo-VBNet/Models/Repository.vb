Public Class Repository
    Implements IRepository

    Dim entity As New StatesEntities

    Public Function GetAllStateNames() As System.Collections.Generic.List(Of StateNameEntryModel) Implements IRepository.GetAllStateNames
        Return GetAllStateNames(String.Empty)
    End Function

    Public Function GetAllStateNames(ByVal selectedStateAbbr As String) As System.Collections.Generic.List(Of StateNameEntryModel) Implements IRepository.GetAllStateNames
        Dim names As New List(Of StateNameEntryModel)

        Dim states = (From m In entity.States Order By m.stateName).ToList()

        For Each s As State In states
            names.Add(New StateNameEntryModel(s.stateName, s.stateAbbr, (selectedStateAbbr = s.stateAbbr)))
        Next
        Return names
    End Function

    Function GetStateDetails(ByVal selectedStateAbbr As String) As StateDetailModel Implements IRepository.GetStateDetails
        Return GetStateDetails(selectedStateAbbr, True)
    End Function

    Function GetStateDetails(ByVal selectedStateAbbr As String,
                             ByVal doImageFixup As Boolean) As StateDetailModel Implements IRepository.GetStateDetails

        Dim details As New StateDetailModel

        details.stateNames = GetAllStateNames(selectedStateAbbr)
        details.stateDetails = (From m In entity.States Where m.stateAbbr = selectedStateAbbr Select m).First()

        ' update the URIs for the state and seal images
        If doImageFixup Then
            If details.stateDetails.stateImageFlag <> "" Then
                details.stateDetails.stateImageFlag = IO.Path.Combine("~/Content", details.stateDetails.stateImageFlag).Replace("\", "/")
            End If
            If details.stateDetails.stateImageSeal <> "" Then
                details.stateDetails.stateImageSeal = IO.Path.Combine("~/Content", details.stateDetails.stateImageSeal).Replace("\", "/")
            End If
        End If

        Return details

    End Function

    Sub SaveStateDetails(ByVal entry As State) Implements IRepository.SaveStateDetails
        Try
            Dim s As State

            If entry.stateID <= 0 Then
                ' adding a new state
                entity.AddToStates(entry)
            Else
                ' updating an existing state
                s = (From m In entity.States Where m.stateID = entry.stateID Select m).First()
                If s IsNot Nothing Then
                    s.stateAbbr = entry.stateAbbr
                    s.stateBird = entry.stateBird
                    s.stateCapital = entry.stateCapital
                    s.stateFlower = entry.stateFlower
                    s.stateImageFlag = entry.stateImageFlag
                    s.stateImageSeal = entry.stateImageSeal
                    s.stateName = entry.stateName
                    s.stateRegion = entry.stateRegion
                    s.stateTree = entry.stateTree
                Else
                    Throw New KeyNotFoundException("State ID was not found: " & entry.stateID.ToString)
                End If
            End If

            entity.SaveChanges()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub DeleteState(ByVal stateAbbr As String) Implements IRepository.DeleteState
        If Not String.IsNullOrEmpty(stateAbbr) Then
            Dim s As State

            s = (From m In entity.States Where m.stateAbbr = stateAbbr Select m).First()
            If s IsNot Nothing Then
                entity.States.DeleteObject(s)
                entity.SaveChanges()
            End If
        End If
    End Sub

End Class
