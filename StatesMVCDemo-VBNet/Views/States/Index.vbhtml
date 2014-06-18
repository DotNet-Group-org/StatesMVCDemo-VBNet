@Imports StatesMVCDemo_VBNet
@ModelType List(Of StatesMVCDemo_VBNet.StateNameEntryModel)

@Code
    ViewData("Title") = "States"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", Model)
        </td>

        <td class="stateTableCellData">
        </td>
    </tr>
</table>

