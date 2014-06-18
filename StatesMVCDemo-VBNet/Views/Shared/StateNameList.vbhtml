@Imports StatesMVCDemo_VBNet
@ModelType List(Of StatesMVCDemo_VBNet.StateNameEntryModel)

@Code
    Dim className As String = String.Empty
End Code

@For Each entry As StateNameEntryModel In Model
    If entry.isSelected Then
        className = "stateNameBlockSelected"
    Else
        className = "stateNameBlockUnselected"
    End If

    @<div class="@classname">
        @If entry.isSelected Then
            @entry.stateName
        Else
            @Html.ActionLink(entry.stateName, "Details", "State", New With {.id = entry.stateAbbr}, Nothing)
        End If
    </div>
Next

<div class="stateNameCreateLabel">
    [&nbsp;@Html.ActionLink("Create New State", "Create", "State")&nbsp;]
</div>
